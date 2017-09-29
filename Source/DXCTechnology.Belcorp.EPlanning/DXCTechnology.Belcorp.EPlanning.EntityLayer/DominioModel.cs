using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class DominioModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DominioModel class.
		/// </summary>
		public DominioModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the DominioModel class.
		/// </summary>
		public DominioModel(string DescripcionLarga, string DescripcionCorta, bool IndicadorVigencia, string Nemonico, byte CamposAdicionales, string DescripcionCampo1, string DescripcionCampo2, string DescripcionCampo3, string DescripcionCampo4, string DescripcionCampo5, string UsuarioCreacion)
		{
			this.DescripcionLarga = DescripcionLarga;
			this.DescripcionCorta = DescripcionCorta;
			this.IndicadorVigencia = IndicadorVigencia;
			this.Nemonico = Nemonico;
			this.CamposAdicionales = CamposAdicionales;
			this.DescripcionCampo1 = DescripcionCampo1;
			this.DescripcionCampo2 = DescripcionCampo2;
			this.DescripcionCampo3 = DescripcionCampo3;
			this.DescripcionCampo4 = DescripcionCampo4;
			this.DescripcionCampo5 = DescripcionCampo5;
			this.UsuarioCreacion = UsuarioCreacion;
		}

		/// <summary>
		/// Initializes a new instance of the DominioModel class.
		/// </summary>
		public DominioModel(int IdDominio, string DescripcionLarga, string DescripcionCorta, bool IndicadorVigencia, string Nemonico, byte CamposAdicionales, string DescripcionCampo1, string DescripcionCampo2, string DescripcionCampo3, string DescripcionCampo4, string DescripcionCampo5, string UsuarioModificacion)
		{
			this.IdDominio = IdDominio;
			this.DescripcionLarga = DescripcionLarga;
			this.DescripcionCorta = DescripcionCorta;
			this.IndicadorVigencia = IndicadorVigencia;
			this.Nemonico = Nemonico;
			this.CamposAdicionales = CamposAdicionales;
			this.DescripcionCampo1 = DescripcionCampo1;
			this.DescripcionCampo2 = DescripcionCampo2;
			this.DescripcionCampo3 = DescripcionCampo3;
			this.DescripcionCampo4 = DescripcionCampo4;
			this.DescripcionCampo5 = DescripcionCampo5;
			this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdDominio value. 
		/// </summary>
		public int IdDominio { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionLarga value. 
		/// </summary>
		public string DescripcionLarga { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionCorta value. 
		/// </summary>
		public string DescripcionCorta { get; set; }

		/// <summary>
		/// Gets or sets the IndicadorVigencia value. 
		/// </summary>
		public bool IndicadorVigencia { get; set; }

		/// <summary>
		/// Gets or sets the Nemonico value. 
		/// </summary>
		public string Nemonico { get; set; }

		/// <summary>
		/// Gets or sets the CamposAdicionales value. 
		/// </summary>
		public byte CamposAdicionales { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionCampo1 value. 
		/// </summary>
		public string DescripcionCampo1 { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionCampo2 value. 
		/// </summary>
		public string DescripcionCampo2 { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionCampo3 value. 
		/// </summary>
		public string DescripcionCampo3 { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionCampo4 value. 
		/// </summary>
		public string DescripcionCampo4 { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionCampo5 value. 
		/// </summary>
		public string DescripcionCampo5 { get; set; }

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
