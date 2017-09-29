using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.Web.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: Consulta 
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult Consulta()
        {
            ViewBag.Message = "Consulta.";
            BL_Consolidado objConsulidado = new BL_Consolidado();
            ConsolidadoModel Consolidado = new ConsolidadoModel();
            Consolidado.PageIndex = 1;
            Consolidado.PageSize = 1000;
            ModelState.Clear();
            return View(objConsulidado.SelectAll(Consolidado));
        }
    }
}