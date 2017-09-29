using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class TipoOfertaModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TipoOfertaModel class.
		/// </summary>
		public TipoOfertaModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the TipoOfertaModel class.
		/// </summary>
		public TipoOfertaModel(int IdTactica, short IdPalanca, short Valor, string UsuarioCreacion, DateTime FechaCreacion, string UsuarioModificacion, DateTime FechaModificacion)
		{
			this.IdTactica = IdTactica;
			this.IdPalanca = IdPalanca;
			this.Valor = Valor;
			this.UsuarioCreacion = UsuarioCreacion;
			this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdTactica value. 
		/// </summary>
		public int IdTactica { get; set; }

		/// <summary>
		/// Gets or sets the IdPalanca value. 
		/// </summary>
		public short IdPalanca { get; set; }

		/// <summary>
		/// Gets or sets the Valor value. 
		/// </summary>
		public short Valor { get; set; }

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
