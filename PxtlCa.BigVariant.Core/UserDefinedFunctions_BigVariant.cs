using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.SqlServer.Server;

namespace PxtlCa.BigVariant.Core
{
    public static partial class UserDefinedFunctions
    {
        /// <summary>
        /// Take the given XML typed SQL object and convert it into a BigVariant.
        /// </summary>
        /// <param name="value">an XML object to wrap in a BigVariant</param>
        /// <returns>A BigVariant containing the given XML object</returns>
        [SqlFunction]
        public static BigVariant BigVariantFromXml(SqlXml value)
        {
            return new BigVariant(value);
        }

        /// <summary>
        /// Take the given SQL_VARIANT object and convert it into a BigVariant.
        /// </summary>
        /// <param name="value">a SQL_VARIANT to wrap in a BigVariant</param>
        /// <returns>A BigVariant containing the given SQL_VARIANT</returns>
        [SqlFunction]
        public static BigVariant BigVariantFromVariant(Object value)
        {
            return new BigVariant(value);
        }

        /// <summary>
        /// Take the given NVARCHAR(MAX) or TEXT or NTEXT object and convert it into a BigVariant.
        /// </summary>
        /// <param name="value">an NVARCHAR(MAX) or TEXT or NTEXT to wrap in a BigVariant</param>
        /// <returns>A BigVariant containing the given NVARCHAR(MAX) or TEXT or NTEXT</returns>
        [SqlFunction]
        public static BigVariant BigVariantFromString([SqlFacet(MaxSize = -1)] SqlString value)
        {
            return new BigVariant(value);
        }

        /// <summary>
        /// Take the given VARBINARY(MAX) or IMAGE or other binary object and convert it into a BigVariant.
        /// </summary>
        /// <param name="value">an VARBINARY(MAX) or IMAGE or other binary to wrap in a BigVariant</param>
        /// <returns>A BigVariant containing the given VARBINARY(MAX) or IMAGE or other binary</returns>
        [SqlFunction]
        public static BigVariant BigVariantFromBinary([SqlFacet(MaxSize = -1)] SqlBinary value)
        {
            return new BigVariant(value);
        }
    }
}
