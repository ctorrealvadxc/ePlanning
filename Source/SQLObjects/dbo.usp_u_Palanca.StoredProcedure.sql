USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_u_Palanca]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_u_Palanca
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Palanca
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Palanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Palanca]
(
    	@IdPalanca SMALLINT,
    	@Descripcion VARCHAR(300),
    	@Abreviatura VARCHAR(5),
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Palanca]
    SET     [Descripcion] = @Descripcion,
    	    [Abreviatura] = @Abreviatura,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdPalanca] = @IdPalanca
END


GO
