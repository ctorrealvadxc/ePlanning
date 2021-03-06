USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_gl_ProductoComparableAntiguo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_gl_ProductoComparableAntiguo
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla ProductoComparableAntiguo
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_ProductoComparableAntiguo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_ProductoComparableAntiguo](
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
		SELECT	ROW_NUMBER() OVER(ORDER BY [IdPais],[CUC]) AS 'rownumber',
				[IdPais],
				[CUC],
				[SAP],
				[CUCAntiguo],
				[SAPAntiguo],
				[BPCSGenericoAntiguo],
				[BPCSTonoAntiguo],
				[DescripcionGenericoAntiguo],
				[DescripcionTonoAntiguo],
				[UsuarioCreacion],
				[FechaCreacion],
				[UsuarioModificacion],
				[FechaModificacion]
		FROM	[ProductoComparableAntiguo]
			) sq
	WHERE	sq.rownumber >= ( ( @pii_PageIndex - 1 ) * @pii_PageSize ) + 1
	AND		sq.rownumber <= ( @pii_PageSize * @pii_PageIndex );

	----------------------------------------------------------------------------------------------------------
	-- ACTIVIDADES DE LIMPIEZA
	----------------------------------------------------------------------------------------------------------
	SET NOCOUNT OFF
END
GO
