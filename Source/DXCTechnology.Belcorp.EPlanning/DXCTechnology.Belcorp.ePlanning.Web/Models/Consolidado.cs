﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXCTechnology.Belcorp.ePlanning.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Consolidado
    {
        public long IdConsolidado { get; set; }
        public int IdCampanaPlaneacion { get; set; }
        public int IdCampanaProceso { get; set; }
        public short IdPalanca { get; set; }
        public Nullable<byte> UnidadesLimite { get; set; }
        public Nullable<byte> NumeroEspacios { get; set; }
        public byte IdPais { get; set; }
        public int CuentaOfertas { get; set; }
        public Nullable<bool> Binomio { get; set; }
        public string CUVPadre { get; set; }
        public string CUV { get; set; }
        public string CUCAntiguo { get; set; }
        public string SAPAntiguo { get; set; }
        public string BPCSGenericoAntiguo { get; set; }
        public string BPCSTonoAntiguo { get; set; }
        public string DescripcionGenericoAntiguo { get; set; }
        public string DescripcionTonoAntiguo { get; set; }
        public Nullable<bool> Lanzamiento { get; set; }

        [Required(ErrorMessage = "CUC")]
        public string CUC { get; set; }

        [Required(ErrorMessage = "SAP")]
        public string SAP { get; set; }

        [Required(ErrorMessage = "BPCSGenerico")]
        public string BPCSGenerico { get; set; }

        [Required(ErrorMessage = "BPCSTono")]
        public string BPCSTono { get; set; }

        public Nullable<bool> IndicadorGratis { get; set; }

        [Required(ErrorMessage = "DescripcionSet")]
        public string DescripcionSet { get; set; }

        public string DescripcionProducto { get; set; }
        public string DescripcionCatalogo { get; set; }
        public Nullable<bool> CompuestaVariable { get; set; }
        public Nullable<long> NumeroGrupo { get; set; }
        public Nullable<bool> FactorCuadre { get; set; }
        public Nullable<bool> FlagTop { get; set; }
        public string Tono { get; set; }
        public string Marca { get; set; }

        [Required(ErrorMessage = "Categoria")]
        public string Categoria { get; set; }

        public string Tipo { get; set; }
        public Nullable<decimal> DescuentoSet { get; set; }
        public Nullable<decimal> ReglaSet { get; set; }
        public Nullable<long> GAPMNvsImpreso { get; set; }
        public Nullable<long> GAPUSDvsImpreso { get; set; }
        public Nullable<bool> IndicadorCxC { get; set; }
        public Nullable<long> FactoRepeticion { get; set; }
        public decimal POUnitarioMN { get; set; }
        public decimal POSetMN { get; set; }
        public decimal PNSetMN { get; set; }
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
        public Nullable<long> NumeroProductosOferta { get; set; }
        public string TipoPlan { get; set; }
        public Nullable<bool> IndicadorSubcampana { get; set; }
        public Nullable<int> CantidadSAPDiferentes { get; set; }
        public Nullable<int> NumeroRepeticionesSAP { get; set; }

        public short TipoOferta { get; set; }

        [Required(ErrorMessage = "UsuarioCreacion")]
        public string UsuarioCreacion { get; set; }

        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }

        //public virtual Campana Campana { get; set; }
        //public virtual Campana Campana1 { get; set; }
        //public virtual Pais Pais { get; set; }
        //public virtual Palanca Palanca { get; set; }
    }
}
