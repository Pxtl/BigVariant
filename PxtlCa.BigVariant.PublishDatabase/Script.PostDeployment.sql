/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--SSDT/SQLCLR fails at DateTime2, must recast f'n to use DateTime2.
ALTER FUNCTION [dbo].[BigVariantFromDateTime2](@value [datetime2])
RETURNS [dbo].[BigVariant] WITH EXECUTE AS CALLER
AS 
EXTERNAL NAME [PxtlCa.BigVariant.Core].[PxtlCa.BigVariant.Core.UserDefinedFunctions].[BigVariantFromDateTime2]

GO