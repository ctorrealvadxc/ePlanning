USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_u_Pais]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_u_Pais
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Pais
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Pais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Pais]
(
    	@IdPais TINYINT,
    	@Descripcion VARCHAR(500),
    	@Abreviatura VARCHAR(2),
    	@UsuarioModificacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Pais]
    SET     [Descripcion] = @Descripcion,
    	    [Abreviatura] = @Abreviatura,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = GETDATE()
    WHERE    [IdPais] = @IdPais
END


GO
