using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class ArchivoModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ArchivoModel class.
		/// </summary>
		public ArchivoModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ArchivoModel class.
		/// </summary>
		public ArchivoModel(string NombreCargado, string NombreHistorico, short IdPalanca, int IdCampanaPlaneacion, int IdCampanaProceso, byte NumeroEspacios, byte UnidadesLimite, int IdEstado, string UsuarioCreacion)
		{
			this.NombreCargado = NombreCargado;
			this.NombreHistorico = NombreHistorico;
            this.IdPalanca = IdPalanca;
            this.IdCampanaPlaneacion = IdCampanaPlaneacion;
            this.IdCampanaProceso = IdCampanaProceso;
            this.NumeroEspacios = NumeroEspacios;
            this.UnidadesLimite = UnidadesLimite;
            this.IdEstado = IdEstado;
			this.UsuarioCreacion = UsuarioCreacion;
		}

		/// <summary>
		/// Initializes a new instance of the ArchivoModel class.
		/// </summary>
		public ArchivoModel(long IdArchivo, string NombreCargado, string NombreHistorico, int IdEstado, string UsuarioModificacion)
		{
			this.IdArchivo = IdArchivo;
			this.NombreCargado = NombreCargado;
			this.NombreHistorico = NombreHistorico;
            this.IdPalanca = IdPalanca;
            this.IdCampanaPlaneacion = IdCampanaPlaneacion;
            this.IdCampanaProceso = IdCampanaProceso;
            this.NumeroEspacios = NumeroEspacios;
            this.UnidadesLimite = UnidadesLimite;
            this.IdEstado = IdEstado;
			this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdArchivo value. 
		/// </summary>
		public long IdArchivo { get; set; }

		/// <summary>
		/// Gets or sets the NombreCargado value. 
		/// </summary>
		public string NombreCargado { get; set; }

		/// <summary>
		/// Gets or sets the NombreHistorico value. 
		/// </summary>
		public string NombreHistorico { get; set; }

        /// <summary>
        /// Gets or sets the IdPalanca value. 
        /// </summary>
        public short IdPalanca { get; set; }

        /// <summary>
        /// Gets or sets the IdCampanaPlaneacion value. 
        /// </summary>
        public int IdCampanaPlaneacion { get; set; }

        /// <summary>
        /// Gets or sets the IdCampanaProceso value. 
        /// </summary>
        public int IdCampanaProceso { get; set; }

        /// <summary>
        /// Gets or sets the NumeroEspacios value. 
        /// </summary>
        public byte NumeroEspacios { get; set; }

        /// <summary>
        /// Gets or sets the UnidadesLimite value. 
        /// </summary>
        public byte UnidadesLimite { get; set; }

        /// <summary>
        /// Gets or sets the IdEstado value. 
        /// </summary>
        public int IdEstado { get; set; }

		/// <summary>
		/// Gets or sets the FechaEstado value. 
		/// </summary>
		public DateTime FechaEstado { get; set; }

		/// <summary>
		/// Gets or sets the UsuarioCreacion value. 
		/// </summary>
		public string UsuarioCreacion { get; set; }

		/// <summary>
		/// Gets or sets the FechaCreacion value. 
		/// </summary>
		public DateTime FechaCreacion { get; set; }

		/// <summary>
		/// Gets or sets the UsuarioModificacion value. 
		/// </summary>
		public string UsuarioModificacion { get; set; }

		/// <summary>
		/// Gets or sets the FechaModificacion value. 
		/// </summary>
		public DateTime FechaModificacion { get; set; }

        /// <summary>
        /// Gets or sets the PageIndex value. 
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the PageSize value. 
        /// </summary>
        public int PageSize { get; set; }

        #endregion
    }
}
