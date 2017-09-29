USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_i_ProductoComparableAntiguo]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_i_ProductoComparableAntiguo
DESCRIPCIÓN      : Permite insertar un registro en la tabla ProductoComparableAntiguo
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_ProductoComparableAntiguo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_ProductoComparableAntiguo]
(
	@IdPais TINYINT,
	@CUC VARCHAR(15),
	@SAP VARCHAR(9),
	@CUCAntiguo VARCHAR(15),
	@SAPAntiguo VARCHAR(9),
	@BPCSGenericoAntiguo VARCHAR(9),
	@BPCSTonoAntiguo VARCHAR(9),
	@DescripcionGenericoAntiguo VARCHAR(500),
	@DescripcionTonoAntiguo VARCHAR(500),
	@UsuarioCreacion VARCHAR(100)
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [ProductoComparableAntiguo]
    (
    	[IDPAIS],
    	[CUC],
    	[SAP],
    	[CUCANTIGUO],
    	[SAPANTIGUO],
    	[BPCSGENERICOANTIGUO],
    	[BPCSTONOANTIGUO],
    	[DESCRIPCIONGENERICOANTIGUO],
    	[DESCRIPCIONTONOANTIGUO],
    	[USUARIOCREACION],
    	[FECHACREACION]
    )
    VALUES
    (
    	@IdPais,
    	@CUC,
    	@SAP,
    	@CUCAntiguo,
    	@SAPAntiguo,
    	@BPCSGenericoAntiguo,
    	@BPCSTonoAntiguo,
    	@DescripcionGenericoAntiguo,
    	@DescripcionTonoAntiguo,
    	@UsuarioCreacion,
    	GETDATE()
    )

END


GO
