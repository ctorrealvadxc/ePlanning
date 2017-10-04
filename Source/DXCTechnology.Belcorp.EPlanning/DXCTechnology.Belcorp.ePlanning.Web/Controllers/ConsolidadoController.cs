using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DXCTechnology.Belcorp.ePlanning.Web.Models;
using DataTables.Mvc;
using DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;
using DXCTechnology.Belcorp.ePlanning.SharedLibraries.Extensions;
using System.ComponentModel;

using System.Linq.Dynamic;


namespace DXCTechnology.Belcorp.ePlanning.Controllers
{
    public class ConsolidadoController : Controller
    {
        private ePlanningDBEntities db = new ePlanningDBEntities();

        // GET: Consolidado
        public ActionResult Index()
        {
            //var consolidado = db.Consolidado.Include(c => c.Campana).Include(c => c.Campana1).Include(c => c.Pais).Include(c => c.Palanca);
            //return View(consolidado.ToList());
            return View();
        }


        public ActionResult Get([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, BusquedaConsolidado searchViewModel)
        {
            //IQueryable<Asset> query = DbContext.Assets;
            IQueryable<Consolidado> query = db.Consolidado.Include(c => c.Campana).Include(c => c.Campana1).Include(c => c.Pais).Include(c => c.Palanca);
            query = SearchConsolidado(requestModel, searchViewModel, query);


            


            var totalCount = query.Count();

            // searching and sorting
            //query = SearchAssets(requestModel, searchViewModel, query);
            var filteredCount = query.Count();

            // Paging
            query = query.Skip(requestModel.Start).Take(requestModel.Length);

            var data = query.Select(consolidado => new
            {
                DescripcionSet = consolidado.DescripcionSet
            }).ToList();

            List<Consolidado> lstConsolidado = new List<Consolidado>();
            foreach (var item in query)
            {
                Consolidado consolidado = new Consolidado();
                consolidado.IdConsolidado = item.IdConsolidado;
                consolidado.IdCampanaPlaneacion = item.IdCampanaPlaneacion;
                consolidado.IdCampanaProceso = item.IdCampanaProceso;
                consolidado.IdPalanca = item.IdPalanca;
                consolidado.UnidadesLimite = item.UnidadesLimite;
                consolidado.NumeroEspacios = item.NumeroEspacios;
                consolidado.IdPais = item.IdPais;
                consolidado.CuentaOfertas = item.CuentaOfertas;
                consolidado.Binomio = item.Binomio;
                consolidado.CUVPadre = item.CUVPadre;
                consolidado.CUV = item.CUV;
                consolidado.CUCAntiguo = item.CUCAntiguo;
                consolidado.SAPAntiguo = item.SAPAntiguo;
                consolidado.BPCSGenericoAntiguo = item.BPCSGenericoAntiguo;
                consolidado.BPCSTonoAntiguo = item.BPCSTonoAntiguo;
                consolidado.DescripcionGenericoAntiguo = item.DescripcionGenericoAntiguo;
                consolidado.DescripcionTonoAntiguo = item.DescripcionTonoAntiguo;
                consolidado.Lanzamiento = item.Lanzamiento;
                consolidado.CUC = item.CUC;
                consolidado.SAP = item.SAP;
                consolidado.BPCSGenerico = item.BPCSGenerico;
                consolidado.BPCSTono = item.BPCSTono;
                consolidado.IndicadorGratis = item.IndicadorGratis;
                consolidado.DescripcionSet = item.DescripcionSet;
                consolidado.DescripcionProducto = item.DescripcionProducto;
                consolidado.DescripcionCatalogo = item.DescripcionCatalogo;
                consolidado.CompuestaVariable = item.CompuestaVariable;
                consolidado.NumeroGrupo = item.NumeroGrupo;
                consolidado.FactorCuadre = item.FactorCuadre;
                consolidado.FlagTop = item.FlagTop;
                consolidado.Tono = item.Tono;
                consolidado.Marca = item.Marca;
                consolidado.Categoria = item.Categoria;
                consolidado.Tipo = item.Tipo;
                consolidado.DescuentoSet = item.DescuentoSet;
                consolidado.ReglaSet = item.ReglaSet;
                consolidado.GAPMNvsImpreso = item.GAPMNvsImpreso;
                consolidado.GAPUSDvsImpreso = item.GAPUSDvsImpreso;
                consolidado.IndicadorCxC = item.IndicadorCxC;
                consolidado.FactoRepeticion = item.FactoRepeticion;
                consolidado.POUnitarioMN = item.POUnitarioMN;
                consolidado.POSetMN = item.POSetMN;
                consolidado.PNSetMN = item.PNSetMN;
                consolidado.PNUnitarioMN = item.PNUnitarioMN;
                consolidado.Unidades = item.Unidades;
                consolidado.P1 = item.P1;
                consolidado.P2 = item.P2;
                consolidado.P3 = item.P3;
                consolidado.P4 = item.P4;
                consolidado.P5 = item.P5;
                consolidado.P6 = item.P6;
                consolidado.P7 = item.P7;
                consolidado.Comentario = item.Comentario;
                consolidado.CODP = item.CODP;
                consolidado.NumeroProductosOferta = item.NumeroProductosOferta;
                consolidado.TipoPlan = item.TipoPlan;
                consolidado.IndicadorSubcampana = item.IndicadorSubcampana;
                consolidado.CantidadSAPDiferentes = item.CantidadSAPDiferentes;
                consolidado.NumeroRepeticionesSAP = item.NumeroRepeticionesSAP;
                consolidado.IdTactica = item.IdTactica;
                consolidado.TipoOferta = item.TipoOferta;
                consolidado.UsuarioCreacion = item.UsuarioCreacion;
                consolidado.FechaCreacion = item.FechaCreacion;
                consolidado.UsuarioModificacion = item.UsuarioModificacion;
                consolidado.FechaModificacion = item.FechaModificacion;
                consolidado.IdArgumento = item.IdArgumento;

                //consolidado.Pais = item.Pais;


                lstConsolidado.Add(consolidado);
            }


            return Json(new DataTablesResponse(requestModel.Draw, lstConsolidado, filteredCount, totalCount), JsonRequestBehavior.AllowGet);

        }




        // GET: Consolidado/Details/5
        //public ActionResult Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Consolidado consolidado = db.Consolidado.Find(id);
        //    if (consolidado == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(consolidado);
        //}

        public ActionResult Details(long? id)
        {
            
            Consolidado consolidado = db.Consolidado.Find(id);
            ConsolidadoView consolidadoView = MapToViewModel(consolidado);

            //consolidadoView.CampanaSelectList = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion");
            //consolidadoView.CampanaSelectList1 = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion");
            //consolidadoView.PaisSelectList = new SelectList(db.Pais, "IdPais", "Descripcion");
            //consolidadoView.PalancaSelectList = new SelectList(db.Palanca, "IdPalanca", "Descripcion");

            if (Request.IsAjaxRequest())
                return PartialView("Details", consolidadoView);

            return View(consolidadoView);
        }

        // GET: Consolidado/Create
        public ActionResult Create()
        {
            //ViewBag.IdCampanaPlaneacion = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion");
            //ViewBag.IdCampanaProceso = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion");
            //ViewBag.IdPais = new SelectList(db.Pais, "IdPais", "Descripcion");
            //ViewBag.IdPalanca = new SelectList(db.Palanca, "IdPalanca", "Descripcion");
            //return View();
            var model = new ConsolidadoView();
            model.CampanaSelectList = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion");
            model.CampanaSelectList1 = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion");
            model.PaisSelectList = new SelectList(db.Pais, "IdPais", "Descripcion");
            model.PalancaSelectList = new SelectList(db.Palanca, "IdPalanca", "Descripcion");

            return View("Create", model);
        }

        // POST: Consolidado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(ConsolidadoView consolidadoView)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Consolidado.Add(consolidado);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            //ViewBag.IdCampanaPlaneacion = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion", consolidado.IdCampanaPlaneacion);
            //ViewBag.IdCampanaProceso = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion", consolidado.IdCampanaProceso);
            //ViewBag.IdPais = new SelectList(db.Pais, "IdPais", "Descripcion", consolidado.IdPais);
            //ViewBag.IdPalanca = new SelectList(db.Palanca, "IdPalanca", "Descripcion", consolidado.IdPalanca);
            //return View(consolidado);




            consolidadoView.CampanaSelectList = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion");
            consolidadoView.CampanaSelectList1 = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion");
            consolidadoView.PaisSelectList = new SelectList(db.Pais, "IdPais", "Descripcion");
            consolidadoView.PalancaSelectList = new SelectList(db.Palanca, "IdPalanca", "Descripcion");


            //if (!ModelState.IsValid)
            //    return View("Create", consolidadoView);

            Consolidado consolidado = MaptoModel(consolidadoView);

            db.Consolidado.Add(consolidado);

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                //throw;
            }
            


