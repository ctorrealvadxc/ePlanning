USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_d_ParametroByIdDominio]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_d_ParametroByIdDominio
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Parametro por su foreign key
FECHA CREACIÓN   : 19/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ParametroByIdDominio
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ParametroByIdDominio]
(
    	@IdDominio INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Parametro]
    WHERE     [IdDominio] = @IdDominio

END


GO
