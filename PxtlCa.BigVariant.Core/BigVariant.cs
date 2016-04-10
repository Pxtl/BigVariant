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
    /// <summary>
    /// The SQLCLR BigVariant type
    /// </summary>
    [SqlUserDefinedType(Format.UserDefined, IsFixedLength = false, MaxByteSize = -1)]
    public struct BigVariant : IBinarySerialize, INullable
    {
        public BigVariant(Object value)
        {
            _Value = value;
            _IsNull = (value == null || value is INullable && ((INullable)value).IsNull);
            _SqlTypeEnum = SqlTypeExtensions.GetSqlTypeFromType(value.GetType());
        }
        
        //SQL CLR Type of the BigVariant
        private SqlTypeEnum _SqlTypeEnum;
        internal SqlTypeEnum SqlTypeEnum { get { return _SqlTypeEnum; } }

        internal SqlTypeHelper TypeHelper { get { return SqlTypeExtensions.GetHelper(SqlTypeEnum); } }

        private object _Value;
        internal object Value { get { return _Value; } }

        private bool _IsNull { get; }
        public bool IsNull { get { return _IsNull; } }

        #region public properties
        /// <summary>
        /// The SQL CLR Type of the BigVariant, as a String accessible from SQL.
        /// See https://msdn.microsoft.com/en-us/library/ms131092.aspx for information about the types.
        /// </summary>
        [SqlFacet(IsNullable = false)]
        public string Type { get { return SqlTypeEnum.ToString(); } }

        /// <summary>
        /// If the BigVariant contains a SQL_VARIANT-compatible type, get its contents.
        /// Will throw an exception if the type is not SQL_VARIANT-compatible.
        /// </summary>
        [SqlFacet(IsNullable = true)]
        public object AsVariant { get { return Value; } }

        /// <summary>
        /// If the BigVariant contains XML, get its contents.
        /// Will throw an exception if the type is not XML.
        /// </summary>
        [SqlFacet(IsNullable = true)]
        public SqlXml AsXml { get { return (SqlXml)Value; } }

        /// <summary>
        /// If the BigVariant contains NVARCHAR(MAX) or similar long SqlString object, get its contents.
        /// Will throw an exception if the type is not NVARCHAR(MAX) or similar long SqlString object.
        /// </summary>
        [SqlFacet(IsFixedLength = false, IsNullable = true, MaxSize = -1)]
        public SqlString AsString { get { return (SqlString)Value; } }

        /// <summary>
        /// If the BigVariant contains VARBINARY(MAX) or similar long SqlBinary object, get its contents.
        /// Will throw an exception if the type is not VARBINARY(MAX) or similar long SqlBinary object.
        /// </summary>
        [SqlFacet(IsFixedLength = false, IsNullable = true, MaxSize = -1)]
        public SqlBinary AsBinary { get { return (SqlBinary)Value; } }
        #endregion

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

        //uses underlying equality test from Sql* type
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

        //uses underlying equality test from Sql* type
        public override int GetHashCode()
        {
            return IsNull
                ? 0
                : Value.GetHashCode();
        }

        public static BigVariant Parse([SqlFacet(IsFixedLength = false, IsNullable = true, MaxSize = -1)] SqlString value)
        {
            return new BigVariant(value);
        }

        /// <summary>
        /// Implement IBinarySerialize.Read because SQL stores everything as binary even temporarily
        /// </summary>
        /// <param name="r"></param>
        public void Read(BinaryReader r)
        {
            _SqlTypeEnum = (SqlTypeEnum)r.ReadByte();
            _Value = TypeHelper.Read(r);
        }

        /// <summary>
        /// Implement IBinarySerialize.Write because SQL stores everything as binary even temporarily
        /// </summary>
        public void Write(BinaryWriter w)
        {
            w.Write((byte)SqlTypeEnum);
            TypeHelper.Write(w, Value);
        }

        
    }
}
