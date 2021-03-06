USE [ePlanningDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_u_TipoOferta]    Script Date: 9/28/2017 11:46:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/******************************************************************************
NOMBRE           : usp_u_TipoOferta
DESCRIPCIÓN      : Permite actualizar un registro en la tabla TipoOferta
FECHA CREACIÓN   : 19/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_TipoOferta
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_TipoOferta]
(
    	@IdTactica INT,
    	@IdPalanca SMALLINT,
    	@Valor SMALLINT,
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [TipoOferta]
    SET     [Valor] = @Valor,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdTactica] = @IdTactica    	AND [IdPalanca] = @IdPalanca
END


GO
