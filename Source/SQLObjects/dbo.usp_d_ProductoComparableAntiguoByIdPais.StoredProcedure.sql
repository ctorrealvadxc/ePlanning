USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_d_ProductoComparableAntiguoByIdPais]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_d_ProductoComparableAntiguoByIdPais
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla ProductoComparableAntiguo por su foreign key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ProductoComparableAntiguoByIdPais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ProductoComparableAntiguoByIdPais]
(
    	@IdPais TINYINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [ProductoComparableAntiguo]
    WHERE     [IdPais] = @IdPais

END


GO
