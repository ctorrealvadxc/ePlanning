USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_u_Categoria]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_u_Categoria
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Categoria
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Categoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Categoria]
(
    	@IdCategoria INT,
    	@Descripcion VARCHAR(500),
    	@Abreviatura VARCHAR(2),
    	@UsuarioModificacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Categoria]
    SET     [Descripcion] = @Descripcion,
    	    [Abreviatura] = @Abreviatura,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = GETDATE()
    WHERE    [IdCategoria] = @IdCategoria;
END


GO
