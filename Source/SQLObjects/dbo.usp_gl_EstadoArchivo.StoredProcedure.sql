USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_gl_EstadoArchivo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_gl_EstadoArchivoSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla EstadoArchivo
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_EstadoArchivoSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_EstadoArchivo]

AS
BEGIN

    SET NOCOUNT ON

    SELECT	[IdEstado],
			[Descripcion],
			[Nemonico],
			[UsuarioCreacion],
			[FechaCreacion],
			[UsuarioModificacion],
			[FechaModificacion]
    FROM [EstadoArchivo]

END


GO
