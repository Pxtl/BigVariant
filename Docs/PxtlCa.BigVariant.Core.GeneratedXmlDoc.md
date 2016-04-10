## PxtlCa.BigVariant.Core ##

# T:PxtlCa.BigVariant.Core.BigVariant

 The SQLCLR BigVariant type 



---
##### P:PxtlCa.BigVariant.Core.BigVariant.Type

 The SQL CLR Type of the BigVariant, as a String accessible from SQL. See https://msdn.microsoft.com/en-us/library/ms131092.aspx for information about the types. 



---
##### P:PxtlCa.BigVariant.Core.BigVariant.AsVariant

 If the BigVariant contains a SQL_VARIANT-compatible type, get its contents. Will throw an exception if the type is not SQL_VARIANT-compatible. 



---
##### P:PxtlCa.BigVariant.Core.BigVariant.AsXml

 If the BigVariant contains XML, get its contents. Will throw an exception if the type is not XML. 



---
##### P:PxtlCa.BigVariant.Core.BigVariant.AsString

 If the BigVariant contains NVARCHAR(MAX) or similar long SqlString object, get its contents. Will throw an exception if the type is not NVARCHAR(MAX) or similar long SqlString object. 



---
##### P:PxtlCa.BigVariant.Core.BigVariant.AsBinary

 If the BigVariant contains VARBINARY(MAX) or similar long SqlBinary object, get its contents. Will throw an exception if the type is not VARBINARY(MAX) or similar long SqlBinary object. 



---
##### M:PxtlCa.BigVariant.Core.BigVariant.Read(System.IO.BinaryReader)

 Implement IBinarySerialize.Read because SQL stores everything as binary even temporarily 

|Name | Description |
|-----|------|
|r: ||


---
##### M:PxtlCa.BigVariant.Core.BigVariant.Write(System.IO.BinaryWriter)

 Implement IBinarySerialize.Write because SQL stores everything as binary even temporarily 



---
##### M:PxtlCa.BigVariant.Core.UserDefinedFunctions.BigVariantFromXml(System.Data.SqlTypes.SqlXml)

 Take the given XML typed SQL object and convert it into a BigVariant. 

|Name | Description |
|-----|------|
|value: |an XML object to wrap in a BigVariant|
Returns: A BigVariant containing the given XML object



---
##### M:PxtlCa.BigVariant.Core.UserDefinedFunctions.BigVariantFromVariant(System.Object)

 Take the given SQL_VARIANT object and convert it into a BigVariant. 

|Name | Description |
|-----|------|
|value: |a SQL_VARIANT to wrap in a BigVariant|
Returns: A BigVariant containing the given SQL_VARIANT



---
##### M:PxtlCa.BigVariant.Core.UserDefinedFunctions.BigVariantFromString(System.Data.SqlTypes.SqlString)

 Take the given NVARCHAR(MAX) or TEXT or NTEXT object and convert it into a BigVariant. 

|Name | Description |
|-----|------|
|value: |an NVARCHAR(MAX) or TEXT or NTEXT to wrap in a BigVariant|
Returns: A BigVariant containing the given NVARCHAR(MAX) or TEXT or NTEXT



---
##### M:PxtlCa.BigVariant.Core.UserDefinedFunctions.BigVariantFromBinary(System.Data.SqlTypes.SqlBinary)

 Take the given VARBINARY(MAX) or IMAGE or other binary object and convert it into a BigVariant. 

|Name | Description |
|-----|------|
|value: |an VARBINARY(MAX) or IMAGE or other binary to wrap in a BigVariant|
Returns: A BigVariant containing the given VARBINARY(MAX) or IMAGE or other binary



---


