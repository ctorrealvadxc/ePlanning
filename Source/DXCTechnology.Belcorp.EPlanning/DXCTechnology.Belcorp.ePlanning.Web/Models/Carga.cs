using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXCTechnology.Belcorp.ePlanning.Models
{
    public class Carga
    {
        public Carga()
        {
            this.ListaCampanaPlaneacion = new SelectList(new List<string>());
            this.ListaCampanaProceso = new SelectList(new List<string>() { "Sin datos" });
        }

        public SelectList ListaCampanaPlaneacion { get; set; }
        public SelectList ListaCampanaProceso { get; set; }



        [Required(ErrorMessage = "Seleccione Palanca.")]
        [DisplayName("Palanca")]
        public Int16 Palanca { get; set; }
        public List<SelectListItem> PalancaListItems { get; set; }

        [Required(ErrorMessage = "Ingrese Campaña Planeación.")]
        [DisplayName("Campaña Planeación")]
        public int CampanaPlaneacion { get; set; }
        public List<SelectListItem> CampanaPlaListItems { get; set; }

        [Required(ErrorMessage = "Ingrese Campaña Proceso.")]
        [DisplayName("Campaña Proceso")]
        public int CampanaProceso { get; set; }
        public List<SelectListItem> CampanaProListItems { get; set; }


        [Required(ErrorMessage = "Ingrese Valor.")]
        [Range(1, 25)]
        [DisplayName("Número de Espacios")]
        public string Espacios { get; set; }

        [DisplayName("Unidades Límite")]
        [Required(ErrorMessage = "Ingrese Valor.")]
        [Range(0, 99)]
        [DefaultValue(true)]
        public Int16 UnidadesLimite { get; set; } 

        [Required(ErrorMessage = "Seleccione Archivo.")]
        [DisplayName("Archivo")]
        public string Archivo { get; set; }



        





    }
}