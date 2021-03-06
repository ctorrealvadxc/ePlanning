USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Pais]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Pais
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Pais por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Pais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Pais]
(
    	@IdPais TINYINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPais],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Pais]
    WHERE     [IdPais] = @IdPais

END


GO
