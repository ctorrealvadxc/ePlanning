using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DXCTechnology.Belcorp.ePlanning.Web.Models;
using DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;
using DXCTechnology.Belcorp.ePlanning.SharedLibreries;
using System.Configuration;

namespace DXCTechnology.Belcorp.ePlanning.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Carga()
        {
            return View();
        }
        
        public ActionResult Edicion()
        {
            ViewBag.Message = "Página de edición.";
            return View();
        }


        public ActionResult Test()
        {
            ViewBag.Message = "Página de TEST.";
            BL_Archivo objArchivo = new BL_Archivo();
            ArchivoModel Archivo = new ArchivoModel();
            Archivo.PageIndex = 1;
            Archivo.PageSize = 1000;
            ModelState.Clear();
            return View(objArchivo.SelectAll(Archivo));   
        }

        public ActionResult Test3()
        {
            ViewBag.Message = "Página de WebPage1.";
            return View();
        }

        public static List<SelectListItem> GetPalanca()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            BL_Palanca objPalanca = new BL_Palanca();
            PalancaModel Palanca = new PalancaModel();
            Palanca.PageSize = 20;
            Palanca.PageIndex = 1;
            List<PalancaModel> lstPalanca = objPalanca.SelectAll(Palanca);
            foreach (var temp in lstPalanca)
            {
                items.Add(new SelectListItem() { Text = temp.Descripcion, Value = temp.IdPalanca.ToString() });
            }
            return items;
        }
        public static List<SelectListItem> GetCampanaPlaneamiento()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            BL_Campana objCampana = new BL_Campana();
            CampanaModel Campana = new CampanaModel();
            Campana.PageSize = 20;
            Campana.PageIndex = 1;
            List<CampanaModel> lstCampana = objCampana.SelectAll(Campana);
            foreach (var temp in lstCampana)
            {
                items.Add(new SelectListItem() { Text = temp.IdCampana.ToString(), Value = temp.IdCampana.ToString() });
            }
            return items;
        }
        public static List<SelectListItem> GetCampanaProceso()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            BL_Campana objCampana = new BL_Campana();
            CampanaModel Campana = new CampanaModel();
            Campana.PageSize = 20;
            Campana.PageIndex = 1;
            List<CampanaModel> lstCampana = objCampana.SelectAll(Campana);
            foreach (var temp in lstCampana)
            {
                items.Add(new SelectListItem() { Text = temp.IdCampana.ToString(), Value = temp.IdCampana.ToString() });
            }
            return items;
        }


        // POST: Employee/AddEmployee
        [HttpPost]
        public ActionResult AddEmployee(HttpPostedFileBase file, Carga Emp)
        {
            try
            {
                string NombreCargado = string.Empty;
                string NombreHistorico = string.Empty;
                if (file != null)
                {
                    NombreCargado = Server.MapPath(ConfigurationManager.AppSettings.Get("ProcessFolder").ToString()) + "\\" + Path.GetFileName(file.FileName);

                    file.SaveAs(NombreCargado);

                    BL_Archivo objArchivo = new BL_Archivo();
                    ArchivoModel Archivo = new ArchivoModel
                    {
                        NombreCargado = NombreCargado,
                        NombreHistorico = NombreHistorico,
                        IdPalanca = Convert.ToInt16(Emp.Palanca),
                        IdCampanaPlaneacion = Emp.CampanaPlaneacion,
                        IdCampanaProceso = Emp.CampanaProceso,
                        NumeroEspacios = Convert.ToByte(Emp.Espacios),
                        UnidadesLimite = Convert.ToByte(Emp.UnidadesLimite),
                        IdEstado = Estados.ArchivoCargado,
                        UsuarioCreacion = ""
                    };

                    String extension = System.IO.Path.GetExtension(Archivo.NombreCargado);
                    Archivo.NombreHistorico = Archivo.IdCampanaPlaneacion.ToString() + "_" +
                            Archivo.IdPalanca.ToString() + "_" + Archivo.UsuarioCreacion + "_" +
                            DateTime.Now.ToString("yyyyMMdd_HHmm") + extension;

                    objArchivo.Insert(Archivo);
                    ViewBag.Message = "Proceso de carga terminado";

                    if (new BL_Consolidado().ValidateConsolidado(Archivo))
                    {
                        ViewBag.Message = "Archivo validado satisfactoriamente. Calculando...";
                        new BL_Consolidado().CalculateConsolidado(Archivo);
                        ViewBag.Message = "Finalizo el calculo del Consolidado";
                    }
                    else
                    {
                        ViewBag.Message = "Archivo cargado no es válido.";
                    }

                    System.IO.File.Move(Archivo.NombreCargado, ConfigurationManager.AppSettings.Get("HistoryFolder").ToString() + Archivo.NombreHistorico);
                }
                else
                {
                    ViewBag.Message = "Seleccione Archivo";
                }
                return View("Carga");
            }
            catch
            {
                return View("Carga");
            }
        }
    }
}