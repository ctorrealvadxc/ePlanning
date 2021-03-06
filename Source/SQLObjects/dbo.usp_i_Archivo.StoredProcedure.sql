USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_Archivo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_Archivo
DESCRIPCIÓN      : Permite insertar un registro en la tabla Archivo
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Archivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Archivo]
(
	@NombreCargado VARCHAR(500),
	@NombreHistorico VARCHAR(500),
	@IdPalanca SMALLINT,
	@IdCampanaPlaneacion INT,
	@IdCampanaProceso INT,
	@NumeroEspacios TINYINT,
	@UnidadesLimite TINYINT,
	@IdEstado INT,
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Archivo]
    (
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
		[FechaCreacion]
    )
    VALUES
    (
    	@NombreCargado,
    	@NombreHistorico,
		@IdPalanca, 
		@IdCampanaPlaneacion, 
		@IdCampanaProceso, 
		@NumeroEspacios, 
		@UnidadesLimite,
    	@IdEstado,
    	GETDATE(),
    	@UsuarioCreacion,
    	GETDATE()
    )

    SELECT SCOPE_IDENTITY()

END


GO