            return Content("success");
        }

        // GET: Consolidado/Edit/5
        public ActionResult Edit(long? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Consolidado consolidado = db.Consolidado.Find(id);
            //if (consolidado == null)
            //{
            //    return HttpNotFound();
            //}
            //ViewBag.IdCampanaPlaneacion = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion", consolidado.IdCampanaPlaneacion);
            //ViewBag.IdCampanaProceso = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion", consolidado.IdCampanaProceso);
            //ViewBag.IdPais = new SelectList(db.Pais, "IdPais", "Descripcion", consolidado.IdPais);
            //ViewBag.IdPalanca = new SelectList(db.Palanca, "IdPalanca", "Descripcion", consolidado.IdPalanca);
            //return View(consolidado);


            var consolidado = db.Consolidado.Find(id);

            ConsolidadoView consolidadoView = MapToViewModel(consolidado);

            if (Request.IsAjaxRequest())
                return PartialView("Edit", consolidadoView);
            return View(consolidadoView);

        }

        // POST: Consolidado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "IdConsolidado,IdCampanaPlaneacion,IdCampanaProceso,IdPalanca,UnidadesLimite,NumeroEspacios,IdPais,CuentaOfertas,Binomio,CUVPadre,CUV,CUCAntiguo,SAPAntiguo,BPCSGenericoAntiguo,BPCSTonoAntiguo,DescripcionGenericoAntiguo,DescripcionTonoAntiguo,Lanzamiento,CUC,SAP,BPCSGenerico,BPCSTono,IndicadorGratis,DescripcionSet,DescripcionProducto,DescripcionCatalogo,CompuestaVariable,NumeroGrupo,FactorCuadre,FlagTop,Tono,Marca,Categoria,Tipo,DescuentoSet,ReglaSet,GAPMNvsImpreso,GAPUSDvsImpreso,IndicadorCxC,FactoRepeticion,POUnitarioMN,POSetMN,PNSetMN,PNUnitarioMN,Unidades,P1,P2,P3,P4,P5,P6,P7,Comentario,CODP,NumeroProductosOferta,TipoPlan,IndicadorSubcampana,CantidadSAPDiferentes,NumeroRepeticionesSAP,IdTactica,TipoOferta,UsuarioCreacion,FechaCreacion,UsuarioModificacion,FechaModificacion,IdArgumento")] Consolidado consolidado)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(consolidado).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.IdCampanaPlaneacion = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion", consolidado.IdCampanaPlaneacion);
        //    ViewBag.IdCampanaProceso = new SelectList(db.Campana, "IdCampana", "UsuarioCreacion", consolidado.IdCampanaProceso);
        //    ViewBag.IdPais = new SelectList(db.Pais, "IdPais", "Descripcion", consolidado.IdPais);
        //    ViewBag.IdPalanca = new SelectList(db.Palanca, "IdPalanca", "Descripcion", consolidado.IdPalanca);
        //    return View(consolidado);
        //}

