using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
using System.Data;

namespace PxtlCa.BigVariant.Core
{
    [SqlUserDefinedType(Format.UserDefined, IsFixedLength = false, MaxByteSize = -1)]
    public struct BigVariant : IBinarySerialize, INullable
    {
        private SqlTypeEnum _SqlTypeEnum;
        internal SqlTypeEnum SqlTypeEnum { get { return _SqlTypeEnum; } }

        public string Type { get { return SqlTypeEnum.ToString(); } }
        public SqlTypeHelper TypeHelper { get { return SqlTypeExtensions.GetHelper(SqlTypeEnum); } }

        public BigVariant(Object value)
        {
            _Value = value;
            _IsNull = (value == null || value is INullable && ((INullable)value).IsNull);
            _SqlTypeEnum = SqlTypeExtensions.GetSqlTypeFromType(value.GetType());
        }

        private object _Value;
        public object Value { get { return _Value; } }

        private bool _IsNull { get; }
        public bool IsNull { get { return _IsNull; } }

        [SqlFacet(IsNullable = true)]
        public SqlXml AsXml { get { return (SqlXml)Value; } }

        [SqlFacet(IsFixedLength = false, IsNullable = true, MaxSize = -1)]
        public SqlString AsString { get { return (SqlString)Value; } }

        [SqlFacet(IsFixedLength = false, IsNullable = true, MaxSize = -1)]
        public SqlBinary AsBinary { get { return (SqlBinary)Value; } }

        public static BigVariant Null
        {
            get
            {
                BigVariant nullBigVariant = new BigVariant();
                return (nullBigVariant);
            }
        }

        public override string ToString()
        {
            return TypeHelper.ToString(Value);
        }

        public override bool Equals(object obj)
        {
            if (IsNull && (obj == null || obj is INullable && ((INullable)obj).IsNull))
            {
                return true;
            }
            else if (obj is BigVariant)
            {
                var bigVariantObj = (BigVariant)obj;
                return Value.Equals(bigVariantObj.Value);
            }
            else
            {
                return Value.Equals(obj);
            }
        }

        public override int GetHashCode()
        {
            return IsNull
                ? 0
                : Value.GetHashCode();
        }

        public static BigVariant Parse(SqlString value)
        {
            return new BigVariant(value);
        }

        public void Read(BinaryReader r)
        {
            _SqlTypeEnum = (SqlTypeEnum)r.ReadByte();
            _Value = TypeHelper.Read(r);
        }

        public void Write(BinaryWriter w)
        {
            w.Write((byte)SqlTypeEnum);
            TypeHelper.Write(w, Value);
        }

        
    }
}
