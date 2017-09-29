USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_Consolidado]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_Consolidado
DESCRIPCIÓN      : Permite insertar un registro en la tabla Consolidado
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Consolidado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Consolidado]
(
	@IdCampanaPlaneacion INT,
	@IdCampanaProceso INT,
	@IdPalanca SMALLINT,
	@UnidadesLimite TINYINT,
	@NumeroEspacios TINYINT,
	@IdPais TINYINT,
	@CuentaOfertas INT,
	@Binomio BIT,
	@CUVPadre VARCHAR(10),
	@CUV VARCHAR(10),
	@CUCAntiguo VARCHAR(15),
	@SAPAntiguo VARCHAR(9),
	@BPCSGenericoAntiguo VARCHAR(9),
	@BPCSTonoAntiguo VARCHAR(9),
	@DescripcionGenericoAntiguo VARCHAR(500),
	@DescripcionTonoAntiguo VARCHAR(500),
	@Lanzamiento BIT,
	@CUC VARCHAR(15),
	@SAP VARCHAR(9),
	@BPCSGenerico VARCHAR(9),
	@BPCSTono VARCHAR(9),
	@IndicadorGratis BIT,
	@DescripcionSet VARCHAR(500),
	@DescripcionProducto VARCHAR(500),
	@DescripcionCatalogo VARCHAR(500),
	@CompuestaVariable BIT,
	@NumeroGrupo BIGINT,
	@FactorCuadre BIT,
	@FlagTop BIT,
	@Tono VARCHAR(500),
	@Marca VARCHAR(20),
	@Categoria VARCHAR(500),
	@Tipo VARCHAR(500),
	@DescuentoSet DECIMAL(8, 5),
	@ReglaSet DECIMAL(8, 5),
	@GAPMNvsImpreso BIGINT,
	@GAPUSDvsImpreso BIGINT,
	@IndicadorCxC BIT,
	@FactoRepeticion BIGINT,
	@POUnitarioMN DECIMAL(21, 3),
	@POSetMN DECIMAL(21, 3),
	@PNSetMN DECIMAL(21, 3),
	@PNUnitarioMN DECIMAL(21, 3),
	@Unidades BIGINT,
	@P1 BIT,
	@P2 BIT,
	@P3 BIT,
	@P4 BIT,
	@P5 BIT,
	@P6 BIT,
	@P7 BIT,
	@Comentario VARCHAR(500),
	@CODP VARCHAR(15),
	@NumeroProductosOferta BIGINT,
	@TipoPlan VARCHAR(100),
	@IndicadorSubcampana BIT,
	@CantidadSAPDiferentes INT,
	@NumeroRepeticionesSAP INT,
	@TipoOferta SMALLINT,
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Consolidado]
    (
    	[IDCAMPANAPLANEACION],
    	[IDCAMPANAPROCESO],
    	[IDPALANCA],
    	[UNIDADESLIMITE],
    	[NUMEROESPACIOS],
    	[IDPAIS],
    	[CUENTAOFERTAS],
    	[BINOMIO],
    	[CUVPADRE],
    	[CUV],
    	[CUCANTIGUO],
    	[SAPANTIGUO],
    	[BPCSGENERICOANTIGUO],
    	[BPCSTONOANTIGUO],
    	[DESCRIPCIONGENERICOANTIGUO],
    	[DESCRIPCIONTONOANTIGUO],
    	[LANZAMIENTO],
    	[CUC],
    	[SAP],
    	[BPCSGENERICO],
    	[BPCSTONO],
    	[INDICADORGRATIS],
    	[DESCRIPCIONSET],
    	[DESCRIPCIONPRODUCTO],
    	[DESCRIPCIONCATALOGO],
    	[COMPUESTAVARIABLE],
    	[NUMEROGRUPO],
    	[FACTORCUADRE],
    	[FLAGTOP],
    	[TONO],
    	[MARCA],
    	[CATEGORIA],
    	[TIPO],
    	[DESCUENTOSET],
    	[REGLASET],
    	[GAPMNVSIMPRESO],
    	[GAPUSDVSIMPRESO],
    	[INDICADORCXC],
    	[FACTOREPETICION],
    	[POUNITARIOMN],
    	[POSETMN],
    	[PNSETMN],
    	[PNUNITARIOMN],
    	[UNIDADES],
    	[P1],
    	[P2],
    	[P3],
    	[P4],
    	[P5],
    	[P6],
    	[P7],
    	[COMENTARIO],
    	[CODP],
    	[NUMEROPRODUCTOSOFERTA],
    	[TIPOPLAN],
    	[INDICADORSUBCAMPANA],
		[CantidadSAPDiferentes],
		[NumeroRepeticionesSAP],
		[TipoOferta],
    	[USUARIOCREACION],
    	[FECHACREACION]
    )
    VALUES
    (
    	@IdCampanaPlaneacion,
    	@IdCampanaProceso,
    	@IdPalanca,
    	@UnidadesLimite,
    	@NumeroEspacios,
    	@IdPais,
    	@CuentaOfertas,
    	@Binomio,
    	@CUVPadre,
    	@CUV,
    	@CUCAntiguo,
    	@SAPAntiguo,
    	@BPCSGenericoAntiguo,
    	@BPCSTonoAntiguo,
    	@DescripcionGenericoAntiguo,
    	@DescripcionTonoAntiguo,
    	@Lanzamiento,
    	@CUC,
    	@SAP,
    	@BPCSGenerico,
    	@BPCSTono,
    	@IndicadorGratis,
    	@DescripcionSet,
    	@DescripcionProducto,
    	@DescripcionCatalogo,
    	@CompuestaVariable,
    	@NumeroGrupo,
    	@FactorCuadre,
    	@FlagTop,
    	@Tono,
    	@Marca,
    	@Categoria,
    	@Tipo,
    	@DescuentoSet,
    	@ReglaSet,
    	@GAPMNvsImpreso,
    	@GAPUSDvsImpreso,
    	@IndicadorCxC,
    	@FactoRepeticion,
    	@POUnitarioMN,
    	@POSetMN,
    	@PNSetMN,
    	@PNUnitarioMN,
    	@Unidades,
    	@P1,
    	@P2,
    	@P3,
    	@P4,
    	@P5,
    	@P6,
    	@P7,
    	@Comentario,
    	@CODP,
    	@NumeroProductosOferta,
    	@TipoPlan,
    	@IndicadorSubcampana,
		@CantidadSAPDiferentes,
		@NumeroRepeticionesSAP,
		@TipoOferta,
    	@UsuarioCreacion,
    	GETDATE()
    )

    SELECT SCOPE_IDENTITY()

END


GO