        [HttpPost]
        public ActionResult Edit(ConsolidadoView consolidadoView)
        {

            consolidadoView.CampanaSelectList = GetCampanaSelectList(consolidadoView.IdCampanaPlaneacion);
            consolidadoView.CampanaSelectList1 = GetCampanaSelectList1(consolidadoView.IdCampanaProceso);
            consolidadoView.PaisSelectList = GetPaisSelectList(consolidadoView.IdPais);
            consolidadoView.PalancaSelectList = GetPaisSelectList(consolidadoView.IdPalanca);

            if (!ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return View(Request.IsAjaxRequest() ? "Edit" : "Edit", consolidadoView);
            }

            Consolidado consolidado = MaptoModel(consolidadoView);

            db.Consolidado.Attach(consolidado);
            db.Entry(consolidado).State = EntityState.Modified;
            db.SaveChanges();

            if (Request.IsAjaxRequest())
            {
                return Content("success");
            }

            return RedirectToAction("Index");
        }


        // GET: Consolidado/Delete/5
        //public ActionResult Delete(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Consolidado consolidado = db.Consolidado.Find(id);
        //    if (consolidado == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(consolidado);
        //}

        public ActionResult Delete(long? id)
        {
            Consolidado consolidado = db.Consolidado.Find(id);

            ConsolidadoView ConsolidadoView = MapToViewModel(consolidado);

            if (Request.IsAjaxRequest())
                return PartialView("Delete", ConsolidadoView);
            return View(ConsolidadoView);
        }




