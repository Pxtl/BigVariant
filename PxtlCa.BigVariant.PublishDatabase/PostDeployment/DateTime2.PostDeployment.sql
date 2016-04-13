--SSDT/SQLCLR fails at DateTime2, must redefine f'n to use DateTime2.
ALTER FUNCTION [dbo].[BigVariantFromDateTime2](@value [datetime2])
RETURNS [dbo].[BigVariant] WITH EXECUTE AS CALLER
AS 
EXTERNAL NAME [PxtlCa.BigVariant.Core].[PxtlCa.BigVariant.Core.UserDefinedFunctions].[BigVariantFromDateTime2]

GO