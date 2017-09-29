USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_gl_TipoOferta]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_gl_TipoOferta
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla TipoOferta
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_TipoOferta
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_TipoOferta](
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
		SELECT	ROW_NUMBER() OVER(ORDER BY [IdTactica],[IdPalanca]) AS 'rownumber',
				[IdTactica],
				[IdPalanca],
				[Valor],
				[UsuarioCreacion],
				[FechaCreacion],
				[UsuarioModificacion],
				[FechaModificacion]
		FROM	[TipoOferta]
			) sq
	WHERE	sq.rownumber >= ( ( @pii_PageIndex - 1 ) * @pii_PageSize ) + 1
	AND		sq.rownumber <= ( @pii_PageSize * @pii_PageIndex );

	----------------------------------------------------------------------------------------------------------
	-- ACTIVIDADES DE LIMPIEZA
	----------------------------------------------------------------------------------------------------------
	SET NOCOUNT OFF
END
GO