        //// POST: Consolidado/Delete/5
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(ConsolidadoView consolidadoView)
        //{
        //    var id = consolidadoView.IdConsolidado;
        //    Consolidado consolidado = db.Consolidado.Find(id);
        //    db.Consolidado.Remove(consolidado);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        // POST: Consolidado/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteAsset(ConsolidadoView consolidadoView)
        {
            var consolidado = new Consolidado { IdConsolidado = consolidadoView.IdConsolidado };
            db.Consolidado.Attach(consolidado);
            db.Consolidado.Remove(consolidado);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                
            }
            
            if (Request.IsAjaxRequest())
            {
                return Content("success");
            }
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        private ConsolidadoView MapToViewModel(Consolidado item)
        {

            var Camapana = db.Campana.Where(x => x.IdCampana == item.IdCampanaPlaneacion).FirstOrDefault();
            var Camapana1 = db.Campana.Where(x => x.IdCampana == item.IdCampanaProceso).FirstOrDefault();
            var PaisSelectList = db.Pais.Where(x => x.IdPais == item.IdPais).FirstOrDefault();
            var PalancaSelectList = db.Palanca.Where(x => x.IdPalanca == item.IdPalanca).FirstOrDefault();

            ConsolidadoView consolidadoView = new ConsolidadoView()
            {
                IdConsolidado = item.IdConsolidado,
                IdCampanaPlaneacion = item.IdCampanaPlaneacion,
                IdCampanaProceso = item.IdCampanaProceso,
                IdPalanca = item.IdPalanca,
                UnidadesLimite = item.UnidadesLimite,
                NumeroEspacios = item.NumeroEspacios,
                IdPais = item.IdPais,
                CuentaOfertas = item.CuentaOfertas,
                Binomio = item.Binomio,
                CUVPadre = item.CUVPadre,
                CUV = item.CUV,
                CUCAntiguo = item.CUCAntiguo,
                SAPAntiguo = item.SAPAntiguo,
                BPCSGenericoAntiguo = item.BPCSGenericoAntiguo,
                BPCSTonoAntiguo = item.BPCSTonoAntiguo,
                DescripcionGenericoAntiguo = item.DescripcionGenericoAntiguo,
                DescripcionTonoAntiguo = item.DescripcionTonoAntiguo,
                Lanzamiento = item.Lanzamiento,
                CUC = item.CUC,
                SAP = item.SAP,
                BPCSGenerico = item.BPCSGenerico,
                BPCSTono = item.BPCSTono,
                IndicadorGratis = item.IndicadorGratis,
                DescripcionSet = item.DescripcionSet,
                DescripcionProducto = item.DescripcionProducto,
                DescripcionCatalogo = item.DescripcionCatalogo,
                CompuestaVariable = item.CompuestaVariable,
                NumeroGrupo = item.NumeroGrupo,
                FactorCuadre = item.FactorCuadre,
                FlagTop = item.FlagTop,
                Tono = item.Tono,
                Marca = item.Marca,
                Categoria = item.Categoria,
                Tipo = item.Tipo,
                DescuentoSet = item.DescuentoSet,
                ReglaSet = item.ReglaSet,
                GAPMNvsImpreso = item.GAPMNvsImpreso,
                GAPUSDvsImpreso = item.GAPUSDvsImpreso,
                IndicadorCxC = item.IndicadorCxC,
                FactoRepeticion = item.FactoRepeticion,
                POUnitarioMN = item.POUnitarioMN,
                POSetMN = item.POSetMN,
                PNSetMN = item.PNSetMN,
                PNUnitarioMN = item.PNUnitarioMN,
                Unidades = item.Unidades,
                P1 = item.P1,
                P2 = item.P2,
                P3 = item.P3,
                P4 = item.P4,
                P5 = item.P5,
                P6 = item.P6,
                P7 = item.P7,
                Comentario = item.Comentario,
                CODP = item.CODP,
                NumeroProductosOferta = item.NumeroProductosOferta,
                TipoPlan = item.TipoPlan,
                IndicadorSubcampana = item.IndicadorSubcampana,
                CantidadSAPDiferentes = item.CantidadSAPDiferentes,
                NumeroRepeticionesSAP = item.NumeroRepeticionesSAP,
                IdTactica = item.IdTactica,
                TipoOferta = item.TipoOferta,
                UsuarioCreacion = item.UsuarioCreacion,
                FechaCreacion = item.FechaCreacion,
                UsuarioModificacion = item.UsuarioModificacion,
                FechaModificacion = item.FechaModificacion,
                IdArgumento = item.IdArgumento,


                CampanaSelectList = new SelectList(db.Campana
                                           .Select(x => new { x.IdCampana, x.UsuarioCreacion }),
                                             "IdCampana",
                                             "IdCampana", item.IdCampanaPlaneacion),


                CampanaSelectList1 = new SelectList(db.Campana
                                           .Select(x => new { x.IdCampana, x.UsuarioCreacion }),
                                             "IdCampana",
                                             "IdCampana", item.IdCampanaProceso),

                PaisSelectList = new SelectList(db.Pais
                                           .Select(x => new { x.IdPais, x.Descripcion }),
                                             "IdPais",
                                             "Descripcion", item.IdPais),

                PalancaSelectList = new SelectList(db.Palanca
                                           .Select(x => new { x.IdPalanca, x.Descripcion }),
                                             "IdPalanca",
                                             "Descripcion", item.IdPalanca)
,


            };

            return consolidadoView;
        }

