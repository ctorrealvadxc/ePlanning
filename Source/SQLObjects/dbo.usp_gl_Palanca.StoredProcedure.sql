USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_gl_Palanca]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_gl_Palanca
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Palanca
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_Palanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_Palanca](
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
		SELECT	ROW_NUMBER() OVER(ORDER BY [IdPalanca]) AS 'rownumber',
				[IdPalanca],
				[Descripcion],
				[Abreviatura],
				[UsuarioCreacion],
				[FechaCreacion],
				[UsuarioModificacion],
				[FechaModificacion]
		FROM	[Palanca]
			) sq
	WHERE	sq.rownumber >= ( ( @pii_PageIndex - 1 ) * @pii_PageSize ) + 1
	AND		sq.rownumber <= ( @pii_PageSize * @pii_PageIndex );

	----------------------------------------------------------------------------------------------------------
	-- ACTIVIDADES DE LIMPIEZA
	----------------------------------------------------------------------------------------------------------
	SET NOCOUNT OFF
END
GO
