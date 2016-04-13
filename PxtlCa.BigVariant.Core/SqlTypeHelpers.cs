using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Data;

namespace PxtlCa.BigVariant.Core
{
    public abstract class SqlTypeHelper
    {
        public abstract SqlTypeEnum SqlType { get; }
        public abstract void Write(BinaryWriter w, Object value);
        public abstract Object Read(BinaryReader r);
        public abstract String ToString(Object value);
        public abstract int GetHashCode(Object value);
    }

    public class SqlNullHelper : SqlTypeHelper
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlNull; } }
        public override object Read(BinaryReader r) { return null; }
        public override void Write(BinaryWriter w, Object value) { } //noop
        public override string ToString(Object value) { return "NULL"; }
        public override int GetHashCode(Object value) { return 0; }
    }

    public abstract class TypedSqlTypeHelper<T> : SqlTypeHelper
    {
        public override void Write(BinaryWriter w, Object value)
        {
            WriteImpl(w, (T)value);
        }
        protected abstract void WriteImpl(BinaryWriter w, T value);

        public override String ToString(Object value)
        {
            return ToStringImpl((T)value);
        }

        protected virtual String ToStringImpl(T value)
        {
            return value.ToString();
        }

        public override int GetHashCode(object value)
        {
            return GetHashCodeImpl((T)value);
        }

        protected abstract int GetHashCodeImpl(T value);
    }

    public class SqlBinaryHelper : TypedSqlTypeHelper<SqlBinary>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlBinary; } }
        public override object Read(BinaryReader r) { return (SqlBinary)r.ReadBytes((int)(r.BaseStream.Length - r.BaseStream.Position)); }
        protected override void WriteImpl(BinaryWriter w, SqlBinary value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlBinary value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlBinary value) { return value.Value.GetHashCode(); }
    }

    public class SqlByteHelper : TypedSqlTypeHelper<SqlByte>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlByte; } }
        public override object Read(BinaryReader r) { return (SqlByte)r.ReadByte(); }
        protected override void WriteImpl(BinaryWriter w, SqlByte value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlByte value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlByte value) { return value.Value.GetHashCode(); }
    }

    public class SqlBooleanHelper : TypedSqlTypeHelper<SqlBoolean>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlBoolean; } }
        public override object Read(BinaryReader r) { return (SqlBoolean)r.ReadBoolean(); }
        protected override void WriteImpl(BinaryWriter w, SqlBoolean value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlBoolean value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlBoolean value) { return value.Value.GetHashCode(); }
    }

    public class SqlDateTimeHelper : TypedSqlTypeHelper<SqlDateTime>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlDateTime; } }
        public override object Read(BinaryReader r) {
            var dayTicks = r.ReadInt32();
            var timeTicks = r.ReadInt32();
            return new SqlDateTime(dayTicks, timeTicks); }
        protected override void WriteImpl(BinaryWriter w, SqlDateTime value) {
            w.Write(value.DayTicks);
            w.Write(value.TimeTicks);
        }
        protected override string ToStringImpl(SqlDateTime value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlDateTime value) { return value.Value.GetHashCode(); }
    }

    public class DateTimeHelper : TypedSqlTypeHelper<DateTime>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.DateTime; } }
        public override object Read(BinaryReader r)
        {
            var ticks = r.ReadInt64();
            var kind = (DateTimeKind)r.ReadInt32();
            return new DateTime(ticks, kind);
        }
        protected override void WriteImpl(BinaryWriter w, DateTime value)
        {
            w.Write(value.Ticks);
            w.Write((int)value.Kind);
        }
        protected override string ToStringImpl(DateTime value) { return value.ToString(); }
        protected override int GetHashCodeImpl(DateTime value) { return value.GetHashCode(); }
    }

    public class DateTimeOffsetHelper : TypedSqlTypeHelper<DateTimeOffset>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.DateTimeOffset; } }
        public override object Read(BinaryReader r)
        {
            var ticks = r.ReadInt64();
            var offset = new TimeSpan(r.ReadInt64());
            return new DateTimeOffset(ticks, offset);
        }
        protected override void WriteImpl(BinaryWriter w, DateTimeOffset value)
        {
            w.Write(value.Ticks);
            w.Write(value.Offset.Ticks);
        }
        protected override string ToStringImpl(DateTimeOffset value) { return value.ToString(); }
        protected override int GetHashCodeImpl(DateTimeOffset value) { return value.GetHashCode(); }
    }

    public class SqlDecimalHelper : TypedSqlTypeHelper<SqlDecimal>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlDecimal; } }
        public override object Read(BinaryReader r)
        {
            var precision = r.ReadByte();
            var scale = r.ReadByte();
            var isPositive = r.ReadBoolean();
            var data = new int[4];
            data[0] = r.ReadInt32();
            data[1] = r.ReadInt32();
            data[2] = r.ReadInt32();
            data[3] = r.ReadInt32();
            return new SqlDecimal(precision, scale, isPositive, data);
        }
        protected override void WriteImpl(BinaryWriter w, SqlDecimal value)
        {
            w.Write(value.Precision);
            w.Write(value.Scale);
            w.Write(value.IsPositive);
            foreach(var intData in value.Data)
            { 
                w.Write(intData);
            }
        }
        protected override string ToStringImpl(SqlDecimal value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlDecimal value) { return value.Value.GetHashCode(); }
    }

    public class SqlDoubleHelper : TypedSqlTypeHelper<SqlDouble>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlDouble; } }
        public override object Read(BinaryReader r) { return (SqlDouble)r.ReadDouble(); }
        protected override void WriteImpl(BinaryWriter w, SqlDouble value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlDouble value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlDouble value) { return value.Value.GetHashCode(); }
    }

    public class SqlGuidHelper : TypedSqlTypeHelper<SqlGuid>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlGuid; } }
        public override object Read(BinaryReader r) { return new SqlGuid(r.ReadBytes(16)); }
        protected override void WriteImpl(BinaryWriter w, SqlGuid value) { w.Write(value.ToByteArray()); }
        protected override string ToStringImpl(SqlGuid value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlGuid value) { return value.Value.GetHashCode(); }
    }

    public class SqlMoneyHelper : TypedSqlTypeHelper<SqlMoney>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlMoney; } }
        public override object Read(BinaryReader r) { return (SqlMoney)r.ReadDecimal(); }
        protected override void WriteImpl(BinaryWriter w, SqlMoney value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlMoney value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlMoney value) { return value.Value.GetHashCode(); }
    }

    public class SqlInt16Helper : TypedSqlTypeHelper<SqlInt16>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlInt16; } }
        public override object Read(BinaryReader r) { return (SqlInt16)r.ReadInt16(); }
        protected override void WriteImpl(BinaryWriter w, SqlInt16 value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlInt16 value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlInt16 value) { return value.Value.GetHashCode(); }
    }

    public class SqlInt32Helper : TypedSqlTypeHelper<SqlInt32>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlInt32; } }
        public override object Read(BinaryReader r) { return (SqlInt32)r.ReadInt32(); }
        protected override void WriteImpl(BinaryWriter w, SqlInt32 value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlInt32 value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlInt32 value) { return value.Value.GetHashCode(); }
    }
    public class SqlInt64Helper : TypedSqlTypeHelper<SqlInt64>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlInt64; } }
        public override object Read(BinaryReader r) { return (SqlInt64)r.ReadInt64(); }
        protected override void WriteImpl(BinaryWriter w, SqlInt64 value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlInt64 value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlInt64 value) { return value.Value.GetHashCode(); }
    }
    public class SqlStringHelper : TypedSqlTypeHelper<SqlString>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlString; } }
        public override object Read(BinaryReader r)
        {
            return new SqlString(r.ReadString()); //TODO: switch to proper byte-array 
        }
        protected override void WriteImpl(BinaryWriter w, SqlString value)
        {
            w.Write((String)(value)); //TODO: switch to proper byte-array
        }
        protected override string ToStringImpl(SqlString value) { return value.Value; }
        protected override int GetHashCodeImpl(SqlString value) { return value.Value.GetHashCode(); }
    }
    public class SqlSingleHelper : TypedSqlTypeHelper<SqlSingle>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlSingle; } }
        public override object Read(BinaryReader r) { return (SqlSingle)r.ReadSingle(); }
        protected override void WriteImpl(BinaryWriter w, SqlSingle value) { w.Write(value.Value); }
        protected override string ToStringImpl(SqlSingle value) { return value.Value.ToString(); }
        protected override int GetHashCodeImpl(SqlSingle value) { return value.Value.GetHashCode(); }
    }
    public class SqlXmlHelper : TypedSqlTypeHelper<SqlXml>
    {
        public override SqlTypeEnum SqlType { get { return SqlTypeEnum.SqlXml; } }
        public override object Read(BinaryReader r)
        {
            return new SqlXml(new XmlTextReader(r.BaseStream));
        }
        protected override void WriteImpl(BinaryWriter w, SqlXml value)
        {
            ((System.Xml.Serialization.IXmlSerializable)value).WriteXml(new XmlTextWriter(w.BaseStream, Encoding.Unicode));
        }
        protected override string ToStringImpl(SqlXml value) { return value.Value; }
        protected override int GetHashCodeImpl(SqlXml value) { return value.Value.GetHashCode(); }
    }
}
