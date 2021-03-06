USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_EstadoArchivo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_EstadoArchivo
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla EstadoArchivo por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_EstadoArchivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_EstadoArchivo]
(
    	@IdEstado INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdEstado],
    	    [Descripcion],
    	    [Nemonico],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [EstadoArchivo]
    WHERE     [IdEstado] = @IdEstado

END


GO
