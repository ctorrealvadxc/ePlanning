USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Categoria]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Categoria
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Categoria por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Categoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Categoria]
(
    	@IdCategoria INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT	[IdCategoria],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM	[Categoria]
    WHERE   [IdCategoria] = @IdCategoria

END


GO
