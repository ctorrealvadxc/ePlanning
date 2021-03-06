USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_gl_Consolidado]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_gl_Consolidado
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Consolidado
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_Consolidado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_Consolidado](
	@pii_PageIndex				int,
	@pii_PageSize				int
)

AS
BEGIN

	----------------------------------------------------------------------------------------------------------
	-- DIRECTIVAS DE CONFIGURACIÓN
	----------------------------------------------------------------------------------------------------------
    SET NOCOUNT ON;

	----------------------------------------------------------------------------------------------------------
	-- DECLARACIÓN DE VARIABLES
	----------------------------------------------------------------------------------------------------------


	----------------------------------------------------------------------------------------------------------
	-- CUERPO DEL PROCECURE
	----------------------------------------------------------------------------------------------------------

    SELECT	sq.*
	FROM	(
		SELECT	ROW_NUMBER() OVER(ORDER BY [IdConsolidado]) AS 'rownumber',
				[IdConsolidado],
    			[IdCampanaPlaneacion],
    			[IdCampanaProceso],
    			[IdPalanca],
    			[UnidadesLimite],
    			[NumeroEspacios],
    			[IdPais],
    			[CuentaOfertas],
    			[Binomio],
    			[CUVPadre],
    			[CUV],
    			[CUCAntiguo],
    			[SAPAntiguo],
    			[BPCSGenericoAntiguo],
    			[BPCSTonoAntiguo],
    			[DescripcionGenericoAntiguo],
    			[DescripcionTonoAntiguo],
    			[Lanzamiento],
    			[CUC],
    			[SAP],
    			[BPCSGenerico],
    			[BPCSTono],
    			[IndicadorGratis],
    			[DescripcionSet],
    			[DescripcionProducto],
    			[DescripcionCatalogo],
    			[CompuestaVariable],
    			[NumeroGrupo],
    			[FactorCuadre],
    			[FlagTop],
    			[Tono],
    			[Marca],
    			[Categoria],
    			[Tipo],
    			[DescuentoSet],
    			[ReglaSet],
    			[GAPMNvsImpreso],
    			[GAPUSDvsImpreso],
    			[IndicadorCxC],
    			[FactoRepeticion],
    			[POUnitarioMN],
    			[POSetMN],
    			[PNSetMN],
    			[PNUnitarioMN],
    			[Unidades],
    			[P1],
    			[P2],
    			[P3],
    			[P4],
    			[P5],
    			[P6],
    			[P7],
    			[Comentario],
    			[CODP],
    			[NumeroProductosOferta],
    			[TipoPlan],
    			[IndicadorSubcampana],
				[CantidadSAPDiferentes],
				[TipoOferta],
    			[UsuarioCreacion],
    			[FechaCreacion],
    			[UsuarioModificacion],
    			[FechaModificacion]
		FROM	[Consolidado]
			) sq
	WHERE	sq.rownumber >= ( ( @pii_PageIndex - 1 ) * @pii_PageSize ) + 1
	AND		sq.rownumber <= ( @pii_PageSize * @pii_PageIndex );


	----------------------------------------------------------------------------------------------------------
	-- ACTIVIDADES DE LIMPIEZA
	----------------------------------------------------------------------------------------------------------
	SET NOCOUNT OFF
END


GO