        private Consolidado MaptoModel(ConsolidadoView item)
        {
            Consolidado asset = new Consolidado()
            {
                IdConsolidado = item.IdConsolidado,
                IdCampanaPlaneacion = item.IdCampanaPlaneacion,
                IdCampanaProceso = item.IdCampanaProceso,
                IdPalanca = item.IdPalanca,
                UnidadesLimite = item.UnidadesLimite,
                NumeroEspacios = item.NumeroEspacios,
                IdPais = item.IdPais,
                CuentaOfertas = item.CuentaOfertas,
                Binomio = item.Binomio,
                CUVPadre = item.CUVPadre,
                CUV = item.CUV,
                CUCAntiguo = item.CUCAntiguo,
                SAPAntiguo = item.SAPAntiguo,
                BPCSGenericoAntiguo = item.BPCSGenericoAntiguo,
                BPCSTonoAntiguo = item.BPCSTonoAntiguo,
                DescripcionGenericoAntiguo = item.DescripcionGenericoAntiguo,
                DescripcionTonoAntiguo = item.DescripcionTonoAntiguo,
                Lanzamiento = item.Lanzamiento,
                CUC = item.CUC,
                SAP = item.SAP,
                BPCSGenerico = item.BPCSGenerico,
                BPCSTono = item.BPCSTono,
                IndicadorGratis = item.IndicadorGratis,
                DescripcionSet = item.DescripcionSet,
                DescripcionProducto = item.DescripcionProducto,
                DescripcionCatalogo = item.DescripcionCatalogo,
                CompuestaVariable = item.CompuestaVariable,
                NumeroGrupo = item.NumeroGrupo,
                FactorCuadre = item.FactorCuadre,
                FlagTop = item.FlagTop,
                Tono = item.Tono,
                Marca = item.Marca,
                Categoria = item.Categoria,
                Tipo = item.Tipo,
                DescuentoSet = item.DescuentoSet,
                ReglaSet = item.ReglaSet,
                GAPMNvsImpreso = item.GAPMNvsImpreso,
                GAPUSDvsImpreso = item.GAPUSDvsImpreso,
                IndicadorCxC = item.IndicadorCxC,
                FactoRepeticion = item.FactoRepeticion,
                POUnitarioMN = item.POUnitarioMN,
                POSetMN = item.POSetMN,
                PNSetMN = item.PNSetMN,
                PNUnitarioMN = item.PNUnitarioMN,
                Unidades = item.Unidades,
                P1 = item.P1,
                P2 = item.P2,
                P3 = item.P3,
                P4 = item.P4,
                P5 = item.P5,
                P6 = item.P6,
                P7 = item.P7,
                Comentario = item.Comentario,
                CODP = item.CODP,
                NumeroProductosOferta = item.NumeroProductosOferta,
                TipoPlan = item.TipoPlan,
                IndicadorSubcampana = item.IndicadorSubcampana,
                CantidadSAPDiferentes = item.CantidadSAPDiferentes,
                NumeroRepeticionesSAP = item.NumeroRepeticionesSAP,
                IdTactica = item.IdTactica,
                TipoOferta = item.TipoOferta,
                UsuarioCreacion = item.UsuarioCreacion,
                FechaCreacion = item.FechaCreacion,
                UsuarioModificacion = item.UsuarioModificacion,
                FechaModificacion = item.FechaModificacion,
                IdArgumento = item.IdArgumento
            };

            return asset;
        }


