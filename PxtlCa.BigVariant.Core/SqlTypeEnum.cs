using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.IO;
using System.Xml;

namespace PxtlCa.SqlCollections.Core
{
    public enum SqlTypeEnum
    {
        //TODO: SQLCLR built-ins
        SqlNull = 0,
        SqlBinary,
        SqlBoolean,
        SqlByte,
        SqlDateTime,
        SqlDecimal,
        SqlDouble,
        SqlGuid,
        SqlInt16,
        SqlInt32,
        SqlInt64,
        SqlMoney,
        SqlSingle,
        SqlString,
        SqlXml
    }
}
