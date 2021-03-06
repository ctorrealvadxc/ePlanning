USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_TipoOferta]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_TipoOferta
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla TipoOferta por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_TipoOferta
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_TipoOferta]
(
    	@IdTactica INT,
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdTactica],
    	    [IdPalanca],
    	    [Valor],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [TipoOferta]
    WHERE     [IdTactica] = @IdTactica
    	AND [IdPalanca] = @IdPalanca

END


GO
