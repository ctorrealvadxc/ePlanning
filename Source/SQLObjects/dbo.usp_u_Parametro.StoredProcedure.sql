USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_u_Parametro]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_u_Parametro
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Parametro
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Parametro
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Parametro]
(
    	@IdParametro INT,
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
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Parametro]
    SET     [IdDominio] = @IdDominio,
    	    [DescripcionLarga] = @DescripcionLarga,
    	    [DescripcionCorta] = @DescripcionCorta,
    	    [IndicadorVigencia] = @IndicadorVigencia,
    	    [Nemonico] = @Nemonico,
    	    [OrdenPresentacion] = @OrdenPresentacion,
    	    [ValorCampo1] = @ValorCampo1,
    	    [ValorCampo2] = @ValorCampo2,
    	    [ValorCampo3] = @ValorCampo3,
    	    [ValorCampo4] = @ValorCampo4,
    	    [ValorCampo5] = @ValorCampo5,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdParametro] = @IdParametro
END


GO
