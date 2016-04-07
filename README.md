# BigVariant

A Sql-Clr assembly for Microsoft SQL Server 2008+ that creates a CLR UDT that can store everything that goes in a SQL_Variant *and* LOB types like NVARCHAR and XML.
The assembly is restricted to the SAFE functionality of .NET which allows it to be installed easily into your database.

## PxtlCa.pfx

The assembly is signed with a strong name in Release mode, but I (MZ) am keeping my PFX file private.  
As such, you can build the project in Debug mode or generate your own key for signing in Release mode.  
Pull-requests to make the workflow for this problem sane are always welcome.