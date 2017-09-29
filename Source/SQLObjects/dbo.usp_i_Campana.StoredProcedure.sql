USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_Campana]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_Campana
DESCRIPCIÓN      : Permite insertar un registro en la tabla Campana
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Campana
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Campana]
(
	@IdCampana INT,
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Campana]
    (
    	[IdCampana],
    	[UsuarioCreacion],
    	[FechaCreacion]
    )
    VALUES
    (
    	@IdCampana,
    	@UsuarioCreacion,
    	GETDATE()
    )

END


GO
