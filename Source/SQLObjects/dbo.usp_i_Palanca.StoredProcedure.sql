USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_Palanca]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_Palanca
DESCRIPCIÓN      : Permite insertar un registro en la tabla Palanca
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Palanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Palanca]
(
	@Descripcion VARCHAR(300),
	@Abreviatura VARCHAR(5),
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Palanca]
    (
    	[DESCRIPCION],
    	[ABREVIATURA],
    	[USUARIOCREACION],
    	[FECHACREACION]
    )
    VALUES
    (
    	@Descripcion,
    	@Abreviatura,
    	@UsuarioCreacion,
    	GETDATE()
    )

    SELECT SCOPE_IDENTITY()

END


GO
