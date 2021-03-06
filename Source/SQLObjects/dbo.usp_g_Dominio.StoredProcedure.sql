USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Dominio]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Dominio
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Dominio por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Dominio
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Dominio]
(
    	@IdDominio INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdDominio],
    	    [DescripcionLarga],
    	    [DescripcionCorta],
    	    [IndicadorVigencia],
    	    [Nemonico],
    	    [CamposAdicionales],
    	    [DescripcionCampo1],
    	    [DescripcionCampo2],
    	    [DescripcionCampo3],
    	    [DescripcionCampo4],
    	    [DescripcionCampo5],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Dominio]
    WHERE     [IdDominio] = @IdDominio

END


GO
