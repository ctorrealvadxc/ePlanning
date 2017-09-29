USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_TipoOferta]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_TipoOferta
DESCRIPCIÓN      : Permite insertar un registro en la tabla TipoOferta
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_TipoOferta
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_TipoOferta]
(
	@IdTactica INT,
	@IdPalanca SMALLINT,
	@Valor SMALLINT,
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [TipoOferta]
    (
    	[IDTACTICA],
    	[IDPALANCA],
    	[VALOR],
    	[USUARIOCREACION],
    	[FECHACREACION]
    )
    VALUES
    (
    	@IdTactica,
    	@IdPalanca,
    	@Valor,
    	@UsuarioCreacion,
    	GETDATE()
    )

END


GO
