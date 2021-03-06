USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Archivo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Archivo
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Archivo por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Archivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Archivo]
(
	@IdArchivo BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT	[IdArchivo],
    	    [NombreCargado],
    	    [NombreHistorico],
			[IdPalanca],
			[IdCampanaPlaneacion],
			[IdCampanaProceso],
			[NumeroEspacios],
			[UnidadesLimite],
    	    [IdEstado],
    	    [FechaEstado],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Archivo]
    WHERE     [IdArchivo] = @IdArchivo

END


GO
