using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class ParametroModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ParametroModel class.
		/// </summary>
		public ParametroModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ParametroModel class.
		/// </summary>
		public ParametroModel(int IdDominio, string DescripcionLarga, string DescripcionCorta, bool IndicadorVigencia, string Nemonico, short OrdenPresentacion, string ValorCampo1, string ValorCampo2, string ValorCampo3, string ValorCampo4, string ValorCampo5, string UsuarioCreacion, DateTime FechaCreacion, string UsuarioModificacion, DateTime FechaModificacion)
		{
			this.IdDominio = IdDominio;
			this.DescripcionLarga = DescripcionLarga;
			this.DescripcionCorta = DescripcionCorta;
			this.IndicadorVigencia = IndicadorVigencia;
			this.Nemonico = Nemonico;
			this.OrdenPresentacion = OrdenPresentacion;
			this.ValorCampo1 = ValorCampo1;
			this.ValorCampo2 = ValorCampo2;
			this.ValorCampo3 = ValorCampo3;
			this.ValorCampo4 = ValorCampo4;
			this.ValorCampo5 = ValorCampo5;
			this.UsuarioCreacion = UsuarioCreacion;
		}

		/// <summary>
		/// Initializes a new instance of the ParametroModel class.
		/// </summary>
		public ParametroModel(int IdParametro, int IdDominio, string DescripcionLarga, string DescripcionCorta, bool IndicadorVigencia, string Nemonico, short OrdenPresentacion, string ValorCampo1, string ValorCampo2, string ValorCampo3, string ValorCampo4, string ValorCampo5, string UsuarioCreacion, DateTime FechaCreacion, string UsuarioModificacion, DateTime FechaModificacion)
		{
			this.IdParametro = IdParametro;
			this.IdDominio = IdDominio;
			this.DescripcionLarga = DescripcionLarga;
			this.DescripcionCorta = DescripcionCorta;
			this.IndicadorVigencia = IndicadorVigencia;
			this.Nemonico = Nemonico;
			this.OrdenPresentacion = OrdenPresentacion;
			this.ValorCampo1 = ValorCampo1;
			this.ValorCampo2 = ValorCampo2;
			this.ValorCampo3 = ValorCampo3;
			this.ValorCampo4 = ValorCampo4;
			this.ValorCampo5 = ValorCampo5;
			this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdParametro value. 
		/// </summary>
		public int IdParametro { get; set; }

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
		/// Gets or sets the OrdenPresentacion value. 
		/// </summary>
		public short OrdenPresentacion { get; set; }

		/// <summary>
		/// Gets or sets the ValorCampo1 value. 
		/// </summary>
		public string ValorCampo1 { get; set; }

		/// <summary>
		/// Gets or sets the ValorCampo2 value. 
		/// </summary>
		public string ValorCampo2 { get; set; }

		/// <summary>
		/// Gets or sets the ValorCampo3 value. 
		/// </summary>
		public string ValorCampo3 { get; set; }

		/// <summary>
		/// Gets or sets the ValorCampo4 value. 
		/// </summary>
		public string ValorCampo4 { get; set; }

		/// <summary>
		/// Gets or sets the ValorCampo5 value. 
		/// </summary>
		public string ValorCampo5 { get; set; }

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
