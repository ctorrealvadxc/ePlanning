USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_EstadoArchivo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_EstadoArchivo
DESCRIPCIÓN      : Permite insertar un registro en la tabla EstadoArchivo
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_EstadoArchivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_EstadoArchivo]
(
	@IdEstado INT,
	@Descripcion VARCHAR(500),
	@Nemonico VARCHAR(50),
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [EstadoArchivo]
    (
    	[IDESTADO],
    	[DESCRIPCION],
    	[NEMONICO],
    	[USUARIOCREACION],
    	[FECHACREACION]
    )
    VALUES
    (
    	@IdEstado,
    	@Descripcion,
    	@Nemonico,
    	@UsuarioCreacion,
    	GETDATE()
    )

END


GO
