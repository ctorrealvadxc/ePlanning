using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class ConsolidadoModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ConsolidadoModel class.
		/// </summary>
		public ConsolidadoModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ConsolidadoModel class.
		/// </summary>
		public ConsolidadoModel(int IdCampanaPlaneacion, int IdCampanaProceso, short IdPalanca, byte UnidadesLimite, byte NumeroEspacios, byte IdPais, int CuentaOfertas, bool Binomio, string CUVPadre, string CUV, string CUCAntiguo, string SAPAntiguo, string BPCSGenericoAntiguo, string BPCSTonoAntiguo, string DescripcionGenericoAntiguo, string DescripcionTonoAntiguo, bool Lanzamiento, string CUC, string SAP, string BPCSGenerico, string BPCSTono, bool IndicadorGratis, string DescripcionSet, string DescripcionProducto, string DescripcionCatalogo, bool CompuestaVariable, long NumeroGrupo, bool FactorCuadre, bool FlagTop, string Tono, string Marca, string Categoria, string Tipo, decimal DescuentoSet, decimal ReglaSet, long GAPMNvsImpreso, long GAPUSDvsImpreso, bool IndicadorCxC, long FactoRepeticion, decimal POUnitarioMN, decimal POSetMN, decimal PNSetMN, decimal PNUnitarioMN, long Unidades, bool P1, bool P2, bool P3, bool P4, bool P5, bool P6, bool P7, string Comentario, string CODP, long NumeroProductosOferta, string TipoPlan, bool IndicadorSubcampana, int CantidadSAPDiferentes, string UsuarioCreacion)
		{
			this.IdCampanaPlaneacion = IdCampanaPlaneacion;
			this.IdCampanaProceso = IdCampanaProceso;
			this.IdPalanca = IdPalanca;
			this.UnidadesLimite = UnidadesLimite;
			this.NumeroEspacios = NumeroEspacios;
			this.IdPais = IdPais;
			this.CuentaOfertas = CuentaOfertas;
			this.Binomio = Binomio;
			this.CUVPadre = CUVPadre;
			this.CUV = CUV;
			this.CUCAntiguo = CUCAntiguo;
			this.SAPAntiguo = SAPAntiguo;
			this.BPCSGenericoAntiguo = BPCSGenericoAntiguo;
			this.BPCSTonoAntiguo = BPCSTonoAntiguo;
			this.DescripcionGenericoAntiguo = DescripcionGenericoAntiguo;
			this.DescripcionTonoAntiguo = DescripcionTonoAntiguo;
			this.Lanzamiento = Lanzamiento;
			this.CUC = CUC;
			this.SAP = SAP;
			this.BPCSGenerico = BPCSGenerico;
			this.BPCSTono = BPCSTono;
			this.IndicadorGratis = IndicadorGratis;
			this.DescripcionSet = DescripcionSet;
			this.DescripcionProducto = DescripcionProducto;
			this.DescripcionCatalogo = DescripcionCatalogo;
			this.CompuestaVariable = CompuestaVariable;
			this.NumeroGrupo = NumeroGrupo;
			this.FactorCuadre = FactorCuadre;
			this.FlagTop = FlagTop;
			this.Tono = Tono;
			this.Marca = Marca;
			this.Categoria = Categoria;
			this.Tipo = Tipo;
			this.DescuentoSet = DescuentoSet;
			this.ReglaSet = ReglaSet;
			this.GAPMNvsImpreso = GAPMNvsImpreso;
			this.GAPUSDvsImpreso = GAPUSDvsImpreso;
			this.IndicadorCxC = IndicadorCxC;
			this.FactoRepeticion = FactoRepeticion;
			this.POUnitarioMN = POUnitarioMN;
			this.POSetMN = POSetMN;
			this.PNSetMN = PNSetMN;
			this.PNUnitarioMN = PNUnitarioMN;
			this.Unidades = Unidades;
			this.P1 = P1;
			this.P2 = P2;
			this.P3 = P3;
			this.P4 = P4;
			this.P5 = P5;
			this.P6 = P6;
			this.P7 = P7;
			this.Comentario = Comentario;
			this.CODP = CODP;
			this.NumeroProductosOferta = NumeroProductosOferta;
			this.TipoPlan = TipoPlan;
			this.IndicadorSubcampana = IndicadorSubcampana;
            this.CantidadSAPDiferentes = CantidadSAPDiferentes;

            this.UsuarioCreacion = UsuarioCreacion;
		}

		/// <summary>
		/// Initializes a new instance of the ConsolidadoModel class.
		/// </summary>
		public ConsolidadoModel(long IdConsolidado, int IdCampanaPlaneacion, int IdCampanaProceso, short IdPalanca, byte UnidadesLimite, byte NumeroEspacios, byte IdPais, int CuentaOfertas, bool Binomio, string CUVPadre, string CUV, string CUCAntiguo, string SAPAntiguo, string BPCSGenericoAntiguo, string BPCSTonoAntiguo, string DescripcionGenericoAntiguo, string DescripcionTonoAntiguo, bool Lanzamiento, string CUC, string SAP, string BPCSGenerico, string BPCSTono, bool IndicadorGratis, string DescripcionSet, string DescripcionProducto, string DescripcionCatalogo, bool CompuestaVariable, long NumeroGrupo, bool FactorCuadre, bool FlagTop, string Tono, int IdMarca, int IdCategoria, string Tipo, decimal DescuentoSet, decimal ReglaSet, long GAPMNvsImpreso, long GAPUSDvsImpreso, bool IndicadorCxC, long FactoRepeticion, decimal POUnitarioMN, decimal POSetMN, decimal PNSetMN, decimal PNUnitarioMN, long Unidades, bool P1, bool P2, bool P3, bool P4, bool P5, bool P6, bool P7, string Comentario, string CODP, long NumeroProductosOferta, string TipoPlan, bool IndicadorSubcampana, int CantidadSAPDiferentes, string UsuarioModificacion)
		{
			this.IdConsolidado = IdConsolidado;
			this.IdCampanaPlaneacion = IdCampanaPlaneacion;
			this.IdCampanaProceso = IdCampanaProceso;
			this.IdPalanca = IdPalanca;
			this.UnidadesLimite = UnidadesLimite;
			this.NumeroEspacios = NumeroEspacios;
			this.IdPais = IdPais;
			this.CuentaOfertas = CuentaOfertas;
			this.Binomio = Binomio;
			this.CUVPadre = CUVPadre;
			this.CUV = CUV;
			this.CUCAntiguo = CUCAntiguo;
			this.SAPAntiguo = SAPAntiguo;
			this.BPCSGenericoAntiguo = BPCSGenericoAntiguo;
			this.BPCSTonoAntiguo = BPCSTonoAntiguo;
			this.DescripcionGenericoAntiguo = DescripcionGenericoAntiguo;
			this.DescripcionTonoAntiguo = DescripcionTonoAntiguo;
			this.Lanzamiento = Lanzamiento;
			this.CUC = CUC;
			this.SAP = SAP;
			this.BPCSGenerico = BPCSGenerico;
			this.BPCSTono = BPCSTono;
			this.IndicadorGratis = IndicadorGratis;
			this.DescripcionSet = DescripcionSet;
			this.DescripcionProducto = DescripcionProducto;
			this.DescripcionCatalogo = DescripcionCatalogo;
			this.CompuestaVariable = CompuestaVariable;
			this.NumeroGrupo = NumeroGrupo;
			this.FactorCuadre = FactorCuadre;
			this.FlagTop = FlagTop;
			this.Tono = Tono;
			this.Marca = Marca;
			this.Categoria = Categoria;
			this.Tipo = Tipo;
			this.DescuentoSet = DescuentoSet;
			this.ReglaSet = ReglaSet;
			this.GAPMNvsImpreso = GAPMNvsImpreso;
			this.GAPUSDvsImpreso = GAPUSDvsImpreso;
			this.IndicadorCxC = IndicadorCxC;
			this.FactoRepeticion = FactoRepeticion;
			this.POUnitarioMN = POUnitarioMN;
			this.POSetMN = POSetMN;
			this.PNSetMN = PNSetMN;
			this.PNUnitarioMN = PNUnitarioMN;
			this.Unidades = Unidades;
			this.P1 = P1;
			this.P2 = P2;
			this.P3 = P3;
			this.P4 = P4;
			this.P5 = P5;
			this.P6 = P6;
			this.P7 = P7;
			this.Comentario = Comentario;
			this.CODP = CODP;
			this.NumeroProductosOferta = NumeroProductosOferta;
			this.TipoPlan = TipoPlan;
			this.IndicadorSubcampana = IndicadorSubcampana;
			this.UsuarioModificacion = UsuarioModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdConsolidado value. 
		/// </summary>
		public long IdConsolidado { get; set; }

		/// <summary>
		/// Gets or sets the IdCampanaPlaneacion value. 
		/// </summary>
		public int IdCampanaPlaneacion { get; set; }

		/// <summary>
		/// Gets or sets the IdCampanaProceso value. 
		/// </summary>
		public int IdCampanaProceso { get; set; }

		/// <summary>
		/// Gets or sets the IdPalanca value. 
		/// </summary>
		public short IdPalanca { get; set; }

		/// <summary>
		/// Gets or sets the UnidadesLimite value. 
		/// </summary>
		public Nullable<byte> UnidadesLimite { get; set; }

		/// <summary>
		/// Gets or sets the NumeroEspacios value. 
		/// </summary>
		public Nullable<byte> NumeroEspacios { get; set; }

		/// <summary>
		/// Gets or sets the IdPais value. 
		/// </summary>
		public byte IdPais { get; set; }

		/// <summary>
		/// Gets or sets the CuentaOfertas value. 
		/// </summary>
		public int CuentaOfertas { get; set; }

		/// <summary>
		/// Gets or sets the Binomio value. 
		/// </summary>
		public Nullable<bool> Binomio { get; set; }

		/// <summary>
		/// Gets or sets the CUVPadre value. 
		/// </summary>
		public string CUVPadre { get; set; }

		/// <summary>
		/// Gets or sets the CUV value. 
		/// </summary>
		public string CUV { get; set; }

		/// <summary>
		/// Gets or sets the CUCAntiguo value. 
		/// </summary>
		public string CUCAntiguo { get; set; }

		/// <summary>
		/// Gets or sets the SAPAntiguo value. 
		/// </summary>
		public string SAPAntiguo { get; set; }

		/// <summary>
		/// Gets or sets the BPCSGenericoAntiguo value. 
		/// </summary>
		public string BPCSGenericoAntiguo { get; set; }

		/// <summary>
		/// Gets or sets the BPCSTonoAntiguo value. 
		/// </summary>
		public string BPCSTonoAntiguo { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionGenericoAntiguo value. 
		/// </summary>
		public string DescripcionGenericoAntiguo { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionTonoAntiguo value. 
		/// </summary>
		public string DescripcionTonoAntiguo { get; set; }

		/// <summary>
		/// Gets or sets the Lanzamiento value. 
		/// </summary>
		public Nullable<bool> Lanzamiento { get; set; }

		/// <summary>
		/// Gets or sets the CUC value. 
		/// </summary>
		public string CUC { get; set; }

		/// <summary>
		/// Gets or sets the SAP value. 
		/// </summary>
		public string SAP { get; set; }

		/// <summary>
		/// Gets or sets the BPCSGenerico value. 
		/// </summary>
		public string BPCSGenerico { get; set; }

		/// <summary>
		/// Gets or sets the BPCSTono value. 
		/// </summary>
		public string BPCSTono { get; set; }

		/// <summary>
		/// Gets or sets the IndicadorGratis value. 
		/// </summary>
		public Nullable<bool> IndicadorGratis { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionSet value. 
		/// </summary>
		public string DescripcionSet { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionProducto value. 
		/// </summary>
		public string DescripcionProducto { get; set; }

		/// <summary>
		/// Gets or sets the DescripcionCatalogo value. 
		/// </summary>
		public string DescripcionCatalogo { get; set; }

		/// <summary>
		/// Gets or sets the CompuestaVariable value. 
		/// </summary>
		public Nullable<bool> CompuestaVariable { get; set; }

		/// <summary>
		/// Gets or sets the NumeroGrupo value. 
		/// </summary>
		public Nullable<long> NumeroGrupo { get; set; }

		/// <summary>
		/// Gets or sets the FactorCuadre value. 
		/// </summary>
		public Nullable<bool> FactorCuadre { get; set; }

		/// <summary>
		/// Gets or sets the FlagTop value. 
		/// </summary>
		public Nullable<bool> FlagTop { get; set; }

		/// <summary>
		/// Gets or sets the Tono value. 
		/// </summary>
		public string Tono { get; set; }

		/// <summary>
		/// Gets or sets the Marca value. 
		/// </summary>
		public string Marca { get; set; }

		/// <summary>
		/// Gets or sets the Categoria value. 
		/// </summary>
		public string Categoria { get; set; }

		/// <summary>
		/// Gets or sets the Tipo value. 
		/// </summary>
		public string Tipo { get; set; }

		/// <summary>
		/// Gets or sets the DescuentoSet value. 
		/// </summary>
		public Nullable<decimal> DescuentoSet { get; set; }

		/// <summary>
		/// Gets or sets the ReglaSet value. 
		/// </summary>
		public Nullable<decimal> ReglaSet { get; set; }

		/// <summary>
		/// Gets or sets the GAPMNvsImpreso value. 
		/// </summary>
		public Nullable<long> GAPMNvsImpreso { get; set; }

		/// <summary>
		/// Gets or sets the GAPUSDvsImpreso value. 
		/// </summary>
		public Nullable<long> GAPUSDvsImpreso { get; set; }

		/// <summary>
		/// Gets or sets the IndicadorCxC value. 
		/// </summary>
		public Nullable<bool> IndicadorCxC { get; set; }

		/// <summary>
		/// Gets or sets the FactoRepeticion value. 
		/// </summary>
		public Nullable<long> FactoRepeticion { get; set; }

		/// <summary>
		/// Gets or sets the POUnitarioMN value. 
		/// </summary>
		public decimal POUnitarioMN { get; set; }

		/// <summary>
		/// Gets or sets the POSetMN value. 
		/// </summary>
		public decimal POSetMN { get; set; }

		/// <summary>
		/// Gets or sets the PNSetMN value. 
		/// </summary>
		public decimal PNSetMN { get; set; }

		/// <summary>
		/// Gets or sets the PNUnitarioMN value. 
		/// </summary>
		public decimal PNUnitarioMN { get; set; }

		/// <summary>
		/// Gets or sets the Unidades value. 
		/// </summary>
		public Nullable<long> Unidades { get; set; }

		/// <summary>
		/// Gets or sets the P1 value. 
		/// </summary>
		public Nullable<bool> P1 { get; set; }

		/// <summary>
		/// Gets or sets the P2 value. 
		/// </summary>
		public Nullable<bool> P2 { get; set; }

		/// <summary>
		/// Gets or sets the P3 value. 
		/// </summary>
		public Nullable<bool> P3 { get; set; }

		/// <summary>
		/// Gets or sets the P4 value. 
		/// </summary>
		public Nullable<bool> P4 { get; set; }

		/// <summary>
		/// Gets or sets the P5 value. 
		/// </summary>
		public Nullable<bool> P5 { get; set; }

		/// <summary>
		/// Gets or sets the P6 value. 
		/// </summary>
		public Nullable<bool> P6 { get; set; }

		/// <summary>
		/// Gets or sets the P7 value. 
		/// </summary>
		public Nullable<bool> P7 { get; set; }

		/// <summary>
		/// Gets or sets the Comentario value. 
		/// </summary>
		public string Comentario { get; set; }

		/// <summary>
		/// Gets or sets the CODP value. 
		/// </summary>
		public string CODP { get; set; }

		/// <summary>
		/// Gets or sets the NumeroProductosOferta value. 
		/// </summary>
		public Nullable<long> NumeroProductosOferta { get; set; }

		/// <summary>
		/// Gets or sets the TipoPlan value. 
		/// </summary>
		public string TipoPlan { get; set; }

		/// <summary>
		/// Gets or sets the IndicadorSubcampana value. 
		/// </summary>
		public Nullable<bool> IndicadorSubcampana { get; set; }

        /// <summary>
        /// Gets or sets the NumeroRepeticionesSAP value. 
        /// </summary>
        public Nullable<int> NumeroRepeticionesSAP { get; set; }

        /// <summary>
        /// Gets or sets the TipoOferta value. 
        /// </summary>
        public short TipoOferta { get; set; }

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
		public Nullable<System.DateTime> FechaModificacion { get; set; }

        /// <summary>
        /// Gets or sets the PageIndex value. 
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the PageSize value. 
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the CantidadSAPDiferentes value. 
        /// </summary>
        public Nullable<int> CantidadSAPDiferentes { get; set; }




        #endregion
    }
}
