using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class PalancaModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PalancaModel class.
		/// </summary>
		public PalancaModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the PalancaModel class.
		/// </summary>
		public PalancaModel(string Descripcion, string Abreviatura, string UsuarioCreacion, DateTime FechaCreacion, string UsuarioModificacion, DateTime FechaModificacion)
		{
			this.Descripcion = Descripcion;
			this.Abreviatura = Abreviatura;
			this.UsuarioCreacion = UsuarioCreacion;
		}

		/// <summary>
		/// Initializes a new instance of the PalancaModel class.
		/// </summary>
		public PalancaModel(short IdPalanca, string Descripcion, string Abreviatura, string UsuarioCreacion, DateTime FechaCreacion, string UsuarioModificacion, DateTime FechaModificacion)
		{
			this.IdPalanca = IdPalanca;
			this.Descripcion = Descripcion;
			this.Abreviatura = Abreviatura;
			this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdPalanca value. 
		/// </summary>
		public short IdPalanca { get; set; }

		/// <summary>
		/// Gets or sets the Descripcion value. 
		/// </summary>
		public string Descripcion { get; set; }

		/// <summary>
		/// Gets or sets the Abreviatura value. 
		/// </summary>
		public string Abreviatura { get; set; }

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
