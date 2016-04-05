using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;
using System.Data;

namespace PxtlCa.SqlCollections.Core
{
    public static class SqlTypeExtensions
    {
        public static SqlTypeHelper GetHelper(SqlTypeEnum type) //can't use true extension methods in C# 2.0 //TODO: find out if this is true or use C# 3.5
        {
            switch (type)
            {
                case SqlTypeEnum.SqlNull:
                    return new SqlNullHelper();
                case SqlTypeEnum.SqlBinary:
                    return new SqlBinaryHelper();
                case SqlTypeEnum.SqlBoolean:
                    return new SqlBooleanHelper();
                case SqlTypeEnum.SqlByte:
                    return new SqlByteHelper();
                case SqlTypeEnum.SqlDateTime:
                    return new SqlDateTimeHelper();
                case SqlTypeEnum.SqlDecimal:
                    return new SqlDecimalHelper();
                case SqlTypeEnum.SqlDouble:
                    return new SqlDoubleHelper();
                case SqlTypeEnum.SqlGuid:
                    return new SqlGuidHelper();
                case SqlTypeEnum.SqlInt16:
                    return new SqlInt16Helper();
                case SqlTypeEnum.SqlInt32:
                    return new SqlInt32Helper();
                case SqlTypeEnum.SqlInt64:
                    return new SqlInt64Helper();
                case SqlTypeEnum.SqlMoney:
                    return new SqlMoneyHelper();
                case SqlTypeEnum.SqlSingle:
                    return new SqlSingleHelper();
                case SqlTypeEnum.SqlString:
                    return new SqlStringHelper();
                case SqlTypeEnum.SqlXml:
                    return new SqlXmlHelper();
                default:
                    throw new ArgumentException(
                        $"{nameof(GetHelper)} has no case to handle the {nameof(SqlTypeEnum)} value: " + type.ToString(),
                        nameof(type)
                        );
            }
        }

        public static SqlTypeEnum GetSqlTypeFromType(Type type)
        {
            var typeEnum =
                (type == typeof(SqlBinary)) ? SqlTypeEnum.SqlBinary :
                (type == typeof(SqlBoolean)) ? SqlTypeEnum.SqlBoolean :
                (type == typeof(SqlByte)) ? SqlTypeEnum.SqlByte :
                (type == typeof(SqlDateTime)) ? SqlTypeEnum.SqlDateTime :
                (type == typeof(SqlDecimal)) ? SqlTypeEnum.SqlDecimal :
                (type == typeof(SqlDouble)) ? SqlTypeEnum.SqlDouble :
                (type == typeof(SqlGuid)) ? SqlTypeEnum.SqlGuid :
                (type == typeof(SqlInt16)) ? SqlTypeEnum.SqlInt16 :
                (type == typeof(SqlInt32)) ? SqlTypeEnum.SqlInt32 :
                (type == typeof(SqlInt64)) ? SqlTypeEnum.SqlInt64 :
                (type == typeof(SqlMoney)) ? SqlTypeEnum.SqlMoney :
                (type == typeof(SqlSingle)) ? SqlTypeEnum.SqlSingle :
                (type == typeof(SqlString)) ? SqlTypeEnum.SqlString :
                (type == typeof(SqlXml)) ? SqlTypeEnum.SqlXml :
                SqlTypeEnum.SqlNull;

            if (typeEnum == SqlTypeEnum.SqlNull)
            {
                throw new ArgumentException(
                    $"Not a valid SQL type for BigVariant",
                    nameof(type)
                    );
            }
            return typeEnum;
        }
    }
}
