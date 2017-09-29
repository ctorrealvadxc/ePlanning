USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_Categoria]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_Categoria
DESCRIPCIÓN      : Permite insertar un registro en la tabla Categoria
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Categoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Categoria]
(
	@Descripcion		VARCHAR(500),
	@Abreviatura		VARCHAR(2),
	@UsuarioCreacion	VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Categoria]
    (
    	[Descripcion],
    	[Abreviatura],
    	[UsuarioCreacion],
    	[FechaCreacion]
    )
    VALUES
    (
    	@Descripcion,
    	@Abreviatura,
    	@UsuarioCreacion,
    	GETDATE()
    );

    SELECT SCOPE_IDENTITY();

END


GO
