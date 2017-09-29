USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_gl_Campana]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_gl_Campana
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Campana
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_Campana
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_Campana](
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
		SELECT	ROW_NUMBER() OVER(ORDER BY [IdCampana] DESC) AS 'rownumber',
				[IdCampana],
				[UsuarioCreacion],
				[FechaCreacion],
				[UsuarioModificacion],
				[FechaModificacion]
		FROM	[Campana]
			) sq
	WHERE	sq.rownumber >= ( ( @pii_PageIndex - 1 ) * @pii_PageSize ) + 1
	AND		sq.rownumber <= ( @pii_PageSize * @pii_PageIndex );



	----------------------------------------------------------------------------------------------------------
	-- ACTIVIDADES DE LIMPIEZA
	----------------------------------------------------------------------------------------------------------
	SET NOCOUNT OFF
END


GO
