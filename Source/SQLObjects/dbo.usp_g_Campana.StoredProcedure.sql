USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_g_Campana]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_g_Campana
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Campana por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Campana
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Campana]
(
    	@IdCampana INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdCampana],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Campana]
    WHERE     [IdCampana] = @IdCampana

END


GO
