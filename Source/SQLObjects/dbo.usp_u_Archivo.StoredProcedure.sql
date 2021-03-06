USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_u_Archivo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_u_Archivo
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Archivo
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Archivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Archivo]
(
    	@IdArchivo BIGINT,
    	@NombreCargado VARCHAR(500),
    	@NombreHistorico VARCHAR(500),
		@IdPalanca SMALLINT,
		@IdCampanaPlaneacion INT,
		@IdCampanaProceso INT,
		@NumeroEspacios TINYINT,
		@UnidadesLimite TINYINT,
    	@UsuarioModificacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE	[Archivo]
    SET     [NombreCargado] = @NombreCargado,
    	    [NombreHistorico] = @NombreHistorico,
			[IdPalanca]=@IdPalanca, 
			[IdCampanaPlaneacion]=@IdCampanaPlaneacion, 
			[IdCampanaProceso]=@IdCampanaProceso, 
			[NumeroEspacios]=@NumeroEspacios, 
			[UnidadesLimite]=@UnidadesLimite, 
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = GETDATE()
    WHERE	[IdArchivo] = @IdArchivo

    SET NOCOUNT ON
END


GO