        private SelectList GetCampanaSelectList(object selectedValue = null)
        {
            return new SelectList(db.Campana
                                           .Select(x => new { x.IdCampana, x.UsuarioCreacion }),
                                             "IdCampana",
                                             "IdCampana", selectedValue);
        }

        private SelectList GetCampanaSelectList1(object selectedValue = null)
        {
            return new SelectList(db.Campana
                                           .Select(x => new { x.IdCampana, x.UsuarioCreacion }),
                                             "IdCampana",
                                             "IdCampana", selectedValue);
        }

        private SelectList GetPaisSelectList(object selectedValue = null)
        {
            return new SelectList(db.Pais
                                           .Select(x => new { x.IdPais, x.Descripcion }),
                                             "IdPais",
                                             "Descripcion", selectedValue);
        }

        private SelectList GetPalancaSelectList(object selectedValue = null)
        {
            return new SelectList(db.Palanca
                                           .Select(x => new { x.IdPalanca, x.Descripcion }),
                                             "IdPalanca",
                                             "Descripcion", selectedValue);
        }


        // POST: Consolidado/Exportar
        [HttpGet]
        public void Exportar()
        {
            IQueryable<Consolidado> query = db.Consolidado.Include(c => c.Campana).Include(c => c.Campana1).Include(c => c.Pais).Include(c => c.Palanca);

            List<Consolidado> lstConsolidado = new List<Consolidado>();
            foreach (var item in query)
            {
                Consolidado consolidado = new Consolidado();
                consolidado.IdConsolidado = item.IdConsolidado;
                consolidado.IdCampanaPlaneacion = item.IdCampanaPlaneacion;
                consolidado.IdCampanaProceso = item.IdCampanaProceso;
                consolidado.IdPalanca = item.IdPalanca;
                consolidado.UnidadesLimite = item.UnidadesLimite;
                consolidado.NumeroEspacios = item.NumeroEspacios;
                consolidado.IdPais = item.IdPais;
                consolidado.CuentaOfertas = item.CuentaOfertas;
                consolidado.Binomio = item.Binomio;
                consolidado.CUVPadre = item.CUVPadre;
                consolidado.CUV = item.CUV;
                consolidado.CUCAntiguo = item.CUCAntiguo;
                consolidado.SAPAntiguo = item.SAPAntiguo;
                consolidado.BPCSGenericoAntiguo = item.BPCSGenericoAntiguo;
                consolidado.BPCSTonoAntiguo = item.BPCSTonoAntiguo;
                consolidado.DescripcionGenericoAntiguo = item.DescripcionGenericoAntiguo;
                consolidado.DescripcionTonoAntiguo = item.DescripcionTonoAntiguo;
                consolidado.Lanzamiento = item.Lanzamiento;
                consolidado.CUC = item.CUC;
                consolidado.SAP = item.SAP;
                consolidado.BPCSGenerico = item.BPCSGenerico;
                consolidado.BPCSTono = item.BPCSTono;
                consolidado.IndicadorGratis = item.IndicadorGratis;
                consolidado.DescripcionSet = item.DescripcionSet;
                consolidado.DescripcionProducto = item.DescripcionProducto;
                consolidado.DescripcionCatalogo = item.DescripcionCatalogo;
                consolidado.CompuestaVariable = item.CompuestaVariable;
                consolidado.NumeroGrupo = item.NumeroGrupo;
                consolidado.FactorCuadre = item.FactorCuadre;
                consolidado.FlagTop = item.FlagTop;
                consolidado.Tono = item.Tono;
                consolidado.Marca = item.Marca;
                consolidado.Categoria = item.Categoria;
                consolidado.Tipo = item.Tipo;
                consolidado.DescuentoSet = item.DescuentoSet;
                consolidado.ReglaSet = item.ReglaSet;
                consolidado.GAPMNvsImpreso = item.GAPMNvsImpreso;
                consolidado.GAPUSDvsImpreso = item.GAPUSDvsImpreso;
                consolidado.IndicadorCxC = item.IndicadorCxC;
                consolidado.FactoRepeticion = item.FactoRepeticion;
                consolidado.POUnitarioMN = item.POUnitarioMN;
                consolidado.POSetMN = item.POSetMN;
                consolidado.PNSetMN = item.PNSetMN;
                consolidado.PNUnitarioMN = item.PNUnitarioMN;
                consolidado.Unidades = item.Unidades;
                consolidado.P1 = item.P1;
                consolidado.P2 = item.P2;
                consolidado.P3 = item.P3;
                consolidado.P4 = item.P4;
                consolidado.P5 = item.P5;
                consolidado.P6 = item.P6;
                consolidado.P7 = item.P7;
                consolidado.Comentario = item.Comentario;
                consolidado.CODP = item.CODP;
                consolidado.NumeroProductosOferta = item.NumeroProductosOferta;
                consolidado.TipoPlan = item.TipoPlan;
                consolidado.IndicadorSubcampana = item.IndicadorSubcampana;
                consolidado.CantidadSAPDiferentes = item.CantidadSAPDiferentes;
                consolidado.NumeroRepeticionesSAP = item.NumeroRepeticionesSAP;
                consolidado.IdTactica = item.IdTactica;
                consolidado.TipoOferta = item.TipoOferta;
                consolidado.UsuarioCreacion = item.UsuarioCreacion;
                consolidado.FechaCreacion = item.FechaCreacion;
                consolidado.UsuarioModificacion = item.UsuarioModificacion;
                consolidado.FechaModificacion = item.FechaModificacion;
                consolidado.IdArgumento = item.IdArgumento;
                lstConsolidado.Add(consolidado);
            }


            DataTable dt = ToDataTable(lstConsolidado);

            dt.ToExcel("Consolidado");
        }
        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            Type Propiedad = null;
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                Propiedad = prop.PropertyType;
                if (Propiedad.IsGenericType && Propiedad.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    Propiedad = Nullable.GetUnderlyingType(Propiedad);
                }
                table.Columns.Add(prop.Name, Propiedad);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }


        private IQueryable<Consolidado> SearchConsolidado(IDataTablesRequest requestModel, BusquedaConsolidado searchViewModel, IQueryable<Consolidado> query)
        {

            // Apply filters
            if (requestModel.Search.Value != string.Empty)
            {
                var value = requestModel.Search.Value.Trim();
                query = query.Where(p => p.CUVPadre.Contains(value) ||
                                         p.CUV.Contains(value) ||
                                         p.CUCAntiguo.Contains(value) ||
                                         p.SAPAntiguo.Contains(value) ||
                                         p.BPCSGenericoAntiguo.Contains(value) ||
                                         p.BPCSTonoAntiguo.Contains(value) ||
                                         p.DescripcionGenericoAntiguo.Contains(value) ||
                                         p.DescripcionTonoAntiguo.Contains(value) ||
                                         p.CUC.Contains(value) ||
                                         p.SAP.Contains(value) ||
                                         p.BPCSGenerico.Contains(value) ||
                                         p.BPCSTono.Contains(value) ||
                                         p.DescripcionSet.Contains(value) ||
                                         p.DescripcionProducto.Contains(value) ||
                                         p.DescripcionCatalogo.Contains(value) ||
                                         p.Tono.Contains(value) ||
                                         p.Marca.Contains(value) ||
                                         p.Categoria.Contains(value) ||
                                         p.CODP.Contains(value) ||
                                         p.TipoPlan.Contains(value) 
                                   );
            }

            /***** Advanced Search ******/
            if (searchViewModel.IdPalanca != null)
                query = query.Where(x => x.IdPalanca == searchViewModel.IdPalanca);

            if (searchViewModel.IdCampana != null)
                query = query.Where(x => x.IdCampanaPlaneacion == searchViewModel.IdCampana ||
                                         x.IdCampanaProceso == searchViewModel.IdCampana);

            if (searchViewModel.IdPais != null)
                query = query.Where(x => x.IdPais == searchViewModel.IdPais);


            if (searchViewModel.CuentaOfertas != null)
            {
                query = query.Where(x => x.CuentaOfertas.ToString().Contains(searchViewModel.CuentaOfertas));
            }
            
            if (searchViewModel.IdTipoOferta != null)
            {
                query = query.Where(x => x.TipoOferta == searchViewModel.IdTipoOferta);
            }

            if (searchViewModel.CUC != null)
            {
                query = query.Where(x => x.CUC.Contains(searchViewModel.CUC));
            }

            if (searchViewModel.SAP != null)
            {
                query = query.Where(x => x.SAP.Contains(searchViewModel.SAP));
            }

            /***** Advanced Search ******/

            var filteredCount = query.Count();

            // Sort
            var sortedColumns = requestModel.Columns.GetSortedColumns();
            var orderByString = String.Empty;

            foreach (var column in sortedColumns)
            {
                orderByString += orderByString != String.Empty ? "," : "";
                orderByString += (column.Data) + (column.SortDirection == Column.OrderDirection.Ascendant ? " asc" : " desc");
            }

            query = query.OrderBy(orderByString == String.Empty ? "IdConsolidado asc" : orderByString);




            return query;

        }




        [HttpGet]
        public ActionResult AdvancedSearch()
        {
            var BusquedaConsolidado = new BusquedaConsolidado();

            BusquedaConsolidado.PalancaList = new SelectList(db.Palanca
                                                                    .Select(x => new { x.IdPalanca, x.Abreviatura }),
                                                                      "IdPalanca",
                                                                      "Abreviatura");

            BusquedaConsolidado.CampanaList = new SelectList(db.Campana
                                                                    .Select(x => new { x.IdCampana, x.UsuarioCreacion }),
                                                                      "IdCampana",
                                                                      "IdCampana");

            BusquedaConsolidado.PaisList = new SelectList(db.Pais
                                                                    .Select(x => new { x.IdPais, x.Descripcion }),
                                                                      "IdPais",
                                                                      "Descripcion");


            BusquedaConsolidado.TipoOfertaList = new SelectList(db.TipoOferta
                                                                .Select(x => new { x.Valor }).Distinct(),
                                                                "Valor",
                                                                "Valor");

            return View("BusquedaConsolidado", BusquedaConsolidado);
        }
    }
}
