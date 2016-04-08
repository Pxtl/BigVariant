# BigVariant

A Sql-Clr assembly for Microsoft SQL Server 2008+ that creates a CLR UDT that can store everything that goes in a SQL_Variant *and* LOB types like NVARCHAR and XML.
The assembly is restricted to the SAFE functionality of .NET which allows it to be installed easily into your database.

# Installation

## Enabling SQLCLR
If you haven't done so already, the first step in using SQLCLR is enabling it on your database.  It is disabled by default.

On your Microsoft SQL Server database, execute the following:

```
sp_configure 'show advanced options', 1;
GO
RECONFIGURE;
GO
sp_configure 'clr enabled', 1;
GO
RECONFIGURE;
GO
```

Now you are ready to start using SQLCLR assemblies.

## Installing into an existing SSDT project

The file is a SQLCLR SAFE-compatible assembly.  It can be loaded into your database using SSDT.

Create an empty C# library project in Visual Studio, and then add the BigVariant nuget package as a dependency.  
This will give you a nuget binding for the file even though SSDT does not support nuget.

Build.  This will make nuget fetch your assembly.

Next, use the References folder in your SSDT project.  
Add a the reference to both your dummy-library and to the PxtlCa.BigVariant.Core file that is now present in your packages folder thanks to nuget.

Right-click the added assembly and click "properties".  In the properties tab, set the following options to **true**:
- Generate SQL Script = **true**
- Is Visible = **true**
- Model Aware = **true**

## Installing from SSDT when you do not use SSDT to manage your database

Pull the project from http://github.com/Pxtl/BigVariant and open BigVariant.sln.

Right-click PxtlCa.BigVariant.PublishDatabase and select **publish**.

Configure the publisher to connect to your database and click **publish**.

## Installing via DACPAC or SQL scripts

SQL scripts and DACPACs for publishing have not been set up as part of the standard build-process yet.

# On PxtlCa.pfx

The assembly is signed with a strong name in Release mode, but I (MZ) am keeping my PFX file private.  
As such, you can build the project in Debug mode or generate your own key for signing in Release mode.  
Pull-requests to make the workflow for this problem sane are always welcome.