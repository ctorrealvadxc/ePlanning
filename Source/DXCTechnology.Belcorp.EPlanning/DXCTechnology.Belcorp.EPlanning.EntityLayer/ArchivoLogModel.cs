using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class ArchivoLogModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ArchivoLogModel class.
		/// </summary>
		public ArchivoLogModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ArchivoLogModel class.
		/// </summary>
		public ArchivoLogModel(long IdArchivo, string Observacion, string Linea, string UsuarioCreacion)
		{
			this.IdArchivo = IdArchivo;
			this.Observacion = Observacion;
			this.Linea = Linea;
			this.UsuarioCreacion = UsuarioCreacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdArchivoLog value. 
		/// </summary>
		public long IdArchivoLog { get; set; }

		/// <summary>
		/// Gets or sets the IdArchivo value. 
		/// </summary>
		public long IdArchivo { get; set; }

		/// <summary>
		/// Gets or sets the Observacion value. 
		/// </summary>
		public string Observacion { get; set; }

		/// <summary>
		/// Gets or sets the Linea value. 
		/// </summary>
		public string Linea { get; set; }

		/// <summary>
		/// Gets or sets the UsuarioCreacion value. 
		/// </summary>
		public string UsuarioCreacion { get; set; }

		/// <summary>
		/// Gets or sets the FechaCreacion value. 
		/// </summary>
		public DateTime FechaCreacion { get; set; }

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
