using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.SqlServer.Server;

namespace PxtlCa.SqlCollections.Core
{
    public static partial class UserDefinedFunctions
    {
        [SqlFunction]
        public static BigVariant BigVariantFromXml(SqlXml value)
        {
            return new BigVariant(value);
        }

        [SqlFunction]
        public static BigVariant BigVariantFromVariant(Object value)
        {
            return new BigVariant(value);
        }

        [SqlFunction]
        public static BigVariant BigVariantFromString(SqlString value)
        {
            return new BigVariant(value);
        }

        [SqlFunction]
        public static BigVariant BigVariantFromBinary(SqlBinary value)
        {
            return new BigVariant(value);
        }
    }
}
