using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.SqlServer.Server;

namespace PxtlCa.BigVariant.Core
{
    /// <summary>
    /// This class collects together various SQL User-Defined-functions used to construct BigVariant values out of various SQL types.
    /// </summary>
    public static partial class UserDefinedFunctions
    {
        /// <summary>
        /// Take the given XML typed SQL object and convert it into a BigVariant.
        /// </summary>
        /// <param name="value">an XML object to wrap in a BigVariant</param>
        /// <returns>A BigVariant containing the given XML object</returns>
        /// <example><![CDATA[
        /// DECLARE @testInput Xml
        /// DECLARE @testVar BigVariant
        /// SET @testInput = convert(Xml       
        /// , '<?xml version="1.0"?><catalog>' + CHAR(13)+CHAR(10) + CHAR(13)+CHAR(10)
        ///	+ '<book id="bk101"><author>Gambardella, Matthew</author><title>XML Developer''s Guide</title><genre>Computer</genre><price>44.95</price><publish_date>2000-10-01</publish_date><description>An in-depth look at creating applications with XML.</description></book>' + CHAR(13)+CHAR(10) + CHAR(13)+CHAR(10)
        ///	+ '</catalog>' + CHAR(13)+CHAR(10) + CHAR(13)+CHAR(10)
        /// )
        /// SET @testVar = dbo.BigVariantFromXml(@testInput)
        /// ]]></example>
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
        /// <example>
        /// DECLARE @testString NVARCHAR(MAX)
        /// DECLARE @testVar BigVariant
        /// DECLARE @actualString NVARCHAR(MAX)
        /// SET @testString = 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus.' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10)
        ///  + 'Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc, quis gravida magna mi a libero. Fusce vulputate eleifend sapien. Vestibulum purus quam, scelerisque ut, mollis sed, nonummy id, metus. Nullam accumsan lorem in dui. Cras ultricies mi eu turpis hendrerit fringilla. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; In ac dui quis mi consectetuer lacinia. Nam pretium turpis et arcu. Duis arcu tortor, suscipit eget, imperdiet nec, imperdiet iaculis, ipsum.' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10)
        ///  + 'Sed aliquam ultrices mauris. Integer ante arcu, accumsan a, consectetuer eget, posuere ut, mauris. Praesent adipiscing. Phasellus ullamcorper ipsum rutrum nunc. Nunc nonummy metus. Vestibulum volutpat pretium libero. Cras id dui. Aenean ut eros et nisl sagittis vestibulum. Nullam nulla eros, ultricies sit amet, nonummy id, imperdiet feugiat, pede. Sed lectus. Donec mollis hendrerit risus. Phasellus nec sem in justo pellentesque facilisis. Etiam imperdiet imperdiet orci. Nunc nec neque. Phasellus leo dolor, tempus non, auctor et, hendrerit quis, nisi. Curabitur ligula sapien, tincidunt non, euismod vitae, posuere imperdiet, leo. Maecenas malesuada. Praesent congue erat at massa. Sed cursus turpis vitae tortor. Donec posuere vulputate arcu. Phasellus accumsan cursus velit.' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10)   
        /// SET @testVar = dbo.BigVariantFromString(@testString)
        /// </example>
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
