USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_Parametro]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_Parametro
DESCRIPCIÓN      : Permite insertar un registro en la tabla Parametro
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Parametro
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Parametro]
(
	@IdDominio INT,
	@DescripcionLarga VARCHAR(500),
	@DescripcionCorta VARCHAR(100),
	@IndicadorVigencia BIT,
	@Nemonico VARCHAR(100),
	@OrdenPresentacion SMALLINT,
	@ValorCampo1 VARCHAR(100),
	@ValorCampo2 VARCHAR(100),
	@ValorCampo3 VARCHAR(100),
	@ValorCampo4 VARCHAR(100),
	@ValorCampo5 VARCHAR(100),
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Parametro]
    (
    	[IDDOMINIO],
    	[DESCRIPCIONLARGA],
    	[DESCRIPCIONCORTA],
    	[INDICADORVIGENCIA],
    	[NEMONICO],
    	[ORDENPRESENTACION],
    	[VALORCAMPO1],
    	[VALORCAMPO2],
    	[VALORCAMPO3],
    	[VALORCAMPO4],
    	[VALORCAMPO5],
    	[USUARIOCREACION],
    	[FECHACREACION]
    )
    VALUES
    (
    	@IdDominio,
    	@DescripcionLarga,
    	@DescripcionCorta,
    	@IndicadorVigencia,
    	@Nemonico,
    	@OrdenPresentacion,
    	@ValorCampo1,
    	@ValorCampo2,
    	@ValorCampo3,
    	@ValorCampo4,
    	@ValorCampo5,
    	@UsuarioCreacion,
    	GETDATE()
    )

    SELECT SCOPE_IDENTITY()

END


GO
