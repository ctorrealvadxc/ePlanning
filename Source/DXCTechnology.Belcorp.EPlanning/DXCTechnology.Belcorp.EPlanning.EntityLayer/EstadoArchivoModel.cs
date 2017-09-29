using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class EstadoArchivoModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EstadoArchivoModel class.
		/// </summary>
		public EstadoArchivoModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the EstadoArchivoModel class.
		/// </summary>
		public EstadoArchivoModel(int IdEstado, string Descripcion, string UsuarioCreacion, string UsuarioModificacion)
		{
			this.IdEstado = IdEstado;
			this.Descripcion = Descripcion;
			this.UsuarioCreacion = UsuarioCreacion;
			this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdEstado value. 
		/// </summary>
		public int IdEstado { get; set; }

		/// <summary>
		/// Gets or sets the Descripcion value. 
		/// </summary>
		public string Descripcion { get; set; }

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
