using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class PaisModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PaiModel class.
		/// </summary>
		public PaisModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the PaiModel class.
		/// </summary>
		public PaisModel(string Descripcion, string Abreviatura, string UsuarioCreacion)
		{
			this.Descripcion = Descripcion;
			this.Abreviatura = Abreviatura;
			this.UsuarioCreacion = UsuarioCreacion;
		}

		/// <summary>
		/// Initializes a new instance of the PaiModel class.
		/// </summary>
		public PaisModel(byte IdPais, string Descripcion, string Abreviatura, string UsuarioModificacion)
		{
			this.IdPais = IdPais;
			this.Descripcion = Descripcion;
			this.Abreviatura = Abreviatura;
            this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdPais value. 
		/// </summary>
		public byte IdPais { get; set; }

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
