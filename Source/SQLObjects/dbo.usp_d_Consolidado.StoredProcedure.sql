USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_d_Consolidado]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_d_Consolidado
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Consolidado por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Consolidado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Consolidado]
(
    	@IdConsolidado BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Consolidado]
    WHERE    [IdConsolidado] = @IdConsolidado

END


GO
