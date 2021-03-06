USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_d_ProductoComparableAntiguo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_d_ProductoComparableAntiguo
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla ProductoComparableAntiguo por su primary key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_ProductoComparableAntiguo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ProductoComparableAntiguo]
(
    	@IdPais TINYINT,
    	@CUC VARCHAR(15)
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [ProductoComparableAntiguo]
    WHERE    [IdPais] = @IdPais
	  AND [CUC] = @CUC

END


GO
