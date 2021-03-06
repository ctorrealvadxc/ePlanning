USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_gl_Marca]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_gl_Marca
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Marca
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_Marca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_Marca](
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
		SELECT	ROW_NUMBER() OVER(ORDER BY [IdMarca]) AS 'rownumber',
				[IdMarca],
				[Descripcion],
				[Abreviatura],
				[UsuarioCreacion],
				[FechaCreacion],
				[UsuarioModificacion],
				[FechaModificacion]
		FROM	[Marca]
			) sq
	WHERE	sq.rownumber >= ( ( @pii_PageIndex - 1 ) * @pii_PageSize ) + 1
	AND		sq.rownumber <= ( @pii_PageSize * @pii_PageIndex );

	----------------------------------------------------------------------------------------------------------
	-- ACTIVIDADES DE LIMPIEZA
	----------------------------------------------------------------------------------------------------------
	SET NOCOUNT OFF
END


GO
