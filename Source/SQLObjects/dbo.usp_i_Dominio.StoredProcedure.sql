USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_Dominio]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_Dominio
DESCRIPCIÓN      : Permite insertar un registro en la tabla Dominio
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Dominio
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Dominio]
(
	@DescripcionLarga VARCHAR(500),
	@DescripcionCorta VARCHAR(100),
	@IndicadorVigencia BIT,
	@Nemonico VARCHAR(100),
	@CamposAdicionales TINYINT,
	@DescripcionCampo1 VARCHAR(100),
	@DescripcionCampo2 VARCHAR(100),
	@DescripcionCampo3 VARCHAR(100),
	@DescripcionCampo4 VARCHAR(100),
	@DescripcionCampo5 VARCHAR(100),
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Dominio]
    (
    	[DESCRIPCIONLARGA],
    	[DESCRIPCIONCORTA],
    	[INDICADORVIGENCIA],
    	[NEMONICO],
    	[CAMPOSADICIONALES],
    	[DESCRIPCIONCAMPO1],
    	[DESCRIPCIONCAMPO2],
    	[DESCRIPCIONCAMPO3],
    	[DESCRIPCIONCAMPO4],
    	[DESCRIPCIONCAMPO5],
    	[USUARIOCREACION],
    	[FECHACREACION]
    )
    VALUES
    (
    	@DescripcionLarga,
    	@DescripcionCorta,
    	@IndicadorVigencia,
    	@Nemonico,
    	@CamposAdicionales,
    	@DescripcionCampo1,
    	@DescripcionCampo2,
    	@DescripcionCampo3,
    	@DescripcionCampo4,
    	@DescripcionCampo5,
    	@UsuarioCreacion,
    	GETDATE()
    )

    SELECT SCOPE_IDENTITY()

END


GO
