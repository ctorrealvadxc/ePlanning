USE [EPlanningDB]
GO
use EPlanningDB

/******************************************************************************************
Create the ePlanningUser login.
******************************************************************************************/
if not exists(select * from master..syslogins where name = 'ePlanningUser')
	exec sp_addlogin 'ePlanningUser', '', 'EPlanningDB'
go

/******************************************************************************************
Grant the ePlanningUser login access to the EPlanningDB database.
******************************************************************************************/
if not exists (select * from [dbo].sysusers where name = N'ePlanningUser' and uid < 16382)
	exec sp_grantdbaccess N'ePlanningUser', N'ePlanningUser'
go

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Archivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Archivo]
GO

/******************************************************************************
NOMBRE           : usp_i_Archivo
DESCRIPCIÓN      : Permite insertar un registro en la tabla Archivo
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Archivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Archivo]
(
	@NombreCargado VARCHAR(500),
	@NombreHistorico VARCHAR(500),
	@IdPalanca SMALLINT,
	@IdCampanaPlaneacion INT,
	@IdCampanaProceso INT,
	@NumeroEspacios TINYINT,
	@UnidadesLimite TINYINT,
	@IdEstado INT,
	@FechaEstado DATETIME,
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Archivo]
    (
    	[NOMBRECARGADO],
    	[NOMBREHISTORICO],
    	[IDPALANCA],
    	[IDCAMPANAPLANEACION],
    	[IDCAMPANAPROCESO],
    	[NUMEROESPACIOS],
    	[UNIDADESLIMITE],
    	[IDESTADO],
    	[FECHAESTADO],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@NombreCargado,
    	@NombreHistorico,
    	@IdPalanca,
    	@IdCampanaPlaneacion,
    	@IdCampanaProceso,
    	@NumeroEspacios,
    	@UnidadesLimite,
    	@IdEstado,
    	@FechaEstado,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

    SELECT SCOPE_IDENTITY()

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Archivo] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Archivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Archivo]
GO

/******************************************************************************
NOMBRE           : usp_u_Archivo
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Archivo
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Archivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Archivo]
(
    	@IdArchivo BIGINT,
    	@NombreCargado VARCHAR(500),
    	@NombreHistorico VARCHAR(500),
    	@IdPalanca SMALLINT,
    	@IdCampanaPlaneacion INT,
    	@IdCampanaProceso INT,
    	@NumeroEspacios TINYINT,
    	@UnidadesLimite TINYINT,
    	@IdEstado INT,
    	@FechaEstado DATETIME,
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Archivo]
    SET     [NombreCargado] = @NombreCargado,
    	    [NombreHistorico] = @NombreHistorico,
    	    [IdPalanca] = @IdPalanca,
    	    [IdCampanaPlaneacion] = @IdCampanaPlaneacion,
    	    [IdCampanaProceso] = @IdCampanaProceso,
    	    [NumeroEspacios] = @NumeroEspacios,
    	    [UnidadesLimite] = @UnidadesLimite,
    	    [IdEstado] = @IdEstado,
    	    [FechaEstado] = @FechaEstado,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdArchivo] = @IdArchivo
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Archivo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Archivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Archivo]
GO

/******************************************************************************
NOMBRE           : usp_d_Archivo
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Archivo por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Archivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Archivo]
(
    	@IdArchivo BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Archivo]
    WHERE    [IdArchivo] = @IdArchivo

END

GO

GRANT EXECUTE ON [dbo].[usp_d_Archivo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ArchivoByIdCampanaPlaneacion]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ArchivoByIdCampanaPlaneacion]
GO

/******************************************************************************
NOMBRE           : usp_d_ArchivoByIdCampanaPlaneacion
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Archivo por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ArchivoByIdCampanaPlaneacion
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ArchivoByIdCampanaPlaneacion]
(
    	@IdCampanaPlaneacion INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Archivo]
    WHERE     [IdCampanaPlaneacion] = @IdCampanaPlaneacion

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ArchivoByIdCampanaPlaneacion] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ArchivoByIdCampanaProceso]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ArchivoByIdCampanaProceso]
GO

/******************************************************************************
NOMBRE           : usp_d_ArchivoByIdCampanaProceso
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Archivo por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ArchivoByIdCampanaProceso
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ArchivoByIdCampanaProceso]
(
    	@IdCampanaProceso INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Archivo]
    WHERE     [IdCampanaProceso] = @IdCampanaProceso

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ArchivoByIdCampanaProceso] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ArchivoByIdEstado]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ArchivoByIdEstado]
GO

/******************************************************************************
NOMBRE           : usp_d_ArchivoByIdEstado
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Archivo por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ArchivoByIdEstado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ArchivoByIdEstado]
(
    	@IdEstado INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Archivo]
    WHERE     [IdEstado] = @IdEstado

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ArchivoByIdEstado] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Archivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Archivo]
GO

/******************************************************************************
NOMBRE           : usp_g_Archivo
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Archivo por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Archivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Archivo]
(
    	@IdArchivo BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdArchivo],
    	    [NombreCargado],
    	    [NombreHistorico],
    	    [IdPalanca],
    	    [IdCampanaPlaneacion],
    	    [IdCampanaProceso],
    	    [NumeroEspacios],
    	    [UnidadesLimite],
    	    [IdEstado],
    	    [FechaEstado],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Archivo]
    WHERE     [IdArchivo] = @IdArchivo

END

GO

GRANT EXECUTE ON [dbo].[usp_g_Archivo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_ArchivoSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_ArchivoSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_ArchivoSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Archivo
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_ArchivoSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_ArchivoSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdArchivo],
    	    [NombreCargado],
    	    [NombreHistorico],
    	    [IdPalanca],
    	    [IdCampanaPlaneacion],
    	    [IdCampanaProceso],
    	    [NumeroEspacios],
    	    [UnidadesLimite],
    	    [IdEstado],
    	    [FechaEstado],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Archivo]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_ArchivoSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ArchivoByIdCampanaPlaneacion]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ArchivoByIdCampanaPlaneacion]
GO

/******************************************************************************
NOMBRE           : usp_g_ArchivoByIdCampanaPlaneacion
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Archivo por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ArchivoByIdCampanaPlaneacion
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ArchivoByIdCampanaPlaneacion]
(
    	@IdCampanaPlaneacion INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdArchivo],
	    [NombreCargado],
	    [NombreHistorico],
	    [IdPalanca],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [NumeroEspacios],
	    [UnidadesLimite],
	    [IdEstado],
	    [FechaEstado],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Archivo]
    WHERE     [IdCampanaPlaneacion] = @IdCampanaPlaneacion

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ArchivoByIdCampanaPlaneacion] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ArchivoByIdCampanaProceso]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ArchivoByIdCampanaProceso]
GO

/******************************************************************************
NOMBRE           : usp_g_ArchivoByIdCampanaProceso
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Archivo por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ArchivoByIdCampanaProceso
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ArchivoByIdCampanaProceso]
(
    	@IdCampanaProceso INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdArchivo],
	    [NombreCargado],
	    [NombreHistorico],
	    [IdPalanca],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [NumeroEspacios],
	    [UnidadesLimite],
	    [IdEstado],
	    [FechaEstado],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Archivo]
    WHERE     [IdCampanaProceso] = @IdCampanaProceso

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ArchivoByIdCampanaProceso] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ArchivoByIdEstado]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ArchivoByIdEstado]
GO

/******************************************************************************
NOMBRE           : usp_g_ArchivoByIdEstado
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Archivo por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ArchivoByIdEstado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ArchivoByIdEstado]
(
    	@IdEstado INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdArchivo],
	    [NombreCargado],
	    [NombreHistorico],
	    [IdPalanca],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [NumeroEspacios],
	    [UnidadesLimite],
	    [IdEstado],
	    [FechaEstado],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Archivo]
    WHERE     [IdEstado] = @IdEstado

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ArchivoByIdEstado] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_ArchivoLog]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_ArchivoLog]
GO

/******************************************************************************
NOMBRE           : usp_i_ArchivoLog
DESCRIPCIÓN      : Permite insertar un registro en la tabla ArchivoLog
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_ArchivoLog
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_ArchivoLog]
(
	@IdArchivoLog BIGINT,
	@IdArchivo BIGINT,
	@Observacion VARCHAR(500),
	@Linea NCHAR(10),
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [ArchivoLog]
    (
    	[IDARCHIVOLOG],
    	[IDARCHIVO],
    	[OBSERVACION],
    	[LINEA],
    	[USUARIOCREACION],
    	[FECHACREACION]
    )
    VALUES
    (
    	@IdArchivoLog,
    	@IdArchivo,
    	@Observacion,
    	@Linea,
    	@UsuarioCreacion,
    	@FechaCreacion
    )

END

GO

GRANT EXECUTE ON [dbo].[usp_i_ArchivoLog] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_ArchivoLog]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_ArchivoLog]
GO

/******************************************************************************
NOMBRE           : usp_u_ArchivoLog
DESCRIPCIÓN      : Permite actualizar un registro en la tabla ArchivoLog
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_ArchivoLog
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_ArchivoLog]
(
    	@IdArchivoLog BIGINT,
    	@IdArchivo BIGINT,
    	@Observacion VARCHAR(500),
    	@Linea NCHAR(10),
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [ArchivoLog]
    SET     [Observacion] = @Observacion,
    	    [Linea] = @Linea,
    WHERE    [IdArchivoLog] = @IdArchivoLog    	AND [IdArchivo] = @IdArchivo
END

GO

GRANT EXECUTE ON [dbo].[usp_u_ArchivoLog] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ArchivoLog]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ArchivoLog]
GO

/******************************************************************************
NOMBRE           : usp_d_ArchivoLog
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla ArchivoLog por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_ArchivoLog
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ArchivoLog]
(
    	@IdArchivoLog BIGINT,
    	@IdArchivo BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [ArchivoLog]
    WHERE    [IdArchivoLog] = @IdArchivoLog
	  AND [IdArchivo] = @IdArchivo

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ArchivoLog] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ArchivoLogByIdArchivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ArchivoLogByIdArchivo]
GO

/******************************************************************************
NOMBRE           : usp_d_ArchivoLogByIdArchivo
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla ArchivoLog por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ArchivoLogByIdArchivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ArchivoLogByIdArchivo]
(
    	@IdArchivo BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [ArchivoLog]
    WHERE     [IdArchivo] = @IdArchivo

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ArchivoLogByIdArchivo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ArchivoLog]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ArchivoLog]
GO

/******************************************************************************
NOMBRE           : usp_g_ArchivoLog
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla ArchivoLog por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ArchivoLog
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ArchivoLog]
(
    	@IdArchivoLog BIGINT,
    	@IdArchivo BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdArchivoLog],
    	    [IdArchivo],
    	    [Observacion],
    	    [Linea],
    	    [UsuarioCreacion],
    	    [FechaCreacion]
    FROM [ArchivoLog]
    WHERE     [IdArchivoLog] = @IdArchivoLog
    	AND [IdArchivo] = @IdArchivo

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ArchivoLog] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_ArchivoLogSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_ArchivoLogSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_ArchivoLogSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla ArchivoLog
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_ArchivoLogSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_ArchivoLogSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdArchivoLog],
    	    [IdArchivo],
    	    [Observacion],
    	    [Linea],
    	    [UsuarioCreacion],
    	    [FechaCreacion]
    FROM [ArchivoLog]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_ArchivoLogSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ArchivoLogByIdArchivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ArchivoLogByIdArchivo]
GO

/******************************************************************************
NOMBRE           : usp_g_ArchivoLogByIdArchivo
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla ArchivoLog por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ArchivoLogByIdArchivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ArchivoLogByIdArchivo]
(
    	@IdArchivo BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdArchivoLog],
	    [IdArchivo],
	    [Observacion],
	    [Linea],
	    [UsuarioCreacion],
	    [FechaCreacion]
    FROM [ArchivoLog]
    WHERE     [IdArchivo] = @IdArchivo

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ArchivoLogByIdArchivo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Campana]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Campana]
GO

/******************************************************************************
NOMBRE           : usp_i_Campana
DESCRIPCIÓN      : Permite insertar un registro en la tabla Campana
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Campana
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Campana]
(
	@IdCampana INT,
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Campana]
    (
    	[IDCAMPANA],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@IdCampana,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Campana] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Campana]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Campana]
GO

/******************************************************************************
NOMBRE           : usp_u_Campana
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Campana
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Campana
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Campana]
(
    	@IdCampana INT,
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Campana]
    SET     [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdCampana] = @IdCampana
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Campana] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Campana]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Campana]
GO

/******************************************************************************
NOMBRE           : usp_d_Campana
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Campana por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Campana
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Campana]
(
    	@IdCampana INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Campana]
    WHERE    [IdCampana] = @IdCampana

END

GO

GRANT EXECUTE ON [dbo].[usp_d_Campana] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Campana]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Campana]
GO

/******************************************************************************
NOMBRE           : usp_g_Campana
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Campana por su primary key
FECHA CREACIÓN   : 21/09/2017
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

GRANT EXECUTE ON [dbo].[usp_g_Campana] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_CampanaSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_CampanaSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_CampanaSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Campana
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_CampanaSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_CampanaSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdCampana],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Campana]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_CampanaSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Categoria]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Categoria]
GO

/******************************************************************************
NOMBRE           : usp_i_Categoria
DESCRIPCIÓN      : Permite insertar un registro en la tabla Categoria
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Categoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Categoria]
(
	@Descripcion VARCHAR(500),
	@Abreviatura VARCHAR(2),
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Categoria]
    (
    	[DESCRIPCION],
    	[ABREVIATURA],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@Descripcion,
    	@Abreviatura,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

    SELECT SCOPE_IDENTITY()

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Categoria] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Categoria]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Categoria]
GO

/******************************************************************************
NOMBRE           : usp_u_Categoria
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Categoria
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Categoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Categoria]
(
    	@IdCategoria INT,
    	@Descripcion VARCHAR(500),
    	@Abreviatura VARCHAR(2),
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Categoria]
    SET     [Descripcion] = @Descripcion,
    	    [Abreviatura] = @Abreviatura,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdCategoria] = @IdCategoria
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Categoria] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Categoria]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Categoria]
GO

/******************************************************************************
NOMBRE           : usp_d_Categoria
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Categoria por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Categoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Categoria]
(
    	@IdCategoria INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Categoria]
    WHERE    [IdCategoria] = @IdCategoria

END

GO

GRANT EXECUTE ON [dbo].[usp_d_Categoria] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Categoria]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Categoria]
GO

/******************************************************************************
NOMBRE           : usp_g_Categoria
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Categoria por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Categoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Categoria]
(
    	@IdCategoria INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdCategoria],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Categoria]
    WHERE     [IdCategoria] = @IdCategoria

END

GO

GRANT EXECUTE ON [dbo].[usp_g_Categoria] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_CategoriaSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_CategoriaSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_CategoriaSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Categoria
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_CategoriaSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_CategoriaSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdCategoria],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Categoria]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_CategoriaSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Consolidado]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Consolidado]
GO

/******************************************************************************
NOMBRE           : usp_i_Consolidado
DESCRIPCIÓN      : Permite insertar un registro en la tabla Consolidado
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Consolidado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Consolidado]
(
	@IdCampanaPlaneacion INT,
	@IdCampanaProceso INT,
	@IdPalanca SMALLINT,
	@UnidadesLimite TINYINT,
	@NumeroEspacios TINYINT,
	@IdPais TINYINT,
	@CuentaOfertas INT,
	@Binomio BIT,
	@CUVPadre VARCHAR(10),
	@CUV VARCHAR(10),
	@CUCAntiguo VARCHAR(15),
	@SAPAntiguo VARCHAR(9),
	@BPCSGenericoAntiguo VARCHAR(9),
	@BPCSTonoAntiguo VARCHAR(9),
	@DescripcionGenericoAntiguo VARCHAR(500),
	@DescripcionTonoAntiguo VARCHAR(500),
	@Lanzamiento BIT,
	@CUC VARCHAR(15),
	@SAP VARCHAR(9),
	@BPCSGenerico VARCHAR(9),
	@BPCSTono VARCHAR(9),
	@IndicadorGratis BIT,
	@DescripcionSet VARCHAR(500),
	@DescripcionProducto VARCHAR(500),
	@DescripcionCatalogo VARCHAR(500),
	@CompuestaVariable BIT,
	@NumeroGrupo BIGINT,
	@FactorCuadre BIT,
	@FlagTop BIT,
	@Tono VARCHAR(500),
	@IdMarca INT,
	@IdCategoria INT,
	@Tipo VARCHAR(500),
	@DescuentoSet DECIMAL(8, 5),
	@ReglaSet DECIMAL(8, 5),
	@GAPMNvsImpreso BIGINT,
	@GAPUSDvsImpreso BIGINT,
	@IndicadorCxC BIT,
	@FactoRepeticion BIGINT,
	@POUnitarioMN DECIMAL(21, 3),
	@POSetMN DECIMAL(21, 3),
	@PNSetMN DECIMAL(21, 3),
	@PNUnitarioMN DECIMAL(21, 3),
	@Unidades BIGINT,
	@P1 BIT,
	@P2 BIT,
	@P3 BIT,
	@P4 BIT,
	@P5 BIT,
	@P6 BIT,
	@P7 BIT,
	@Comentario VARCHAR(500),
	@CODP VARCHAR(15),
	@NumeroProductosOferta BIGINT,
	@TipoPlan VARCHAR(100),
	@IndicadorSubcampana BIT,
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Consolidado]
    (
    	[IDCAMPANAPLANEACION],
    	[IDCAMPANAPROCESO],
    	[IDPALANCA],
    	[UNIDADESLIMITE],
    	[NUMEROESPACIOS],
    	[IDPAIS],
    	[CUENTAOFERTAS],
    	[BINOMIO],
    	[CUVPADRE],
    	[CUV],
    	[CUCANTIGUO],
    	[SAPANTIGUO],
    	[BPCSGENERICOANTIGUO],
    	[BPCSTONOANTIGUO],
    	[DESCRIPCIONGENERICOANTIGUO],
    	[DESCRIPCIONTONOANTIGUO],
    	[LANZAMIENTO],
    	[CUC],
    	[SAP],
    	[BPCSGENERICO],
    	[BPCSTONO],
    	[INDICADORGRATIS],
    	[DESCRIPCIONSET],
    	[DESCRIPCIONPRODUCTO],
    	[DESCRIPCIONCATALOGO],
    	[COMPUESTAVARIABLE],
    	[NUMEROGRUPO],
    	[FACTORCUADRE],
    	[FLAGTOP],
    	[TONO],
    	[IDMARCA],
    	[IDCATEGORIA],
    	[TIPO],
    	[DESCUENTOSET],
    	[REGLASET],
    	[GAPMNVSIMPRESO],
    	[GAPUSDVSIMPRESO],
    	[INDICADORCXC],
    	[FACTOREPETICION],
    	[POUNITARIOMN],
    	[POSETMN],
    	[PNSETMN],
    	[PNUNITARIOMN],
    	[UNIDADES],
    	[P1],
    	[P2],
    	[P3],
    	[P4],
    	[P5],
    	[P6],
    	[P7],
    	[COMENTARIO],
    	[CODP],
    	[NUMEROPRODUCTOSOFERTA],
    	[TIPOPLAN],
    	[INDICADORSUBCAMPANA],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@IdCampanaPlaneacion,
    	@IdCampanaProceso,
    	@IdPalanca,
    	@UnidadesLimite,
    	@NumeroEspacios,
    	@IdPais,
    	@CuentaOfertas,
    	@Binomio,
    	@CUVPadre,
    	@CUV,
    	@CUCAntiguo,
    	@SAPAntiguo,
    	@BPCSGenericoAntiguo,
    	@BPCSTonoAntiguo,
    	@DescripcionGenericoAntiguo,
    	@DescripcionTonoAntiguo,
    	@Lanzamiento,
    	@CUC,
    	@SAP,
    	@BPCSGenerico,
    	@BPCSTono,
    	@IndicadorGratis,
    	@DescripcionSet,
    	@DescripcionProducto,
    	@DescripcionCatalogo,
    	@CompuestaVariable,
    	@NumeroGrupo,
    	@FactorCuadre,
    	@FlagTop,
    	@Tono,
    	@IdMarca,
    	@IdCategoria,
    	@Tipo,
    	@DescuentoSet,
    	@ReglaSet,
    	@GAPMNvsImpreso,
    	@GAPUSDvsImpreso,
    	@IndicadorCxC,
    	@FactoRepeticion,
    	@POUnitarioMN,
    	@POSetMN,
    	@PNSetMN,
    	@PNUnitarioMN,
    	@Unidades,
    	@P1,
    	@P2,
    	@P3,
    	@P4,
    	@P5,
    	@P6,
    	@P7,
    	@Comentario,
    	@CODP,
    	@NumeroProductosOferta,
    	@TipoPlan,
    	@IndicadorSubcampana,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

    SELECT SCOPE_IDENTITY()

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Consolidado] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Consolidado]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Consolidado]
GO

/******************************************************************************
NOMBRE           : usp_u_Consolidado
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Consolidado
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Consolidado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Consolidado]
(
    	@IdConsolidado BIGINT,
    	@IdCampanaPlaneacion INT,
    	@IdCampanaProceso INT,
    	@IdPalanca SMALLINT,
    	@UnidadesLimite TINYINT,
    	@NumeroEspacios TINYINT,
    	@IdPais TINYINT,
    	@CuentaOfertas INT,
    	@Binomio BIT,
    	@CUVPadre VARCHAR(10),
    	@CUV VARCHAR(10),
    	@CUCAntiguo VARCHAR(15),
    	@SAPAntiguo VARCHAR(9),
    	@BPCSGenericoAntiguo VARCHAR(9),
    	@BPCSTonoAntiguo VARCHAR(9),
    	@DescripcionGenericoAntiguo VARCHAR(500),
    	@DescripcionTonoAntiguo VARCHAR(500),
    	@Lanzamiento BIT,
    	@CUC VARCHAR(15),
    	@SAP VARCHAR(9),
    	@BPCSGenerico VARCHAR(9),
    	@BPCSTono VARCHAR(9),
    	@IndicadorGratis BIT,
    	@DescripcionSet VARCHAR(500),
    	@DescripcionProducto VARCHAR(500),
    	@DescripcionCatalogo VARCHAR(500),
    	@CompuestaVariable BIT,
    	@NumeroGrupo BIGINT,
    	@FactorCuadre BIT,
    	@FlagTop BIT,
    	@Tono VARCHAR(500),
    	@IdMarca INT,
    	@IdCategoria INT,
    	@Tipo VARCHAR(500),
    	@DescuentoSet DECIMAL(8, 5),
    	@ReglaSet DECIMAL(8, 5),
    	@GAPMNvsImpreso BIGINT,
    	@GAPUSDvsImpreso BIGINT,
    	@IndicadorCxC BIT,
    	@FactoRepeticion BIGINT,
    	@POUnitarioMN DECIMAL(21, 3),
    	@POSetMN DECIMAL(21, 3),
    	@PNSetMN DECIMAL(21, 3),
    	@PNUnitarioMN DECIMAL(21, 3),
    	@Unidades BIGINT,
    	@P1 BIT,
    	@P2 BIT,
    	@P3 BIT,
    	@P4 BIT,
    	@P5 BIT,
    	@P6 BIT,
    	@P7 BIT,
    	@Comentario VARCHAR(500),
    	@CODP VARCHAR(15),
    	@NumeroProductosOferta BIGINT,
    	@TipoPlan VARCHAR(100),
    	@IndicadorSubcampana BIT,
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Consolidado]
    SET     [IdCampanaPlaneacion] = @IdCampanaPlaneacion,
    	    [IdCampanaProceso] = @IdCampanaProceso,
    	    [IdPalanca] = @IdPalanca,
    	    [UnidadesLimite] = @UnidadesLimite,
    	    [NumeroEspacios] = @NumeroEspacios,
    	    [IdPais] = @IdPais,
    	    [CuentaOfertas] = @CuentaOfertas,
    	    [Binomio] = @Binomio,
    	    [CUVPadre] = @CUVPadre,
    	    [CUV] = @CUV,
    	    [CUCAntiguo] = @CUCAntiguo,
    	    [SAPAntiguo] = @SAPAntiguo,
    	    [BPCSGenericoAntiguo] = @BPCSGenericoAntiguo,
    	    [BPCSTonoAntiguo] = @BPCSTonoAntiguo,
    	    [DescripcionGenericoAntiguo] = @DescripcionGenericoAntiguo,
    	    [DescripcionTonoAntiguo] = @DescripcionTonoAntiguo,
    	    [Lanzamiento] = @Lanzamiento,
    	    [CUC] = @CUC,
    	    [SAP] = @SAP,
    	    [BPCSGenerico] = @BPCSGenerico,
    	    [BPCSTono] = @BPCSTono,
    	    [IndicadorGratis] = @IndicadorGratis,
    	    [DescripcionSet] = @DescripcionSet,
    	    [DescripcionProducto] = @DescripcionProducto,
    	    [DescripcionCatalogo] = @DescripcionCatalogo,
    	    [CompuestaVariable] = @CompuestaVariable,
    	    [NumeroGrupo] = @NumeroGrupo,
    	    [FactorCuadre] = @FactorCuadre,
    	    [FlagTop] = @FlagTop,
    	    [Tono] = @Tono,
    	    [IdMarca] = @IdMarca,
    	    [IdCategoria] = @IdCategoria,
    	    [Tipo] = @Tipo,
    	    [DescuentoSet] = @DescuentoSet,
    	    [ReglaSet] = @ReglaSet,
    	    [GAPMNvsImpreso] = @GAPMNvsImpreso,
    	    [GAPUSDvsImpreso] = @GAPUSDvsImpreso,
    	    [IndicadorCxC] = @IndicadorCxC,
    	    [FactoRepeticion] = @FactoRepeticion,
    	    [POUnitarioMN] = @POUnitarioMN,
    	    [POSetMN] = @POSetMN,
    	    [PNSetMN] = @PNSetMN,
    	    [PNUnitarioMN] = @PNUnitarioMN,
    	    [Unidades] = @Unidades,
    	    [P1] = @P1,
    	    [P2] = @P2,
    	    [P3] = @P3,
    	    [P4] = @P4,
    	    [P5] = @P5,
    	    [P6] = @P6,
    	    [P7] = @P7,
    	    [Comentario] = @Comentario,
    	    [CODP] = @CODP,
    	    [NumeroProductosOferta] = @NumeroProductosOferta,
    	    [TipoPlan] = @TipoPlan,
    	    [IndicadorSubcampana] = @IndicadorSubcampana,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdConsolidado] = @IdConsolidado
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Consolidado] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Consolidado]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Consolidado]
GO

/******************************************************************************
NOMBRE           : usp_d_Consolidado
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Consolidado por su primary key
FECHA CREACIÓN   : 21/09/2017
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

GRANT EXECUTE ON [dbo].[usp_d_Consolidado] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ConsolidadoByIdCampanaPlaneacion]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ConsolidadoByIdCampanaPlaneacion]
GO

/******************************************************************************
NOMBRE           : usp_d_ConsolidadoByIdCampanaPlaneacion
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ConsolidadoByIdCampanaPlaneacion
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ConsolidadoByIdCampanaPlaneacion]
(
    	@IdCampanaPlaneacion INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Consolidado]
    WHERE     [IdCampanaPlaneacion] = @IdCampanaPlaneacion

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ConsolidadoByIdCampanaPlaneacion] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ConsolidadoByIdCampanaProceso]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ConsolidadoByIdCampanaProceso]
GO

/******************************************************************************
NOMBRE           : usp_d_ConsolidadoByIdCampanaProceso
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ConsolidadoByIdCampanaProceso
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ConsolidadoByIdCampanaProceso]
(
    	@IdCampanaProceso INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Consolidado]
    WHERE     [IdCampanaProceso] = @IdCampanaProceso

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ConsolidadoByIdCampanaProceso] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ConsolidadoByIdCategoria]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ConsolidadoByIdCategoria]
GO

/******************************************************************************
NOMBRE           : usp_d_ConsolidadoByIdCategoria
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ConsolidadoByIdCategoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ConsolidadoByIdCategoria]
(
    	@IdCategoria INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Consolidado]
    WHERE     [IdCategoria] = @IdCategoria

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ConsolidadoByIdCategoria] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ConsolidadoByIdMarca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ConsolidadoByIdMarca]
GO

/******************************************************************************
NOMBRE           : usp_d_ConsolidadoByIdMarca
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ConsolidadoByIdMarca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ConsolidadoByIdMarca]
(
    	@IdMarca INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Consolidado]
    WHERE     [IdMarca] = @IdMarca

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ConsolidadoByIdMarca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ConsolidadoByIdPais]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ConsolidadoByIdPais]
GO

/******************************************************************************
NOMBRE           : usp_d_ConsolidadoByIdPais
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ConsolidadoByIdPais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ConsolidadoByIdPais]
(
    	@IdPais TINYINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Consolidado]
    WHERE     [IdPais] = @IdPais

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ConsolidadoByIdPais] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ConsolidadoByIdPalanca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ConsolidadoByIdPalanca]
GO

/******************************************************************************
NOMBRE           : usp_d_ConsolidadoByIdPalanca
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ConsolidadoByIdPalanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ConsolidadoByIdPalanca]
(
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Consolidado]
    WHERE     [IdPalanca] = @IdPalanca

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ConsolidadoByIdPalanca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Consolidado]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Consolidado]
GO

/******************************************************************************
NOMBRE           : usp_g_Consolidado
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Consolidado por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Consolidado
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Consolidado]
(
    	@IdConsolidado BIGINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
    	    [IdCampanaPlaneacion],
    	    [IdCampanaProceso],
    	    [IdPalanca],
    	    [UnidadesLimite],
    	    [NumeroEspacios],
    	    [IdPais],
    	    [CuentaOfertas],
    	    [Binomio],
    	    [CUVPadre],
    	    [CUV],
    	    [CUCAntiguo],
    	    [SAPAntiguo],
    	    [BPCSGenericoAntiguo],
    	    [BPCSTonoAntiguo],
    	    [DescripcionGenericoAntiguo],
    	    [DescripcionTonoAntiguo],
    	    [Lanzamiento],
    	    [CUC],
    	    [SAP],
    	    [BPCSGenerico],
    	    [BPCSTono],
    	    [IndicadorGratis],
    	    [DescripcionSet],
    	    [DescripcionProducto],
    	    [DescripcionCatalogo],
    	    [CompuestaVariable],
    	    [NumeroGrupo],
    	    [FactorCuadre],
    	    [FlagTop],
    	    [Tono],
    	    [IdMarca],
    	    [IdCategoria],
    	    [Tipo],
    	    [DescuentoSet],
    	    [ReglaSet],
    	    [GAPMNvsImpreso],
    	    [GAPUSDvsImpreso],
    	    [IndicadorCxC],
    	    [FactoRepeticion],
    	    [POUnitarioMN],
    	    [POSetMN],
    	    [PNSetMN],
    	    [PNUnitarioMN],
    	    [Unidades],
    	    [P1],
    	    [P2],
    	    [P3],
    	    [P4],
    	    [P5],
    	    [P6],
    	    [P7],
    	    [Comentario],
    	    [CODP],
    	    [NumeroProductosOferta],
    	    [TipoPlan],
    	    [IndicadorSubcampana],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Consolidado]
    WHERE     [IdConsolidado] = @IdConsolidado

END

GO

GRANT EXECUTE ON [dbo].[usp_g_Consolidado] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_ConsolidadoSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_ConsolidadoSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_ConsolidadoSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Consolidado
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_ConsolidadoSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_ConsolidadoSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
    	    [IdCampanaPlaneacion],
    	    [IdCampanaProceso],
    	    [IdPalanca],
    	    [UnidadesLimite],
    	    [NumeroEspacios],
    	    [IdPais],
    	    [CuentaOfertas],
    	    [Binomio],
    	    [CUVPadre],
    	    [CUV],
    	    [CUCAntiguo],
    	    [SAPAntiguo],
    	    [BPCSGenericoAntiguo],
    	    [BPCSTonoAntiguo],
    	    [DescripcionGenericoAntiguo],
    	    [DescripcionTonoAntiguo],
    	    [Lanzamiento],
    	    [CUC],
    	    [SAP],
    	    [BPCSGenerico],
    	    [BPCSTono],
    	    [IndicadorGratis],
    	    [DescripcionSet],
    	    [DescripcionProducto],
    	    [DescripcionCatalogo],
    	    [CompuestaVariable],
    	    [NumeroGrupo],
    	    [FactorCuadre],
    	    [FlagTop],
    	    [Tono],
    	    [IdMarca],
    	    [IdCategoria],
    	    [Tipo],
    	    [DescuentoSet],
    	    [ReglaSet],
    	    [GAPMNvsImpreso],
    	    [GAPUSDvsImpreso],
    	    [IndicadorCxC],
    	    [FactoRepeticion],
    	    [POUnitarioMN],
    	    [POSetMN],
    	    [PNSetMN],
    	    [PNUnitarioMN],
    	    [Unidades],
    	    [P1],
    	    [P2],
    	    [P3],
    	    [P4],
    	    [P5],
    	    [P6],
    	    [P7],
    	    [Comentario],
    	    [CODP],
    	    [NumeroProductosOferta],
    	    [TipoPlan],
    	    [IndicadorSubcampana],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Consolidado]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_ConsolidadoSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ConsolidadoByIdCampanaPlaneacion]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ConsolidadoByIdCampanaPlaneacion]
GO

/******************************************************************************
NOMBRE           : usp_g_ConsolidadoByIdCampanaPlaneacion
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ConsolidadoByIdCampanaPlaneacion
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ConsolidadoByIdCampanaPlaneacion]
(
    	@IdCampanaPlaneacion INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [IdPalanca],
	    [UnidadesLimite],
	    [NumeroEspacios],
	    [IdPais],
	    [CuentaOfertas],
	    [Binomio],
	    [CUVPadre],
	    [CUV],
	    [CUCAntiguo],
	    [SAPAntiguo],
	    [BPCSGenericoAntiguo],
	    [BPCSTonoAntiguo],
	    [DescripcionGenericoAntiguo],
	    [DescripcionTonoAntiguo],
	    [Lanzamiento],
	    [CUC],
	    [SAP],
	    [BPCSGenerico],
	    [BPCSTono],
	    [IndicadorGratis],
	    [DescripcionSet],
	    [DescripcionProducto],
	    [DescripcionCatalogo],
	    [CompuestaVariable],
	    [NumeroGrupo],
	    [FactorCuadre],
	    [FlagTop],
	    [Tono],
	    [IdMarca],
	    [IdCategoria],
	    [Tipo],
	    [DescuentoSet],
	    [ReglaSet],
	    [GAPMNvsImpreso],
	    [GAPUSDvsImpreso],
	    [IndicadorCxC],
	    [FactoRepeticion],
	    [POUnitarioMN],
	    [POSetMN],
	    [PNSetMN],
	    [PNUnitarioMN],
	    [Unidades],
	    [P1],
	    [P2],
	    [P3],
	    [P4],
	    [P5],
	    [P6],
	    [P7],
	    [Comentario],
	    [CODP],
	    [NumeroProductosOferta],
	    [TipoPlan],
	    [IndicadorSubcampana],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Consolidado]
    WHERE     [IdCampanaPlaneacion] = @IdCampanaPlaneacion

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ConsolidadoByIdCampanaPlaneacion] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ConsolidadoByIdCampanaProceso]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ConsolidadoByIdCampanaProceso]
GO

/******************************************************************************
NOMBRE           : usp_g_ConsolidadoByIdCampanaProceso
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ConsolidadoByIdCampanaProceso
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ConsolidadoByIdCampanaProceso]
(
    	@IdCampanaProceso INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [IdPalanca],
	    [UnidadesLimite],
	    [NumeroEspacios],
	    [IdPais],
	    [CuentaOfertas],
	    [Binomio],
	    [CUVPadre],
	    [CUV],
	    [CUCAntiguo],
	    [SAPAntiguo],
	    [BPCSGenericoAntiguo],
	    [BPCSTonoAntiguo],
	    [DescripcionGenericoAntiguo],
	    [DescripcionTonoAntiguo],
	    [Lanzamiento],
	    [CUC],
	    [SAP],
	    [BPCSGenerico],
	    [BPCSTono],
	    [IndicadorGratis],
	    [DescripcionSet],
	    [DescripcionProducto],
	    [DescripcionCatalogo],
	    [CompuestaVariable],
	    [NumeroGrupo],
	    [FactorCuadre],
	    [FlagTop],
	    [Tono],
	    [IdMarca],
	    [IdCategoria],
	    [Tipo],
	    [DescuentoSet],
	    [ReglaSet],
	    [GAPMNvsImpreso],
	    [GAPUSDvsImpreso],
	    [IndicadorCxC],
	    [FactoRepeticion],
	    [POUnitarioMN],
	    [POSetMN],
	    [PNSetMN],
	    [PNUnitarioMN],
	    [Unidades],
	    [P1],
	    [P2],
	    [P3],
	    [P4],
	    [P5],
	    [P6],
	    [P7],
	    [Comentario],
	    [CODP],
	    [NumeroProductosOferta],
	    [TipoPlan],
	    [IndicadorSubcampana],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Consolidado]
    WHERE     [IdCampanaProceso] = @IdCampanaProceso

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ConsolidadoByIdCampanaProceso] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ConsolidadoByIdCategoria]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ConsolidadoByIdCategoria]
GO

/******************************************************************************
NOMBRE           : usp_g_ConsolidadoByIdCategoria
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ConsolidadoByIdCategoria
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ConsolidadoByIdCategoria]
(
    	@IdCategoria INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [IdPalanca],
	    [UnidadesLimite],
	    [NumeroEspacios],
	    [IdPais],
	    [CuentaOfertas],
	    [Binomio],
	    [CUVPadre],
	    [CUV],
	    [CUCAntiguo],
	    [SAPAntiguo],
	    [BPCSGenericoAntiguo],
	    [BPCSTonoAntiguo],
	    [DescripcionGenericoAntiguo],
	    [DescripcionTonoAntiguo],
	    [Lanzamiento],
	    [CUC],
	    [SAP],
	    [BPCSGenerico],
	    [BPCSTono],
	    [IndicadorGratis],
	    [DescripcionSet],
	    [DescripcionProducto],
	    [DescripcionCatalogo],
	    [CompuestaVariable],
	    [NumeroGrupo],
	    [FactorCuadre],
	    [FlagTop],
	    [Tono],
	    [IdMarca],
	    [IdCategoria],
	    [Tipo],
	    [DescuentoSet],
	    [ReglaSet],
	    [GAPMNvsImpreso],
	    [GAPUSDvsImpreso],
	    [IndicadorCxC],
	    [FactoRepeticion],
	    [POUnitarioMN],
	    [POSetMN],
	    [PNSetMN],
	    [PNUnitarioMN],
	    [Unidades],
	    [P1],
	    [P2],
	    [P3],
	    [P4],
	    [P5],
	    [P6],
	    [P7],
	    [Comentario],
	    [CODP],
	    [NumeroProductosOferta],
	    [TipoPlan],
	    [IndicadorSubcampana],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Consolidado]
    WHERE     [IdCategoria] = @IdCategoria

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ConsolidadoByIdCategoria] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ConsolidadoByIdMarca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ConsolidadoByIdMarca]
GO

/******************************************************************************
NOMBRE           : usp_g_ConsolidadoByIdMarca
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ConsolidadoByIdMarca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ConsolidadoByIdMarca]
(
    	@IdMarca INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [IdPalanca],
	    [UnidadesLimite],
	    [NumeroEspacios],
	    [IdPais],
	    [CuentaOfertas],
	    [Binomio],
	    [CUVPadre],
	    [CUV],
	    [CUCAntiguo],
	    [SAPAntiguo],
	    [BPCSGenericoAntiguo],
	    [BPCSTonoAntiguo],
	    [DescripcionGenericoAntiguo],
	    [DescripcionTonoAntiguo],
	    [Lanzamiento],
	    [CUC],
	    [SAP],
	    [BPCSGenerico],
	    [BPCSTono],
	    [IndicadorGratis],
	    [DescripcionSet],
	    [DescripcionProducto],
	    [DescripcionCatalogo],
	    [CompuestaVariable],
	    [NumeroGrupo],
	    [FactorCuadre],
	    [FlagTop],
	    [Tono],
	    [IdMarca],
	    [IdCategoria],
	    [Tipo],
	    [DescuentoSet],
	    [ReglaSet],
	    [GAPMNvsImpreso],
	    [GAPUSDvsImpreso],
	    [IndicadorCxC],
	    [FactoRepeticion],
	    [POUnitarioMN],
	    [POSetMN],
	    [PNSetMN],
	    [PNUnitarioMN],
	    [Unidades],
	    [P1],
	    [P2],
	    [P3],
	    [P4],
	    [P5],
	    [P6],
	    [P7],
	    [Comentario],
	    [CODP],
	    [NumeroProductosOferta],
	    [TipoPlan],
	    [IndicadorSubcampana],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Consolidado]
    WHERE     [IdMarca] = @IdMarca

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ConsolidadoByIdMarca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ConsolidadoByIdPais]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ConsolidadoByIdPais]
GO

/******************************************************************************
NOMBRE           : usp_g_ConsolidadoByIdPais
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ConsolidadoByIdPais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ConsolidadoByIdPais]
(
    	@IdPais TINYINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [IdPalanca],
	    [UnidadesLimite],
	    [NumeroEspacios],
	    [IdPais],
	    [CuentaOfertas],
	    [Binomio],
	    [CUVPadre],
	    [CUV],
	    [CUCAntiguo],
	    [SAPAntiguo],
	    [BPCSGenericoAntiguo],
	    [BPCSTonoAntiguo],
	    [DescripcionGenericoAntiguo],
	    [DescripcionTonoAntiguo],
	    [Lanzamiento],
	    [CUC],
	    [SAP],
	    [BPCSGenerico],
	    [BPCSTono],
	    [IndicadorGratis],
	    [DescripcionSet],
	    [DescripcionProducto],
	    [DescripcionCatalogo],
	    [CompuestaVariable],
	    [NumeroGrupo],
	    [FactorCuadre],
	    [FlagTop],
	    [Tono],
	    [IdMarca],
	    [IdCategoria],
	    [Tipo],
	    [DescuentoSet],
	    [ReglaSet],
	    [GAPMNvsImpreso],
	    [GAPUSDvsImpreso],
	    [IndicadorCxC],
	    [FactoRepeticion],
	    [POUnitarioMN],
	    [POSetMN],
	    [PNSetMN],
	    [PNUnitarioMN],
	    [Unidades],
	    [P1],
	    [P2],
	    [P3],
	    [P4],
	    [P5],
	    [P6],
	    [P7],
	    [Comentario],
	    [CODP],
	    [NumeroProductosOferta],
	    [TipoPlan],
	    [IndicadorSubcampana],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Consolidado]
    WHERE     [IdPais] = @IdPais

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ConsolidadoByIdPais] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ConsolidadoByIdPalanca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ConsolidadoByIdPalanca]
GO

/******************************************************************************
NOMBRE           : usp_g_ConsolidadoByIdPalanca
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Consolidado por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ConsolidadoByIdPalanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ConsolidadoByIdPalanca]
(
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdConsolidado],
	    [IdCampanaPlaneacion],
	    [IdCampanaProceso],
	    [IdPalanca],
	    [UnidadesLimite],
	    [NumeroEspacios],
	    [IdPais],
	    [CuentaOfertas],
	    [Binomio],
	    [CUVPadre],
	    [CUV],
	    [CUCAntiguo],
	    [SAPAntiguo],
	    [BPCSGenericoAntiguo],
	    [BPCSTonoAntiguo],
	    [DescripcionGenericoAntiguo],
	    [DescripcionTonoAntiguo],
	    [Lanzamiento],
	    [CUC],
	    [SAP],
	    [BPCSGenerico],
	    [BPCSTono],
	    [IndicadorGratis],
	    [DescripcionSet],
	    [DescripcionProducto],
	    [DescripcionCatalogo],
	    [CompuestaVariable],
	    [NumeroGrupo],
	    [FactorCuadre],
	    [FlagTop],
	    [Tono],
	    [IdMarca],
	    [IdCategoria],
	    [Tipo],
	    [DescuentoSet],
	    [ReglaSet],
	    [GAPMNvsImpreso],
	    [GAPUSDvsImpreso],
	    [IndicadorCxC],
	    [FactoRepeticion],
	    [POUnitarioMN],
	    [POSetMN],
	    [PNSetMN],
	    [PNUnitarioMN],
	    [Unidades],
	    [P1],
	    [P2],
	    [P3],
	    [P4],
	    [P5],
	    [P6],
	    [P7],
	    [Comentario],
	    [CODP],
	    [NumeroProductosOferta],
	    [TipoPlan],
	    [IndicadorSubcampana],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Consolidado]
    WHERE     [IdPalanca] = @IdPalanca

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ConsolidadoByIdPalanca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Dominio]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Dominio]
GO

/******************************************************************************
NOMBRE           : usp_i_Dominio
DESCRIPCIÓN      : Permite insertar un registro en la tabla Dominio
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Dominio
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Dominio]
(
	@DescripcionLarga VARCHAR(500),
	@DescripcionCorta VARCHAR(100),
	@IndicadorVigencia BIT,
	@Nemonico VARCHAR(100),
	@CamposAdicionales TINYINT,
	@DescripcionCampo1 VARCHAR(100),
	@DescripcionCampo2 VARCHAR(100),
	@DescripcionCampo3 VARCHAR(100),
	@DescripcionCampo4 VARCHAR(100),
	@DescripcionCampo5 VARCHAR(100),
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Dominio]
    (
    	[DESCRIPCIONLARGA],
    	[DESCRIPCIONCORTA],
    	[INDICADORVIGENCIA],
    	[NEMONICO],
    	[CAMPOSADICIONALES],
    	[DESCRIPCIONCAMPO1],
    	[DESCRIPCIONCAMPO2],
    	[DESCRIPCIONCAMPO3],
    	[DESCRIPCIONCAMPO4],
    	[DESCRIPCIONCAMPO5],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@DescripcionLarga,
    	@DescripcionCorta,
    	@IndicadorVigencia,
    	@Nemonico,
    	@CamposAdicionales,
    	@DescripcionCampo1,
    	@DescripcionCampo2,
    	@DescripcionCampo3,
    	@DescripcionCampo4,
    	@DescripcionCampo5,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

    SELECT SCOPE_IDENTITY()

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Dominio] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Dominio]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Dominio]
GO

/******************************************************************************
NOMBRE           : usp_u_Dominio
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Dominio
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Dominio
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Dominio]
(
    	@IdDominio INT,
    	@DescripcionLarga VARCHAR(500),
    	@DescripcionCorta VARCHAR(100),
    	@IndicadorVigencia BIT,
    	@Nemonico VARCHAR(100),
    	@CamposAdicionales TINYINT,
    	@DescripcionCampo1 VARCHAR(100),
    	@DescripcionCampo2 VARCHAR(100),
    	@DescripcionCampo3 VARCHAR(100),
    	@DescripcionCampo4 VARCHAR(100),
    	@DescripcionCampo5 VARCHAR(100),
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Dominio]
    SET     [DescripcionLarga] = @DescripcionLarga,
    	    [DescripcionCorta] = @DescripcionCorta,
    	    [IndicadorVigencia] = @IndicadorVigencia,
    	    [Nemonico] = @Nemonico,
    	    [CamposAdicionales] = @CamposAdicionales,
    	    [DescripcionCampo1] = @DescripcionCampo1,
    	    [DescripcionCampo2] = @DescripcionCampo2,
    	    [DescripcionCampo3] = @DescripcionCampo3,
    	    [DescripcionCampo4] = @DescripcionCampo4,
    	    [DescripcionCampo5] = @DescripcionCampo5,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdDominio] = @IdDominio
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Dominio] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Dominio]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Dominio]
GO

/******************************************************************************
NOMBRE           : usp_d_Dominio
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Dominio por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Dominio
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Dominio]
(
    	@IdDominio INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Dominio]
    WHERE    [IdDominio] = @IdDominio

END

GO

GRANT EXECUTE ON [dbo].[usp_d_Dominio] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Dominio]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Dominio]
GO

/******************************************************************************
NOMBRE           : usp_g_Dominio
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Dominio por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Dominio
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Dominio]
(
    	@IdDominio INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdDominio],
    	    [DescripcionLarga],
    	    [DescripcionCorta],
    	    [IndicadorVigencia],
    	    [Nemonico],
    	    [CamposAdicionales],
    	    [DescripcionCampo1],
    	    [DescripcionCampo2],
    	    [DescripcionCampo3],
    	    [DescripcionCampo4],
    	    [DescripcionCampo5],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Dominio]
    WHERE     [IdDominio] = @IdDominio

END

GO

GRANT EXECUTE ON [dbo].[usp_g_Dominio] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_DominioSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_DominioSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_DominioSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Dominio
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_DominioSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_DominioSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdDominio],
    	    [DescripcionLarga],
    	    [DescripcionCorta],
    	    [IndicadorVigencia],
    	    [Nemonico],
    	    [CamposAdicionales],
    	    [DescripcionCampo1],
    	    [DescripcionCampo2],
    	    [DescripcionCampo3],
    	    [DescripcionCampo4],
    	    [DescripcionCampo5],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Dominio]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_DominioSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_EstadoArchivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_EstadoArchivo]
GO

/******************************************************************************
NOMBRE           : usp_i_EstadoArchivo
DESCRIPCIÓN      : Permite insertar un registro en la tabla EstadoArchivo
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_EstadoArchivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_EstadoArchivo]
(
	@IdEstado INT,
	@Descripcion VARCHAR(500),
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [EstadoArchivo]
    (
    	[IDESTADO],
    	[DESCRIPCION],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@IdEstado,
    	@Descripcion,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

END

GO

GRANT EXECUTE ON [dbo].[usp_i_EstadoArchivo] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_EstadoArchivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_EstadoArchivo]
GO

/******************************************************************************
NOMBRE           : usp_u_EstadoArchivo
DESCRIPCIÓN      : Permite actualizar un registro en la tabla EstadoArchivo
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_EstadoArchivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_EstadoArchivo]
(
    	@IdEstado INT,
    	@Descripcion VARCHAR(500),
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [EstadoArchivo]
    SET     [Descripcion] = @Descripcion,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdEstado] = @IdEstado
END

GO

GRANT EXECUTE ON [dbo].[usp_u_EstadoArchivo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_EstadoArchivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_EstadoArchivo]
GO

/******************************************************************************
NOMBRE           : usp_d_EstadoArchivo
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla EstadoArchivo por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_EstadoArchivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_EstadoArchivo]
(
    	@IdEstado INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [EstadoArchivo]
    WHERE    [IdEstado] = @IdEstado

END

GO

GRANT EXECUTE ON [dbo].[usp_d_EstadoArchivo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_EstadoArchivo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_EstadoArchivo]
GO

/******************************************************************************
NOMBRE           : usp_g_EstadoArchivo
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla EstadoArchivo por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_EstadoArchivo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_EstadoArchivo]
(
    	@IdEstado INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdEstado],
    	    [Descripcion],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [EstadoArchivo]
    WHERE     [IdEstado] = @IdEstado

END

GO

GRANT EXECUTE ON [dbo].[usp_g_EstadoArchivo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_EstadoArchivoSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_EstadoArchivoSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_EstadoArchivoSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla EstadoArchivo
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_EstadoArchivoSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_EstadoArchivoSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdEstado],
    	    [Descripcion],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [EstadoArchivo]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_EstadoArchivoSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Marca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Marca]
GO

/******************************************************************************
NOMBRE           : usp_i_Marca
DESCRIPCIÓN      : Permite insertar un registro en la tabla Marca
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Marca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Marca]
(
	@Descripcion VARCHAR(500),
	@Abreviatura VARCHAR(2),
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Marca]
    (
    	[DESCRIPCION],
    	[ABREVIATURA],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@Descripcion,
    	@Abreviatura,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

    SELECT SCOPE_IDENTITY()

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Marca] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Marca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Marca]
GO

/******************************************************************************
NOMBRE           : usp_u_Marca
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Marca
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Marca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Marca]
(
    	@IdMarca INT,
    	@Descripcion VARCHAR(500),
    	@Abreviatura VARCHAR(2),
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Marca]
    SET     [Descripcion] = @Descripcion,
    	    [Abreviatura] = @Abreviatura,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdMarca] = @IdMarca
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Marca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Marca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Marca]
GO

/******************************************************************************
NOMBRE           : usp_d_Marca
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Marca por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Marca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Marca]
(
    	@IdMarca INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Marca]
    WHERE    [IdMarca] = @IdMarca

END

GO

GRANT EXECUTE ON [dbo].[usp_d_Marca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Marca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Marca]
GO

/******************************************************************************
NOMBRE           : usp_g_Marca
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Marca por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Marca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Marca]
(
    	@IdMarca INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdMarca],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Marca]
    WHERE     [IdMarca] = @IdMarca

END

GO

GRANT EXECUTE ON [dbo].[usp_g_Marca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_MarcaSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_MarcaSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_MarcaSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Marca
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_MarcaSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_MarcaSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdMarca],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Marca]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_MarcaSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Pais]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Pais]
GO

/******************************************************************************
NOMBRE           : usp_i_Pais
DESCRIPCIÓN      : Permite insertar un registro en la tabla Pais
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Pais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Pais]
(
	@Descripcion VARCHAR(500),
	@Abreviatura VARCHAR(2),
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Pais]
    (
    	[DESCRIPCION],
    	[ABREVIATURA],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@Descripcion,
    	@Abreviatura,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

    SELECT SCOPE_IDENTITY()

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Pais] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Pais]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Pais]
GO

/******************************************************************************
NOMBRE           : usp_u_Pais
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Pais
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Pais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Pais]
(
    	@IdPais TINYINT,
    	@Descripcion VARCHAR(500),
    	@Abreviatura VARCHAR(2),
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Pais]
    SET     [Descripcion] = @Descripcion,
    	    [Abreviatura] = @Abreviatura,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdPais] = @IdPais
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Pais] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Pais]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Pais]
GO

/******************************************************************************
NOMBRE           : usp_d_Pais
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Pais por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Pais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Pais]
(
    	@IdPais TINYINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Pais]
    WHERE    [IdPais] = @IdPais

END

GO

GRANT EXECUTE ON [dbo].[usp_d_Pais] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Pais]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Pais]
GO

/******************************************************************************
NOMBRE           : usp_g_Pais
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Pais por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Pais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Pais]
(
    	@IdPais TINYINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPais],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Pais]
    WHERE     [IdPais] = @IdPais

END

GO

GRANT EXECUTE ON [dbo].[usp_g_Pais] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_PaisSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_PaisSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_PaisSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Pais
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_PaisSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_PaisSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPais],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Pais]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_PaisSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Palanca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Palanca]
GO

/******************************************************************************
NOMBRE           : usp_i_Palanca
DESCRIPCIÓN      : Permite insertar un registro en la tabla Palanca
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Palanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Palanca]
(
	@Descripcion VARCHAR(300),
	@Abreviatura VARCHAR(5),
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Palanca]
    (
    	[DESCRIPCION],
    	[ABREVIATURA],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@Descripcion,
    	@Abreviatura,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

    SELECT SCOPE_IDENTITY()

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Palanca] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Palanca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Palanca]
GO

/******************************************************************************
NOMBRE           : usp_u_Palanca
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Palanca
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Palanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Palanca]
(
    	@IdPalanca SMALLINT,
    	@Descripcion VARCHAR(300),
    	@Abreviatura VARCHAR(5),
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Palanca]
    SET     [Descripcion] = @Descripcion,
    	    [Abreviatura] = @Abreviatura,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdPalanca] = @IdPalanca
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Palanca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Palanca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Palanca]
GO

/******************************************************************************
NOMBRE           : usp_d_Palanca
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Palanca por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Palanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Palanca]
(
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Palanca]
    WHERE    [IdPalanca] = @IdPalanca

END

GO

GRANT EXECUTE ON [dbo].[usp_d_Palanca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Palanca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Palanca]
GO

/******************************************************************************
NOMBRE           : usp_g_Palanca
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Palanca por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Palanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Palanca]
(
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPalanca],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Palanca]
    WHERE     [IdPalanca] = @IdPalanca

END

GO

GRANT EXECUTE ON [dbo].[usp_g_Palanca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_PalancaSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_PalancaSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_PalancaSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Palanca
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_PalancaSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_PalancaSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPalanca],
    	    [Descripcion],
    	    [Abreviatura],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Palanca]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_PalancaSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_Parametro]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_Parametro]
GO

/******************************************************************************
NOMBRE           : usp_i_Parametro
DESCRIPCIÓN      : Permite insertar un registro en la tabla Parametro
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_Parametro
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_Parametro]
(
	@IdDominio INT,
	@DescripcionLarga VARCHAR(500),
	@DescripcionCorta VARCHAR(100),
	@IndicadorVigencia BIT,
	@Nemonico VARCHAR(100),
	@OrdenPresentacion SMALLINT,
	@ValorCampo1 VARCHAR(100),
	@ValorCampo2 VARCHAR(100),
	@ValorCampo3 VARCHAR(100),
	@ValorCampo4 VARCHAR(100),
	@ValorCampo5 VARCHAR(100),
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [Parametro]
    (
    	[IDDOMINIO],
    	[DESCRIPCIONLARGA],
    	[DESCRIPCIONCORTA],
    	[INDICADORVIGENCIA],
    	[NEMONICO],
    	[ORDENPRESENTACION],
    	[VALORCAMPO1],
    	[VALORCAMPO2],
    	[VALORCAMPO3],
    	[VALORCAMPO4],
    	[VALORCAMPO5],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@IdDominio,
    	@DescripcionLarga,
    	@DescripcionCorta,
    	@IndicadorVigencia,
    	@Nemonico,
    	@OrdenPresentacion,
    	@ValorCampo1,
    	@ValorCampo2,
    	@ValorCampo3,
    	@ValorCampo4,
    	@ValorCampo5,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

    SELECT SCOPE_IDENTITY()

END

GO

GRANT EXECUTE ON [dbo].[usp_i_Parametro] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_Parametro]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_Parametro]
GO

/******************************************************************************
NOMBRE           : usp_u_Parametro
DESCRIPCIÓN      : Permite actualizar un registro en la tabla Parametro
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_Parametro
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_Parametro]
(
    	@IdParametro INT,
    	@IdDominio INT,
    	@DescripcionLarga VARCHAR(500),
    	@DescripcionCorta VARCHAR(100),
    	@IndicadorVigencia BIT,
    	@Nemonico VARCHAR(100),
    	@OrdenPresentacion SMALLINT,
    	@ValorCampo1 VARCHAR(100),
    	@ValorCampo2 VARCHAR(100),
    	@ValorCampo3 VARCHAR(100),
    	@ValorCampo4 VARCHAR(100),
    	@ValorCampo5 VARCHAR(100),
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [Parametro]
    SET     [IdDominio] = @IdDominio,
    	    [DescripcionLarga] = @DescripcionLarga,
    	    [DescripcionCorta] = @DescripcionCorta,
    	    [IndicadorVigencia] = @IndicadorVigencia,
    	    [Nemonico] = @Nemonico,
    	    [OrdenPresentacion] = @OrdenPresentacion,
    	    [ValorCampo1] = @ValorCampo1,
    	    [ValorCampo2] = @ValorCampo2,
    	    [ValorCampo3] = @ValorCampo3,
    	    [ValorCampo4] = @ValorCampo4,
    	    [ValorCampo5] = @ValorCampo5,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdParametro] = @IdParametro
END

GO

GRANT EXECUTE ON [dbo].[usp_u_Parametro] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_Parametro]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_Parametro]
GO

/******************************************************************************
NOMBRE           : usp_d_Parametro
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla Parametro por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_Parametro
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_Parametro]
(
    	@IdParametro INT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [Parametro]
    WHERE    [IdParametro] = @IdParametro

END

GO

GRANT EXECUTE ON [dbo].[usp_d_Parametro] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ParametroByIdDominio]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ParametroByIdDominio]
GO

/******************************************************************************
NOMBRE           : usp_d_ParametroByIdDominio
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla Parametro por su foreign key
FECHA CREACIÓN   : 21/09/2017
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

GRANT EXECUTE ON [dbo].[usp_d_ParametroByIdDominio] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_Parametro]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_Parametro]
GO

/******************************************************************************
NOMBRE           : usp_g_Parametro
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla Parametro por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_Parametro
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_Parametro]
(
    	@IdParametro INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdParametro],
    	    [IdDominio],
    	    [DescripcionLarga],
    	    [DescripcionCorta],
    	    [IndicadorVigencia],
    	    [Nemonico],
    	    [OrdenPresentacion],
    	    [ValorCampo1],
    	    [ValorCampo2],
    	    [ValorCampo3],
    	    [ValorCampo4],
    	    [ValorCampo5],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Parametro]
    WHERE     [IdParametro] = @IdParametro

END

GO

GRANT EXECUTE ON [dbo].[usp_g_Parametro] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_ParametroSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_ParametroSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_ParametroSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Parametro
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_ParametroSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_ParametroSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdParametro],
    	    [IdDominio],
    	    [DescripcionLarga],
    	    [DescripcionCorta],
    	    [IndicadorVigencia],
    	    [Nemonico],
    	    [OrdenPresentacion],
    	    [ValorCampo1],
    	    [ValorCampo2],
    	    [ValorCampo3],
    	    [ValorCampo4],
    	    [ValorCampo5],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [Parametro]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_ParametroSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ParametroByIdDominio]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ParametroByIdDominio]
GO

/******************************************************************************
NOMBRE           : usp_g_ParametroByIdDominio
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla Parametro por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ParametroByIdDominio
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ParametroByIdDominio]
(
    	@IdDominio INT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdParametro],
	    [IdDominio],
	    [DescripcionLarga],
	    [DescripcionCorta],
	    [IndicadorVigencia],
	    [Nemonico],
	    [OrdenPresentacion],
	    [ValorCampo1],
	    [ValorCampo2],
	    [ValorCampo3],
	    [ValorCampo4],
	    [ValorCampo5],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [Parametro]
    WHERE     [IdDominio] = @IdDominio

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ParametroByIdDominio] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_ProductoComparableAntiguo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_ProductoComparableAntiguo]
GO

/******************************************************************************
NOMBRE           : usp_i_ProductoComparableAntiguo
DESCRIPCIÓN      : Permite insertar un registro en la tabla ProductoComparableAntiguo
FECHA CREACIÓN   : 21/09/2017
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
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
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
    	[FECHACREACION],
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
    	@FechaCreacion,
    )

END

GO

GRANT EXECUTE ON [dbo].[usp_i_ProductoComparableAntiguo] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_ProductoComparableAntiguo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_ProductoComparableAntiguo]
GO

/******************************************************************************
NOMBRE           : usp_u_ProductoComparableAntiguo
DESCRIPCIÓN      : Permite actualizar un registro en la tabla ProductoComparableAntiguo
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_u_ProductoComparableAntiguo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_u_ProductoComparableAntiguo]
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
    	@UsuarioModificacion VARCHAR(100),
    	@FechaModificacion DATETIME
)

AS
BEGIN

    SET NOCOUNT ON

    UPDATE [ProductoComparableAntiguo]
    SET     [SAP] = @SAP,
    	    [CUCAntiguo] = @CUCAntiguo,
    	    [SAPAntiguo] = @SAPAntiguo,
    	    [BPCSGenericoAntiguo] = @BPCSGenericoAntiguo,
    	    [BPCSTonoAntiguo] = @BPCSTonoAntiguo,
    	    [DescripcionGenericoAntiguo] = @DescripcionGenericoAntiguo,
    	    [DescripcionTonoAntiguo] = @DescripcionTonoAntiguo,
    	    [UsuarioModificacion] = @UsuarioModificacion,
    	    [FechaModificacion] = @FechaModificacion
    WHERE    [IdPais] = @IdPais    	AND [CUC] = @CUC
END

GO

GRANT EXECUTE ON [dbo].[usp_u_ProductoComparableAntiguo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ProductoComparableAntiguo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ProductoComparableAntiguo]
GO

/******************************************************************************
NOMBRE           : usp_d_ProductoComparableAntiguo
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla ProductoComparableAntiguo por su primary key
FECHA CREACIÓN   : 21/09/2017
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

GRANT EXECUTE ON [dbo].[usp_d_ProductoComparableAntiguo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_ProductoComparableAntiguoByIdPais]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_ProductoComparableAntiguoByIdPais]
GO

/******************************************************************************
NOMBRE           : usp_d_ProductoComparableAntiguoByIdPais
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla ProductoComparableAntiguo por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_ProductoComparableAntiguoByIdPais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_ProductoComparableAntiguoByIdPais]
(
    	@IdPais TINYINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [ProductoComparableAntiguo]
    WHERE     [IdPais] = @IdPais

END

GO

GRANT EXECUTE ON [dbo].[usp_d_ProductoComparableAntiguoByIdPais] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ProductoComparableAntiguo]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ProductoComparableAntiguo]
GO

/******************************************************************************
NOMBRE           : usp_g_ProductoComparableAntiguo
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla ProductoComparableAntiguo por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ProductoComparableAntiguo
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ProductoComparableAntiguo]
(
    	@IdPais TINYINT,
    	@CUC VARCHAR(15)
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPais],
    	    [CUC],
    	    [SAP],
    	    [CUCAntiguo],
    	    [SAPAntiguo],
    	    [BPCSGenericoAntiguo],
    	    [BPCSTonoAntiguo],
    	    [DescripcionGenericoAntiguo],
    	    [DescripcionTonoAntiguo],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [ProductoComparableAntiguo]
    WHERE     [IdPais] = @IdPais
    	AND [CUC] = @CUC

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ProductoComparableAntiguo] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_ProductoComparableAntiguoSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_ProductoComparableAntiguoSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_ProductoComparableAntiguoSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla ProductoComparableAntiguo
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_ProductoComparableAntiguoSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_ProductoComparableAntiguoSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPais],
    	    [CUC],
    	    [SAP],
    	    [CUCAntiguo],
    	    [SAPAntiguo],
    	    [BPCSGenericoAntiguo],
    	    [BPCSTonoAntiguo],
    	    [DescripcionGenericoAntiguo],
    	    [DescripcionTonoAntiguo],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [ProductoComparableAntiguo]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_ProductoComparableAntiguoSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_ProductoComparableAntiguoByIdPais]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_ProductoComparableAntiguoByIdPais]
GO

/******************************************************************************
NOMBRE           : usp_g_ProductoComparableAntiguoByIdPais
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla ProductoComparableAntiguo por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_ProductoComparableAntiguoByIdPais
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_ProductoComparableAntiguoByIdPais]
(
    	@IdPais TINYINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdPais],
	    [CUC],
	    [SAP],
	    [CUCAntiguo],
	    [SAPAntiguo],
	    [BPCSGenericoAntiguo],
	    [BPCSTonoAntiguo],
	    [DescripcionGenericoAntiguo],
	    [DescripcionTonoAntiguo],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [ProductoComparableAntiguo]
    WHERE     [IdPais] = @IdPais

END

GO

GRANT EXECUTE ON [dbo].[usp_g_ProductoComparableAntiguoByIdPais] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[usp_i_TipoOferta]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_i_TipoOferta]
GO

/******************************************************************************
NOMBRE           : usp_i_TipoOferta
DESCRIPCIÓN      : Permite insertar un registro en la tabla TipoOferta
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_i_TipoOferta
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_i_TipoOferta]
(
	@IdTactica INT,
	@IdPalanca SMALLINT,
	@Valor SMALLINT,
	@UsuarioCreacion VARCHAR(100),
	@FechaCreacion DATETIME,
)

AS
BEGIN

    SET NOCOUNT ON

    INSERT INTO [TipoOferta]
    (
    	[IDTACTICA],
    	[IDPALANCA],
    	[VALOR],
    	[USUARIOCREACION],
    	[FECHACREACION],
    )
    VALUES
    (
    	@IdTactica,
    	@IdPalanca,
    	@Valor,
    	@UsuarioCreacion,
    	@FechaCreacion,
    )

END

GO

GRANT EXECUTE ON [dbo].[usp_i_TipoOferta] TO [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_u_TipoOferta]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_u_TipoOferta]
GO

/******************************************************************************
NOMBRE           : usp_u_TipoOferta
DESCRIPCIÓN      : Permite actualizar un registro en la tabla TipoOferta
FECHA CREACIÓN   : 21/09/2017
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

GRANT EXECUTE ON [dbo].[usp_u_TipoOferta] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_TipoOferta]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_TipoOferta]
GO

/******************************************************************************
NOMBRE           : usp_d_TipoOferta
DESCRIPCIÓN      : Permite eliminar de forma permanente un registro en la tabla TipoOferta por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : DXCTechnology 
SINTAXIS         :  
            usp_d_TipoOferta
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_TipoOferta]
(
    	@IdTactica INT,
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [TipoOferta]
    WHERE    [IdTactica] = @IdTactica
	  AND [IdPalanca] = @IdPalanca

END

GO

GRANT EXECUTE ON [dbo].[usp_d_TipoOferta] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_d_TipoOfertaByIdPalanca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_d_TipoOfertaByIdPalanca]
GO

/******************************************************************************
NOMBRE           : usp_d_TipoOfertaByIdPalanca
DESCRIPCIÓN      : Permite eliminar de forma permante un registro en la tabla TipoOferta por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_d_TipoOfertaByIdPalanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_d_TipoOfertaByIdPalanca]
(
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    DELETE FROM [TipoOferta]
    WHERE     [IdPalanca] = @IdPalanca

END

GO

GRANT EXECUTE ON [dbo].[usp_d_TipoOfertaByIdPalanca] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_TipoOferta]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_TipoOferta]
GO

/******************************************************************************
NOMBRE           : usp_g_TipoOferta
DESCRIPCIÓN      : Permite seleccionar un registro de la tabla TipoOferta por su primary key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_TipoOferta
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_TipoOferta]
(
    	@IdTactica INT,
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdTactica],
    	    [IdPalanca],
    	    [Valor],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [TipoOferta]
    WHERE     [IdTactica] = @IdTactica
    	AND [IdPalanca] = @IdPalanca

END

GO

GRANT EXECUTE ON [dbo].[usp_g_TipoOferta] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_gl_TipoOfertaSelectAll]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_gl_TipoOfertaSelectAll]
GO

/******************************************************************************
NOMBRE           : usp_gl_TipoOfertaSelectAll
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla TipoOferta
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_gl_TipoOfertaSelectAll
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_gl_TipoOfertaSelectAll]

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdTactica],
    	    [IdPalanca],
    	    [Valor],
    	    [UsuarioCreacion],
    	    [FechaCreacion],
    	    [UsuarioModificacion],
    	    [FechaModificacion]
    FROM [TipoOferta]

END

GO

GRANT EXECUTE ON [dbo].[usp_gl_TipoOfertaSelectAll] to [ePlanningUser]
GO

/******************************************************************************
******************************************************************************/
IF EXISTS (SELECT * FROM dbo.sysobjects where id = object_id(N'[dbo].[usp_g_TipoOfertaByIdPalanca]') and ObjectProperty(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[usp_g_TipoOfertaByIdPalanca]
GO

/******************************************************************************
NOMBRE           : usp_g_TipoOfertaByIdPalanca
DESCRIPCIÓN      : Permite seleccionar todos los registros de la tabla TipoOferta por su foreign key
FECHA CREACIÓN   : 21/09/2017
CREADOR          : SourceGenerator 
SINTAXIS         :  
            usp_g_TipoOfertaByIdPalanca
******************************************************************************/
CREATE PROCEDURE [dbo].[usp_g_TipoOfertaByIdPalanca]
(
    	@IdPalanca SMALLINT
)

AS
BEGIN

    SET NOCOUNT ON

    SELECT     [IdTactica],
	    [IdPalanca],
	    [Valor],
	    [UsuarioCreacion],
	    [FechaCreacion],
	    [UsuarioModificacion],
	    [FechaModificacion]
    FROM [TipoOferta]
    WHERE     [IdPalanca] = @IdPalanca

END

GO

GRANT EXECUTE ON [dbo].[usp_g_TipoOfertaByIdPalanca] to [ePlanningUser]
GO
