USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_u_Campana]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_u_Campana
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Campana
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Campana
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Campana]
(
    	@IdCampana INT,
    	@UsuarioModificacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE	[Campana]
    SET		[UsuarioModificacion] = @UsuarioModificacion,
			[FechaModificacion] = GETDATE()
    WHERE	[IdCampana] = @IdCampana
END


GO
