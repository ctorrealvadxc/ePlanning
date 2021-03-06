USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Parametro]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Parametro
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Parametro por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Parametro
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Parametro]
(
    	@IdParametro INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdParametro],
    	    [IdDominio],
    	    [DescripcionLarga],
    	    [DescripcionCorta],
    	    [IndicadorVigencia],
    	    [Nemonico],
    	    [OrdenPresentacion],
    	    [ValorCampo1],
    	    [ValorCampo2],
    	    [ValorCampo3],
    	    [ValorCampo4],
    	    [ValorCampo5],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Parametro]
    WHERE     [IdParametro] = @IdParametro

END


GO
