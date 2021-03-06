USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_ProductoComparableAntiguo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_ProductoComparableAntiguo
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla ProductoComparableAntiguo por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ProductoComparableAntiguo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ProductoComparableAntiguo]
(
    	@IdPais TINYINT,
    	@CUC VARCHAR(15)
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPais],
    	    [CUC],
    	    [SAP],
    	    [CUCAntiguo],
    	    [SAPAntiguo],
    	    [BPCSGenericoAntiguo],
    	    [BPCSTonoAntiguo],
    	    [DescripcionGenericoAntiguo],
    	    [DescripcionTonoAntiguo],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [ProductoComparableAntiguo]
    WHERE     [IdPais] = @IdPais
    	AND [CUC] = @CUC

END


GO
