using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DXCTechnology.Belcorp.ePlanning.Web.Models
{
    public class BusquedaConsolidado
    {
        [Display(Name = "Palanca")]
        public int IdPalanca { get; set; }
        public SelectList PalancaList { get; set; }

        [Display(Name = "Campaña")]
        public int IdCampana { get; set; }
        public SelectList CampanaList { get; set; }

        [Display(Name = "País")]
        public int IdPais { get; set; }
        public SelectList PaisList { get; set; }

        [Display(Name = "Cuenta Ofertas")]
        public string CuentaOfertas { get; set; }

        [Display(Name = "Tipo Oferta")]
        public int IdTipoOferta { get; set; }

        [Display(Name = "Tipo Oferta")]
        public SelectList TipoOfertaList { get; set; }

        [Display(Name = "CUC")]
        public string CUC { get; set; }

        [Display(Name = "SAP")]
        public string SAP { get; set; }
    }
}