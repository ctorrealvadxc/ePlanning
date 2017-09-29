using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class CampanaModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CampanaModel class.
		/// </summary>
		public CampanaModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CampanaModel class.
		/// </summary>
		public CampanaModel(int IdCampana, string UsuarioCreacion, string UsuarioModificacion)
		{
			this.IdCampana = IdCampana;
			this.UsuarioCreacion = UsuarioCreacion;
			this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCampana value. 
		/// </summary>
		public int IdCampana { get; set; }

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
