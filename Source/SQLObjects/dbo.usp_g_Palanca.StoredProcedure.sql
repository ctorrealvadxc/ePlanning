USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Palanca]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Palanca
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Palanca por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Palanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Palanca]
(
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPalanca],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Palanca]
    WHERE     [IdPalanca] = @IdPalanca

END


GO
