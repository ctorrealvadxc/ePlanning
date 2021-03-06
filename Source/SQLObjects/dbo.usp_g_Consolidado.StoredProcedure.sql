USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Consolidado]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Consolidado
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Consolidado por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Consolidado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Consolidado]
(
    	@IdConsolidado BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
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
			[CantidadSAPDiferentes]
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM	[Consolidado]
    WHERE     [IdConsolidado] = @IdConsolidado

END


GO
