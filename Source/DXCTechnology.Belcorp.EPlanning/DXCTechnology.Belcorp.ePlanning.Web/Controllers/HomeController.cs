using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;
using DXCTechnology.Belcorp.ePlanning.Models;
using DXCTechnology.Belcorp.ePlanning.SharedLibraries;

namespace DXCTechnology.Belcorp.ePlanning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Consolidado()
        {
            ViewBag.Message = "Consolidado.";

            return View();
        }

        public ActionResult Carga()
        {
            Carga carga = new Models.Carga();
            carga.UnidadesLimite = 99;


            return View(carga);
        }


        public static List<SelectListItem> GetPalanca()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            BL_Palanca objPalanca = new BL_Palanca();
            PalancaModel Palanca = new PalancaModel();
            Palanca.PageSize = 100;
            Palanca.PageIndex = 1;
            List<PalancaModel> lstPalanca = objPalanca.SelectAll(Palanca);
            foreach (var temp in lstPalanca)
            {
                items.Add(new SelectListItem() { Text = temp.Abreviatura, Value = temp.IdPalanca.ToString() });
            }
            return items;
        }
        public static List<SelectListItem> GetCampanaPlaneamiento()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            BL_Campana objCampana = new BL_Campana();
            CampanaModel Campana = new CampanaModel();
            Campana.PageSize = 100;
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
            Campana.PageSize = 100;
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
            string Mensaje = string.Empty;
            try
            {
                string NombreCargado = string.Empty;
                string NombreHistorico = string.Empty;
                if (file != null)
                {
                    NombreCargado = Server.MapPath(ConfigurationManager.AppSettings.Get("ProcessFolder").ToString()) + "\\" + DateTime.Now.Ticks + "_" +Path.GetFileName(file.FileName);

                    file.SaveAs(NombreCargado);
                    Mensaje = Mensaje + "Proceso de Copia al Servidor: Terminado. <br />";

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
                    Mensaje = Mensaje + "Proceso de Versionamiento al Servidor: Terminado. <br />";

                    string MensajeCarga = new BL_Consolidado().ValidateConsolidado(Archivo);
                    if (MensajeCarga == "")
                    {
                        Mensaje = Mensaje + "Proceso de Validación: Terminado. <br />";
                        try
                        {
                            new BL_Consolidado().Carga(Archivo);                            
                            Mensaje = Mensaje + "Proceso de Carga: Terminado. <br />";
                            try
                            {
                                new BL_Consolidado().ProcessVariables(Archivo);
                            }
                            catch (Exception ex)
                            {
                                Mensaje = Mensaje + "Proceso de Cálculo: Error. " + ex.Message + "<br />";
                            }
                        }
                        catch (Exception ex )
                        {
                            Mensaje = Mensaje + "Proceso de Carga: Error. " + ex.Message + "<br />";
                        }
                        
                    }
                    else
                    {
                        Mensaje = Mensaje + "Proceso de Validación: "  + MensajeCarga;
                    }

                    //System.IO.File.Move(Archivo.NombreCargado, ConfigurationManager.AppSettings.Get("HistoryFolder").ToString() + Archivo.NombreHistorico);

                    ViewBag.Message = Mensaje;

                    


                }
                else
                {
                    ViewBag.Message = "Seleccione Archivo";
                }
                return View("Carga");
            }
            catch (Exception Ex)
            {
                ViewBag.Message = "Error En el Proceso" + Ex.Message;
                return View("Carga");
            }
        }


        //Metodo para obtener especificamente 1 Country by Id valor retornado como Json
        public JsonResult GetCampanaProceso(int CampanaPlaneacion)
        {

            List<SelectListItem> items = new List<SelectListItem>();
            BL_Campana objCampana = new BL_Campana();
            CampanaModel Campana = new CampanaModel();
            Campana.IdCampana = CampanaPlaneacion;
            Campana.PageSize = 100;
            Campana.PageIndex = 1;
            List<CampanaModel> lstCampana = objCampana.SelectProceso(Campana);
            foreach (var temp in lstCampana)
            {
                items.Add(new SelectListItem() { Text = temp.IdCampana.ToString(), Value = temp.IdCampana.ToString() });
            }
            return Json(new SelectList(items, "IdCampana", "IdCampana"));
        }
    }
}