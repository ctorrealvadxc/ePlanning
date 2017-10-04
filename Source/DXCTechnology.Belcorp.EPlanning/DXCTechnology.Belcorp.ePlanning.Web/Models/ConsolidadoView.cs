using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXCTechnology.Belcorp.ePlanning.Web.Models
{
    public class ConsolidadoView
    {
        public long IdConsolidado { get; set; }
        public int IdCampanaPlaneacion { get; set; }
        public int IdCampanaProceso { get; set; }
        public short IdPalanca { get; set; }

        [Display(Name = "Unidades Limite")]
        public Nullable<byte> UnidadesLimite { get; set; }

        [Display(Name = "Numero Espacios")]
        public Nullable<byte> NumeroEspacios { get; set; }
        public byte IdPais { get; set; }

        [Required(ErrorMessage = "CuentaOfertas")]
        [Display(Name = "CuentaOfertas")]
        public int CuentaOfertas { get; set; }

        public Nullable<bool> Binomio { get; set; }

        [Display(Name = "CUV Padre")]
        public string CUVPadre { get; set; }
        public string CUV { get; set; }

        [Display(Name = "SAPAntiguo")]
        public string CUCAntiguo { get; set; }

        [Display(Name = "SAPAntiguo")]
        public string SAPAntiguo { get; set; }

        [Display(Name = "BPCS Generico Ant.")]
        public string BPCSGenericoAntiguo { get; set; }

        [Display(Name = "BPCS Tono Ant.")]
        public string BPCSTonoAntiguo { get; set; }

        [Display(Name = "SAPADes. Genérico Ant.")]
        public string DescripcionGenericoAntiguo { get; set; }

        [Display(Name = "Des. Tono Ant.")]
        public string DescripcionTonoAntiguo { get; set; }


        public Nullable<bool> Lanzamiento { get; set; }

        [Required(ErrorMessage = "CUC")]
        [Display(Name = "CUC")]
        public string CUC { get; set; }

        [Required(ErrorMessage = "SAP")]
        public string SAP { get; set; }

        [Required(ErrorMessage = "BPCSGenerico")]
        public string BPCSGenerico { get; set; }

        [Required(ErrorMessage = "BPCSTono")]
        public string BPCSTono { get; set; }

        [Display(Name = "Indicador Gratis")]
        public Nullable<bool> IndicadorGratis { get; set; }

        [Required(ErrorMessage = "DescripcionSet")]
        public string DescripcionSet { get; set; }

        [Display(Name = "Descripcion Producto")]
        public string DescripcionProducto { get; set; }

        [Display(Name = "Descripcion Catalogo")]
        public string DescripcionCatalogo { get; set; }

        [Display(Name = "Compuesta Variable")]
        public Nullable<bool> CompuestaVariable { get; set; }

        [Display(Name = "Num. Grupo")]
        public Nullable<long> NumeroGrupo { get; set; }

        [Display(Name = "Factor Cuadre")]
        public Nullable<bool> FactorCuadre { get; set; }

        [Display(Name = "Flag Top")]
        public Nullable<bool> FlagTop { get; set; }

        public string Tono { get; set; }
        public string Marca { get; set; }

        [Required(ErrorMessage = "Categoria")]
        public string Categoria { get; set; }

        public string Tipo { get; set; }

        [Display(Name = "Descuento Set")]
        public Nullable<decimal> DescuentoSet { get; set; }

        [Display(Name = "Regla Set")]
        public Nullable<decimal> ReglaSet { get; set; }

        [Display(Name = "GAP MN vs Impreso")]
        public Nullable<long> GAPMNvsImpreso { get; set; }

        [Display(Name = "GAP USD vs Impreso")]
        public Nullable<long> GAPUSDvsImpreso { get; set; }

        [Display(Name = "Indicador CxC")]
        public Nullable<bool> IndicadorCxC { get; set; }

        [Display(Name = "Facto Repeticion")]
        public Nullable<long> FactoRepeticion { get; set; }

        [Display(Name = "PO Unitario MN")]
        [Required(ErrorMessage = "POUnitarioMN")]
        public decimal POUnitarioMN { get; set; }

        [Display(Name = "PO Set MN")]
        [Required(ErrorMessage = "POSetMN")]
        public decimal POSetMN { get; set; }

        [Display(Name = "PN Set MN")]
        [Required(ErrorMessage = "PNSetMN")]
        public decimal PNSetMN { get; set; }

        [Display(Name = "PN Unitario MN")]
        [Required(ErrorMessage = "PNUnitarioMN")]
        public decimal PNUnitarioMN { get; set; }


        public Nullable<long> Unidades { get; set; }
        public Nullable<bool> P1 { get; set; }
        public Nullable<bool> P2 { get; set; }
        public Nullable<bool> P3 { get; set; }
        public Nullable<bool> P4 { get; set; }
        public Nullable<bool> P5 { get; set; }
        public Nullable<bool> P6 { get; set; }
        public Nullable<bool> P7 { get; set; }
        public string Comentario { get; set; }
        public string CODP { get; set; }

        [Display(Name = "Numero Productos Oferta")]
        public Nullable<long> NumeroProductosOferta { get; set; }

        [Display(Name = "Tipo Plan")]
        public string TipoPlan { get; set; }

        [Display(Name = "Indicador Sub campana")]
        public Nullable<bool> IndicadorSubcampana { get; set; }

        [Display(Name = "Cantidad SAP Diferentes")]
        public Nullable<int> CantidadSAPDiferentes { get; set; }

        [Display(Name = "Numero Repeticiones SAP")]
        public Nullable<int> NumeroRepeticionesSAP { get; set; }

        public Nullable<int> IdTactica { get; set; }
        public Nullable<short> TipoOferta { get; set; }

        [Required(ErrorMessage = "UsuarioCreacion")]
        public string UsuarioCreacion { get; set; }

        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> IdArgumento { get; set; }

        [Display(Name = "Campaña Planeación")]
        public SelectList CampanaSelectList { get; set; }

        [Display(Name = "Campaña Proceso")]
        public SelectList CampanaSelectList1 { get; set; }

        [Display(Name = "País")]
        public SelectList PaisSelectList { get; set; }

        [Display(Name = "Palanca")]
        public SelectList PalancaSelectList { get; set; }
    }
}