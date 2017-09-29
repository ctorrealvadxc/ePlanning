USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Marca]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Marca
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Marca por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Marca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Marca]
(
    	@IdMarca INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdMarca],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Marca]
    WHERE     [IdMarca] = @IdMarca

END


GO
