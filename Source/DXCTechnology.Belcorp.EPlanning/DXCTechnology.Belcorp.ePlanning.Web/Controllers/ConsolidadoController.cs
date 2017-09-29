using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DXCTechnology.Belcorp.ePlanning.Web.Models;
using DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;
using DataTables.Mvc;
using System.Reflection;
using DXCTechnology.Belcorp.ePlanning.Utils.Extensions;
using System.ComponentModel;

namespace DXCTechnology.Belcorp.ePlanning.Web.Controllers
{
    public class ConsolidadoController : Controller
    {
        //private ePlanningDBEntities db = new ePlanningDBEntities();

        // GET: Consolidado
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Get([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, AdvancedSearchViewModel searchViewModel)
        {
            // Carga de Datos
            BL_Consolidado objConsolidado = new BL_Consolidado();
            ConsolidadoModel entConsolidadoModel = new ConsolidadoModel();
            entConsolidadoModel.PageSize = 3000;
            entConsolidadoModel.PageIndex = 1;
            List<ConsolidadoModel> lstConsolidado = objConsolidado.SelectAll(entConsolidadoModel);
            List<Consolidado> Consolidado = new List<Consolidado>();
            foreach (ConsolidadoModel entConsolidado in lstConsolidado)
            {
                Consolidado consolidado = new Consolidado();
                consolidado.IdConsolidado = entConsolidado.IdConsolidado;
                consolidado.IdCampanaPlaneacion = entConsolidado.IdCampanaPlaneacion;
                consolidado.IdCampanaProceso = entConsolidado.IdCampanaProceso;
                consolidado.IdPalanca = entConsolidado.IdPalanca;
                consolidado.UnidadesLimite = entConsolidado.UnidadesLimite;
                consolidado.NumeroEspacios = entConsolidado.NumeroEspacios;
                consolidado.IdPais = entConsolidado.IdPais;
                consolidado.CuentaOfertas = entConsolidado.CuentaOfertas;
                consolidado.Binomio = entConsolidado.Binomio;
                consolidado.CUVPadre = entConsolidado.CUVPadre;
                consolidado.CUV = entConsolidado.CUV;
                consolidado.CUCAntiguo = entConsolidado.CUCAntiguo;
                consolidado.SAPAntiguo = entConsolidado.SAPAntiguo;
                consolidado.BPCSGenericoAntiguo = entConsolidado.BPCSGenericoAntiguo;
                consolidado.BPCSTonoAntiguo = entConsolidado.BPCSTonoAntiguo;
                consolidado.DescripcionGenericoAntiguo = entConsolidado.DescripcionGenericoAntiguo;
                consolidado.DescripcionTonoAntiguo = entConsolidado.DescripcionTonoAntiguo;
                consolidado.Lanzamiento = entConsolidado.Lanzamiento;
                consolidado.CUC = entConsolidado.CUC;
                consolidado.SAP = entConsolidado.SAP;
                consolidado.BPCSGenerico = entConsolidado.BPCSGenerico;
                consolidado.BPCSTono = entConsolidado.BPCSTono;
                consolidado.IndicadorGratis = entConsolidado.IndicadorGratis;
                consolidado.DescripcionSet = entConsolidado.DescripcionSet;
                consolidado.DescripcionProducto = entConsolidado.DescripcionProducto;
                consolidado.DescripcionCatalogo = entConsolidado.DescripcionCatalogo;
                consolidado.CompuestaVariable = entConsolidado.CompuestaVariable;
                consolidado.NumeroGrupo = entConsolidado.NumeroGrupo;
                consolidado.FactorCuadre = entConsolidado.FactorCuadre;
                consolidado.FlagTop = entConsolidado.FlagTop;
                consolidado.Tono = entConsolidado.Tono;
                consolidado.Marca = entConsolidado.Marca;
                consolidado.Categoria = entConsolidado.Categoria;
                consolidado.Tipo = entConsolidado.Tipo;
                consolidado.DescuentoSet = entConsolidado.DescuentoSet;
                consolidado.ReglaSet = entConsolidado.ReglaSet;
                consolidado.GAPMNvsImpreso = entConsolidado.GAPMNvsImpreso;
                consolidado.GAPUSDvsImpreso = entConsolidado.GAPUSDvsImpreso;
                consolidado.IndicadorCxC = entConsolidado.IndicadorCxC;
                consolidado.FactoRepeticion = entConsolidado.FactoRepeticion;
                consolidado.POUnitarioMN = entConsolidado.POUnitarioMN;
                consolidado.POSetMN = entConsolidado.POSetMN;
                consolidado.PNSetMN = entConsolidado.PNSetMN;
                consolidado.PNUnitarioMN = entConsolidado.PNUnitarioMN;
                consolidado.Unidades = entConsolidado.Unidades;
                consolidado.P1 = entConsolidado.P1;
                consolidado.P2 = entConsolidado.P2;
                consolidado.P3 = entConsolidado.P3;
                consolidado.P4 = entConsolidado.P4;
                consolidado.P5 = entConsolidado.P5;
                consolidado.P6 = entConsolidado.P6;
                consolidado.P7 = entConsolidado.P7;
                consolidado.Comentario = entConsolidado.Comentario;
                consolidado.CODP = entConsolidado.CODP;
                consolidado.NumeroProductosOferta = entConsolidado.NumeroProductosOferta;
                consolidado.TipoPlan = entConsolidado.TipoPlan;
                consolidado.IndicadorSubcampana = entConsolidado.IndicadorSubcampana;
                consolidado.CantidadSAPDiferentes = entConsolidado.CantidadSAPDiferentes;
                consolidado.NumeroRepeticionesSAP = entConsolidado.NumeroRepeticionesSAP;
                consolidado.TipoOferta = entConsolidado.TipoOferta;
                consolidado.UsuarioCreacion = entConsolidado.UsuarioCreacion;
                consolidado.FechaCreacion = entConsolidado.FechaCreacion;
                consolidado.UsuarioModificacion = entConsolidado.UsuarioModificacion;
                consolidado.FechaModificacion = entConsolidado.FechaModificacion;
                Consolidado.Add(consolidado);
            }



            var totalCount = Consolidado.Count();

            // searching and sorting
            //query = SearchAssets(requestModel, searchViewModel, query);
            var filteredCount = Consolidado.Count();

            // Paging
            Consolidado = Consolidado.Skip(requestModel.Start).Take(requestModel.Length).ToList();



            //var data = query.Select(asset => new
            //{
            //    AssetID = asset.AssetID,
            //    BarCode = asset.Barcode,
            //    Manufacturer = asset.Manufacturer,
            //    ModelNumber = asset.ModelNumber,
            //    Building = asset.Building,
            //    RoomNo = asset.RoomNo,
            //    Quantity = asset.Quantity
            //}).ToList();

            return Json(new DataTablesResponse(requestModel.Draw, Consolidado, filteredCount, totalCount), JsonRequestBehavior.AllowGet);

        }

        // GET: Consolidado/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consolidado consolidado = new Consolidado();
            BL_Consolidado objConsolidado = new BL_Consolidado();
            ConsolidadoModel entConsolidado = new ConsolidadoModel();
            entConsolidado = objConsolidado.Select(id);
            consolidado.IdConsolidado = entConsolidado.IdConsolidado;
            consolidado.IdCampanaPlaneacion = entConsolidado.IdCampanaPlaneacion;
            consolidado.IdCampanaProceso = entConsolidado.IdCampanaProceso;
            consolidado.IdPalanca = entConsolidado.IdPalanca;
            consolidado.UnidadesLimite = entConsolidado.UnidadesLimite;
            consolidado.NumeroEspacios = entConsolidado.NumeroEspacios;
            consolidado.IdPais = entConsolidado.IdPais;
            consolidado.CuentaOfertas = entConsolidado.CuentaOfertas;
            consolidado.Binomio = entConsolidado.Binomio;
            consolidado.CUVPadre = entConsolidado.CUVPadre;
            consolidado.CUV = entConsolidado.CUV;
            consolidado.CUCAntiguo = entConsolidado.CUCAntiguo;
            consolidado.SAPAntiguo = entConsolidado.SAPAntiguo;
            consolidado.BPCSGenericoAntiguo = entConsolidado.BPCSGenericoAntiguo;
            consolidado.BPCSTonoAntiguo = entConsolidado.BPCSTonoAntiguo;
            consolidado.DescripcionGenericoAntiguo = entConsolidado.DescripcionGenericoAntiguo;
            consolidado.DescripcionTonoAntiguo = entConsolidado.DescripcionTonoAntiguo;
            consolidado.Lanzamiento = entConsolidado.Lanzamiento;
            consolidado.CUC = entConsolidado.CUC;
            consolidado.SAP = entConsolidado.SAP;
            consolidado.BPCSGenerico = entConsolidado.BPCSGenerico;
            consolidado.BPCSTono = entConsolidado.BPCSTono;
            consolidado.IndicadorGratis = entConsolidado.IndicadorGratis;
            consolidado.DescripcionSet = entConsolidado.DescripcionSet;
            consolidado.DescripcionProducto = entConsolidado.DescripcionProducto;
            consolidado.DescripcionCatalogo = entConsolidado.DescripcionCatalogo;
            consolidado.CompuestaVariable = entConsolidado.CompuestaVariable;
            consolidado.NumeroGrupo = entConsolidado.NumeroGrupo;
            consolidado.FactorCuadre = entConsolidado.FactorCuadre;
            consolidado.FlagTop = entConsolidado.FlagTop;
            consolidado.Tono = entConsolidado.Tono;
            consolidado.Marca = entConsolidado.Marca;
            consolidado.Categoria = entConsolidado.Categoria;
            consolidado.Tipo = entConsolidado.Tipo;
            consolidado.DescuentoSet = entConsolidado.DescuentoSet;
            consolidado.ReglaSet = entConsolidado.ReglaSet;
            consolidado.GAPMNvsImpreso = entConsolidado.GAPMNvsImpreso;
            consolidado.GAPUSDvsImpreso = entConsolidado.GAPUSDvsImpreso;
            consolidado.IndicadorCxC = entConsolidado.IndicadorCxC;
            consolidado.FactoRepeticion = entConsolidado.FactoRepeticion;
            consolidado.POUnitarioMN = entConsolidado.POUnitarioMN;
            consolidado.POSetMN = entConsolidado.POSetMN;
            consolidado.PNSetMN = entConsolidado.PNSetMN;
            consolidado.PNUnitarioMN = entConsolidado.PNUnitarioMN;
            consolidado.Unidades = entConsolidado.Unidades;
            consolidado.P1 = entConsolidado.P1;
            consolidado.P2 = entConsolidado.P2;
            consolidado.P3 = entConsolidado.P3;
            consolidado.P4 = entConsolidado.P4;
            consolidado.P5 = entConsolidado.P5;
            consolidado.P6 = entConsolidado.P6;
            consolidado.P7 = entConsolidado.P7;
            consolidado.Comentario = entConsolidado.Comentario;
            consolidado.CODP = entConsolidado.CODP;
            consolidado.NumeroProductosOferta = entConsolidado.NumeroProductosOferta;
            consolidado.TipoPlan = entConsolidado.TipoPlan;
            consolidado.IndicadorSubcampana = entConsolidado.IndicadorSubcampana;
            consolidado.CantidadSAPDiferentes = entConsolidado.CantidadSAPDiferentes;
            consolidado.NumeroRepeticionesSAP = entConsolidado.NumeroRepeticionesSAP;
            consolidado.UsuarioCreacion = entConsolidado.UsuarioCreacion;
            consolidado.FechaCreacion = entConsolidado.FechaCreacion;
            consolidado.UsuarioModificacion = entConsolidado.UsuarioModificacion;
            consolidado.FechaModificacion = entConsolidado.FechaModificacion;
            if (consolidado == null)
            {
                return HttpNotFound();
            }
            return View(consolidado);
        }

        // GET: Consolidado/Create
        public ActionResult Create()
        {

            BL_Campana objCampana = new BL_Campana();
            CampanaModel Campana = new CampanaModel();
            Campana.PageSize = 100;
            Campana.PageIndex = 1;
            List<CampanaModel> lstCampanaPlaneacion = objCampana.SelectAll(Campana);
            List<CampanaModel> lstCampanaProceso = objCampana.SelectAll(Campana);

            BL_Pais objPais = new BL_Pais();
            PaisModel Pais = new PaisModel();
            Pais.PageSize = 100;
            Pais.PageIndex = 1;
            List<PaisModel> lstPais = objPais.SelectAll(Pais);

            BL_Palanca objPalanca = new BL_Palanca();
            PalancaModel Palanca = new PalancaModel();
            Palanca.PageSize = 100;
            Palanca.PageIndex = 1;
            List<PalancaModel> lstPalanca = objPalanca.SelectAll(Palanca);

            ViewBag.IdCampanaPlaneacion = new SelectList(lstCampanaPlaneacion, "IdCampana", "UsuarioCreacion");
            ViewBag.IdCampanaProceso = new SelectList(lstCampanaProceso, "IdCampana", "UsuarioCreacion");
            ViewBag.IdPais = new SelectList(lstPais, "IdPais", "Descripcion");
            ViewBag.IdPalanca = new SelectList(lstPalanca, "IdPalanca", "Descripcion");
            return View();
        }

        // POST: Consolidado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdConsolidado,IdCampanaPlaneacion,IdCampanaProceso,IdPalanca,UnidadesLimite,NumeroEspacios,IdPais,CuentaOfertas,Binomio,CUVPadre,CUV,CUCAntiguo,SAPAntiguo,BPCSGenericoAntiguo,BPCSTonoAntiguo,DescripcionGenericoAntiguo,DescripcionTonoAntiguo,Lanzamiento,CUC,SAP,BPCSGenerico,BPCSTono,IndicadorGratis,DescripcionSet,DescripcionProducto,DescripcionCatalogo,CompuestaVariable,NumeroGrupo,FactorCuadre,FlagTop,Tono,Marca,Categoria,Tipo,DescuentoSet,ReglaSet,GAPMNvsImpreso,GAPUSDvsImpreso,IndicadorCxC,FactoRepeticion,POUnitarioMN,POSetMN,PNSetMN,PNUnitarioMN,Unidades,P1,P2,P3,P4,P5,P6,P7,Comentario,CODP,NumeroProductosOferta,TipoPlan,IndicadorSubcampana,CantidadSAPDiferentes,NumeroRepeticionesSAP,UsuarioCreacion,FechaCreacion,UsuarioModificacion,FechaModificacion")] Consolidado consolidado)
        {
            if (ModelState.IsValid)
            {
                BL_Consolidado objConsolidado = new BL_Consolidado();
                ConsolidadoModel entConsolidado = new ConsolidadoModel();
                entConsolidado.IdConsolidado = consolidado.IdConsolidado;
                entConsolidado.IdCampanaPlaneacion = consolidado.IdCampanaPlaneacion;
                entConsolidado.IdCampanaProceso = consolidado.IdCampanaProceso;
                entConsolidado.IdPalanca = consolidado.IdPalanca;
                entConsolidado.UnidadesLimite = consolidado.UnidadesLimite;
                entConsolidado.NumeroEspacios = consolidado.NumeroEspacios;
                entConsolidado.IdPais = consolidado.IdPais;
                entConsolidado.CuentaOfertas = consolidado.CuentaOfertas;
                entConsolidado.Binomio = consolidado.Binomio;
                entConsolidado.CUVPadre = consolidado.CUVPadre;
                entConsolidado.CUV = consolidado.CUV;
                entConsolidado.CUCAntiguo = consolidado.CUCAntiguo;
                entConsolidado.SAPAntiguo = consolidado.SAPAntiguo;
                entConsolidado.BPCSGenericoAntiguo = consolidado.BPCSGenericoAntiguo;
                entConsolidado.BPCSTonoAntiguo = consolidado.BPCSTonoAntiguo;
                entConsolidado.DescripcionGenericoAntiguo = consolidado.DescripcionGenericoAntiguo;
                entConsolidado.DescripcionTonoAntiguo = consolidado.DescripcionTonoAntiguo;
                entConsolidado.Lanzamiento = consolidado.Lanzamiento;
                entConsolidado.CUC = consolidado.CUC;
                entConsolidado.SAP = consolidado.SAP;
                entConsolidado.BPCSGenerico = consolidado.BPCSGenerico;
                entConsolidado.BPCSTono = consolidado.BPCSTono;
                entConsolidado.IndicadorGratis = consolidado.IndicadorGratis;
                entConsolidado.DescripcionSet = consolidado.DescripcionSet;
                entConsolidado.DescripcionProducto = consolidado.DescripcionProducto;
                entConsolidado.DescripcionCatalogo = consolidado.DescripcionCatalogo;
                entConsolidado.CompuestaVariable = consolidado.CompuestaVariable;
                entConsolidado.NumeroGrupo = consolidado.NumeroGrupo;
                entConsolidado.FactorCuadre = consolidado.FactorCuadre;
                entConsolidado.FlagTop = consolidado.FlagTop;
                entConsolidado.Tono = consolidado.Tono;
                entConsolidado.Marca = consolidado.Marca;
                entConsolidado.Categoria = consolidado.Categoria;
                entConsolidado.Tipo = consolidado.Tipo;
                entConsolidado.DescuentoSet = consolidado.DescuentoSet;
                entConsolidado.ReglaSet = consolidado.ReglaSet;
                entConsolidado.GAPMNvsImpreso = consolidado.GAPMNvsImpreso;
                entConsolidado.GAPUSDvsImpreso = consolidado.GAPUSDvsImpreso;
                entConsolidado.IndicadorCxC = consolidado.IndicadorCxC;
                entConsolidado.FactoRepeticion = consolidado.FactoRepeticion;
                entConsolidado.POUnitarioMN = consolidado.POUnitarioMN;
                entConsolidado.POSetMN = consolidado.POSetMN;
                entConsolidado.PNSetMN = consolidado.PNSetMN;
                entConsolidado.PNUnitarioMN = consolidado.PNUnitarioMN;
                entConsolidado.Unidades = consolidado.Unidades;
                entConsolidado.P1 = consolidado.P1;
                entConsolidado.P2 = consolidado.P2;
                entConsolidado.P3 = consolidado.P3;
                entConsolidado.P4 = consolidado.P4;
                entConsolidado.P5 = consolidado.P5;
                entConsolidado.P6 = consolidado.P6;
                entConsolidado.P7 = consolidado.P7;
                entConsolidado.Comentario = consolidado.Comentario;
                entConsolidado.CODP = consolidado.CODP;
                entConsolidado.NumeroProductosOferta = consolidado.NumeroProductosOferta;
                entConsolidado.TipoPlan = consolidado.TipoPlan;
                entConsolidado.IndicadorSubcampana = consolidado.IndicadorSubcampana;
                entConsolidado.CantidadSAPDiferentes = consolidado.CantidadSAPDiferentes;
                entConsolidado.NumeroRepeticionesSAP = consolidado.NumeroRepeticionesSAP;
                entConsolidado.TipoOferta = consolidado.TipoOferta;
                entConsolidado.UsuarioCreacion = consolidado.UsuarioCreacion;
                entConsolidado.FechaCreacion = consolidado.FechaCreacion;
                entConsolidado.UsuarioModificacion = consolidado.UsuarioModificacion;
                entConsolidado.FechaModificacion = consolidado.FechaModificacion;
                objConsolidado.Insert(entConsolidado);             
                return RedirectToAction("Index");
            }
            BL_Campana objCampana = new BL_Campana();
            CampanaModel Campana = new CampanaModel();
            Campana.PageSize = 100;
            Campana.PageIndex = 1;
            List<CampanaModel> lstCampanaPlaneacion = objCampana.SelectAll(Campana);
            List<CampanaModel> lstCampanaProceso = objCampana.SelectAll(Campana);

            BL_Pais objPais = new BL_Pais();
            PaisModel Pais = new PaisModel();
            Pais.PageSize = 100;
            Pais.PageIndex = 1;
            List<PaisModel> lstPais = objPais.SelectAll(Pais);

            BL_Palanca objPalanca = new BL_Palanca();
            PalancaModel Palanca = new PalancaModel();
            Palanca.PageSize = 100;
            Palanca.PageIndex = 1;
            List<PalancaModel> lstPalanca = objPalanca.SelectAll(Palanca);


            ViewBag.IdCampanaPlaneacion = new SelectList(lstCampanaPlaneacion, "IdCampana", "IdCampana", consolidado.IdCampanaPlaneacion);
            ViewBag.IdCampanaProceso = new SelectList(lstCampanaProceso, "IdCampana", "IdCampana", consolidado.IdCampanaProceso);
            ViewBag.IdPais = new SelectList(lstPais, "IdPais", "Descripcion", consolidado.IdPais);
            ViewBag.IdPalanca = new SelectList(lstPalanca, "IdPalanca", "Descripcion", consolidado.IdPalanca);
            return View(consolidado);
        }

        // GET: Consolidado/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consolidado consolidado = new Consolidado();
            BL_Consolidado objConsolidado = new BL_Consolidado();
            ConsolidadoModel entConsolidado = new ConsolidadoModel();
            entConsolidado = objConsolidado.Select(id);
            consolidado.IdConsolidado = entConsolidado.IdConsolidado;
            consolidado.IdCampanaPlaneacion = entConsolidado.IdCampanaPlaneacion;
            consolidado.IdCampanaProceso = entConsolidado.IdCampanaProceso;
            consolidado.IdPalanca = entConsolidado.IdPalanca;
            consolidado.UnidadesLimite = entConsolidado.UnidadesLimite;
            consolidado.NumeroEspacios = entConsolidado.NumeroEspacios;
            consolidado.IdPais = entConsolidado.IdPais;
            consolidado.CuentaOfertas = entConsolidado.CuentaOfertas;
            consolidado.Binomio = entConsolidado.Binomio;
            consolidado.CUVPadre = entConsolidado.CUVPadre;
            consolidado.CUV = entConsolidado.CUV;
            consolidado.CUCAntiguo = entConsolidado.CUCAntiguo;
            consolidado.SAPAntiguo = entConsolidado.SAPAntiguo;
            consolidado.BPCSGenericoAntiguo = entConsolidado.BPCSGenericoAntiguo;
            consolidado.BPCSTonoAntiguo = entConsolidado.BPCSTonoAntiguo;
            consolidado.DescripcionGenericoAntiguo = entConsolidado.DescripcionGenericoAntiguo;
            consolidado.DescripcionTonoAntiguo = entConsolidado.DescripcionTonoAntiguo;
            consolidado.Lanzamiento = entConsolidado.Lanzamiento;
            consolidado.CUC = entConsolidado.CUC;
            consolidado.SAP = entConsolidado.SAP;
            consolidado.BPCSGenerico = entConsolidado.BPCSGenerico;
            consolidado.BPCSTono = entConsolidado.BPCSTono;
            consolidado.IndicadorGratis = entConsolidado.IndicadorGratis;
            consolidado.DescripcionSet = entConsolidado.DescripcionSet;
            consolidado.DescripcionProducto = entConsolidado.DescripcionProducto;
            consolidado.DescripcionCatalogo = entConsolidado.DescripcionCatalogo;
            consolidado.CompuestaVariable = entConsolidado.CompuestaVariable;
            consolidado.NumeroGrupo = entConsolidado.NumeroGrupo;
            consolidado.FactorCuadre = entConsolidado.FactorCuadre;
            consolidado.FlagTop = entConsolidado.FlagTop;
            consolidado.Tono = entConsolidado.Tono;
            consolidado.Marca = entConsolidado.Marca;
            consolidado.Categoria = entConsolidado.Categoria;
            consolidado.Tipo = entConsolidado.Tipo;
            consolidado.DescuentoSet = entConsolidado.DescuentoSet;
            consolidado.ReglaSet = entConsolidado.ReglaSet;
            consolidado.GAPMNvsImpreso = entConsolidado.GAPMNvsImpreso;
            consolidado.GAPUSDvsImpreso = entConsolidado.GAPUSDvsImpreso;
            consolidado.IndicadorCxC = entConsolidado.IndicadorCxC;
            consolidado.FactoRepeticion = entConsolidado.FactoRepeticion;
            consolidado.POUnitarioMN = entConsolidado.POUnitarioMN;
            consolidado.POSetMN = entConsolidado.POSetMN;
            consolidado.PNSetMN = entConsolidado.PNSetMN;
            consolidado.PNUnitarioMN = entConsolidado.PNUnitarioMN;
            consolidado.Unidades = entConsolidado.Unidades;
            consolidado.P1 = entConsolidado.P1;
            consolidado.P2 = entConsolidado.P2;
            consolidado.P3 = entConsolidado.P3;
            consolidado.P4 = entConsolidado.P4;
            consolidado.P5 = entConsolidado.P5;
            consolidado.P6 = entConsolidado.P6;
            consolidado.P7 = entConsolidado.P7;
            consolidado.Comentario = entConsolidado.Comentario;
            consolidado.CODP = entConsolidado.CODP;
            consolidado.NumeroProductosOferta = entConsolidado.NumeroProductosOferta;
            consolidado.TipoPlan = entConsolidado.TipoPlan;
            consolidado.IndicadorSubcampana = entConsolidado.IndicadorSubcampana;
            consolidado.CantidadSAPDiferentes = entConsolidado.CantidadSAPDiferentes;
            consolidado.NumeroRepeticionesSAP = entConsolidado.NumeroRepeticionesSAP;
            consolidado.UsuarioCreacion = entConsolidado.UsuarioCreacion;
            consolidado.FechaCreacion = entConsolidado.FechaCreacion;
            consolidado.UsuarioModificacion = entConsolidado.UsuarioModificacion;
            consolidado.FechaModificacion = entConsolidado.FechaModificacion;



            if (consolidado == null)
            {
                return HttpNotFound();
            }

            BL_Campana objCampana = new BL_Campana();
            CampanaModel Campana = new CampanaModel();
            Campana.PageSize = 100;
            Campana.PageIndex = 1;
            List<CampanaModel> lstCampanaPlaneacion = objCampana.SelectAll(Campana);
            List<CampanaModel> lstCampanaProceso = objCampana.SelectAll(Campana);

            BL_Pais objPais = new BL_Pais();
            PaisModel Pais = new PaisModel();
            Pais.PageSize = 100;
            Pais.PageIndex = 1;
            List<PaisModel> lstPais = objPais.SelectAll(Pais);

            BL_Palanca objPalanca = new BL_Palanca();
            PalancaModel Palanca = new PalancaModel();
            Palanca.PageSize = 100;
            Palanca.PageIndex = 1;
            List<PalancaModel> lstPalanca = objPalanca.SelectAll(Palanca);


            ViewBag.IdCampanaPlaneacion = new SelectList(lstCampanaPlaneacion, "IdCampana", "IdCampana", consolidado.IdCampanaPlaneacion);
            ViewBag.IdCampanaProceso = new SelectList(lstCampanaProceso, "IdCampana", "IdCampana", consolidado.IdCampanaProceso);
            ViewBag.IdPais = new SelectList(lstPais, "IdPais", "Descripcion", consolidado.IdPais);
            ViewBag.IdPalanca = new SelectList(lstPalanca, "IdPalanca", "Descripcion", consolidado.IdPalanca);
            return View(consolidado);
        }

        // POST: Consolidado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdConsolidado,IdCampanaPlaneacion,IdCampanaProceso,IdPalanca,UnidadesLimite,NumeroEspacios,IdPais,CuentaOfertas,Binomio,CUVPadre,CUV,CUCAntiguo,SAPAntiguo,BPCSGenericoAntiguo,BPCSTonoAntiguo,DescripcionGenericoAntiguo,DescripcionTonoAntiguo,Lanzamiento,CUC,SAP,BPCSGenerico,BPCSTono,IndicadorGratis,DescripcionSet,DescripcionProducto,DescripcionCatalogo,CompuestaVariable,NumeroGrupo,FactorCuadre,FlagTop,Tono,Marca,Categoria,Tipo,DescuentoSet,ReglaSet,GAPMNvsImpreso,GAPUSDvsImpreso,IndicadorCxC,FactoRepeticion,POUnitarioMN,POSetMN,PNSetMN,PNUnitarioMN,Unidades,P1,P2,P3,P4,P5,P6,P7,Comentario,CODP,NumeroProductosOferta,TipoPlan,IndicadorSubcampana,CantidadSAPDiferentes,NumeroRepeticionesSAP,UsuarioCreacion,FechaCreacion,UsuarioModificacion,FechaModificacion")] Consolidado consolidado)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(consolidado).State = EntityState.Modified;
                //db.SaveChanges();
                BL_Consolidado objConsolidado = new BL_Consolidado();
                ConsolidadoModel entConsolidado = new ConsolidadoModel();
                entConsolidado.IdConsolidado = consolidado.IdConsolidado;
                entConsolidado.IdCampanaPlaneacion = consolidado.IdCampanaPlaneacion;
                entConsolidado.IdCampanaProceso = consolidado.IdCampanaProceso;
                entConsolidado.IdPalanca = consolidado.IdPalanca;
                entConsolidado.UnidadesLimite = consolidado.UnidadesLimite;
                entConsolidado.NumeroEspacios = consolidado.NumeroEspacios;
                entConsolidado.IdPais = consolidado.IdPais;
                entConsolidado.CuentaOfertas = consolidado.CuentaOfertas;
                entConsolidado.Binomio = consolidado.Binomio;
                entConsolidado.CUVPadre = consolidado.CUVPadre;
                entConsolidado.CUV = consolidado.CUV;
                entConsolidado.CUCAntiguo = consolidado.CUCAntiguo;
                entConsolidado.SAPAntiguo = consolidado.SAPAntiguo;
                entConsolidado.BPCSGenericoAntiguo = consolidado.BPCSGenericoAntiguo;
                entConsolidado.BPCSTonoAntiguo = consolidado.BPCSTonoAntiguo;
                entConsolidado.DescripcionGenericoAntiguo = consolidado.DescripcionGenericoAntiguo;
                entConsolidado.DescripcionTonoAntiguo = consolidado.DescripcionTonoAntiguo;
                entConsolidado.Lanzamiento = consolidado.Lanzamiento;
                entConsolidado.CUC = consolidado.CUC;
                entConsolidado.SAP = consolidado.SAP;
                entConsolidado.BPCSGenerico = consolidado.BPCSGenerico;
                entConsolidado.BPCSTono = consolidado.BPCSTono;
                entConsolidado.IndicadorGratis = consolidado.IndicadorGratis;
                entConsolidado.DescripcionSet = consolidado.DescripcionSet;
                entConsolidado.DescripcionProducto = consolidado.DescripcionProducto;
                entConsolidado.DescripcionCatalogo = consolidado.DescripcionCatalogo;
                entConsolidado.CompuestaVariable = consolidado.CompuestaVariable;
                entConsolidado.NumeroGrupo = consolidado.NumeroGrupo;
                entConsolidado.FactorCuadre = consolidado.FactorCuadre;
                entConsolidado.FlagTop = consolidado.FlagTop;
                entConsolidado.Tono = consolidado.Tono;
                entConsolidado.Marca = consolidado.Marca;
                entConsolidado.Categoria = consolidado.Categoria;
                entConsolidado.Tipo = consolidado.Tipo;
                entConsolidado.DescuentoSet = consolidado.DescuentoSet;
                entConsolidado.ReglaSet = consolidado.ReglaSet;
                entConsolidado.GAPMNvsImpreso = consolidado.GAPMNvsImpreso;
                entConsolidado.GAPUSDvsImpreso = consolidado.GAPUSDvsImpreso;
                entConsolidado.IndicadorCxC = consolidado.IndicadorCxC;
                entConsolidado.FactoRepeticion = consolidado.FactoRepeticion;
                entConsolidado.POUnitarioMN = consolidado.POUnitarioMN;
                entConsolidado.POSetMN = consolidado.POSetMN;
                entConsolidado.PNSetMN = consolidado.PNSetMN;
                entConsolidado.PNUnitarioMN = consolidado.PNUnitarioMN;
                entConsolidado.Unidades = consolidado.Unidades;
                entConsolidado.P1 = consolidado.P1;
                entConsolidado.P2 = consolidado.P2;
                entConsolidado.P3 = consolidado.P3;
                entConsolidado.P4 = consolidado.P4;
                entConsolidado.P5 = consolidado.P5;
                entConsolidado.P6 = consolidado.P6;
                entConsolidado.P7 = consolidado.P7;
                entConsolidado.Comentario = consolidado.Comentario;
                entConsolidado.CODP = consolidado.CODP;
                entConsolidado.NumeroProductosOferta = consolidado.NumeroProductosOferta;
                entConsolidado.TipoPlan = consolidado.TipoPlan;
                entConsolidado.IndicadorSubcampana = consolidado.IndicadorSubcampana;
                entConsolidado.CantidadSAPDiferentes = consolidado.CantidadSAPDiferentes;
                entConsolidado.NumeroRepeticionesSAP = consolidado.NumeroRepeticionesSAP;
                entConsolidado.UsuarioCreacion = consolidado.UsuarioCreacion;
                entConsolidado.FechaCreacion = consolidado.FechaCreacion;
                entConsolidado.UsuarioModificacion = consolidado.UsuarioModificacion;
                entConsolidado.FechaModificacion = consolidado.FechaModificacion;
                objConsolidado.Update(entConsolidado);
                return RedirectToAction("Index");
            }
            BL_Campana objCampana = new BL_Campana();
            CampanaModel Campana = new CampanaModel();
            Campana.PageSize = 100;
            Campana.PageIndex = 1;
            List<CampanaModel> lstCampanaPlaneacion = objCampana.SelectAll(Campana);
            List<CampanaModel> lstCampanaProceso = objCampana.SelectAll(Campana);

            BL_Pais objPais = new BL_Pais();
            PaisModel Pais = new PaisModel();
            Pais.PageSize = 100;
            Pais.PageIndex = 1;
            List<PaisModel> lstPais = objPais.SelectAll(Pais);

            BL_Palanca objPalanca = new BL_Palanca();
            PalancaModel Palanca = new PalancaModel();
            Palanca.PageSize = 100;
            Palanca.PageIndex = 1;
            List<PalancaModel> lstPalanca = objPalanca.SelectAll(Palanca);


            ViewBag.IdCampanaPlaneacion = new SelectList(lstCampanaPlaneacion, "IdCampana", "IdCampana", consolidado.IdCampanaPlaneacion);
            ViewBag.IdCampanaProceso = new SelectList(lstCampanaProceso, "IdCampana", "IdCampana", consolidado.IdCampanaProceso);
            ViewBag.IdPais = new SelectList(lstPais, "IdPais", "Descripcion", consolidado.IdPais);
            ViewBag.IdPalanca = new SelectList(lstPalanca, "IdPalanca", "Descripcion", consolidado.IdPalanca);
            return View(consolidado);
        }

        // GET: Consolidado/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            } 
            Consolidado consolidado = new Consolidado();
            BL_Consolidado objConsolidado = new BL_Consolidado();
            ConsolidadoModel entConsolidado = new ConsolidadoModel();
            entConsolidado = objConsolidado.Select(id);
            consolidado.IdConsolidado = entConsolidado.IdConsolidado;
            consolidado.IdCampanaPlaneacion = entConsolidado.IdCampanaPlaneacion;
            consolidado.IdCampanaProceso = entConsolidado.IdCampanaProceso;
            consolidado.IdPalanca = entConsolidado.IdPalanca;
            consolidado.UnidadesLimite = entConsolidado.UnidadesLimite;
            consolidado.NumeroEspacios = entConsolidado.NumeroEspacios;
            consolidado.IdPais = entConsolidado.IdPais;
            consolidado.CuentaOfertas = entConsolidado.CuentaOfertas;
            consolidado.Binomio = entConsolidado.Binomio;
            consolidado.CUVPadre = entConsolidado.CUVPadre;
            consolidado.CUV = entConsolidado.CUV;
            consolidado.CUCAntiguo = entConsolidado.CUCAntiguo;
            consolidado.SAPAntiguo = entConsolidado.SAPAntiguo;
            consolidado.BPCSGenericoAntiguo = entConsolidado.BPCSGenericoAntiguo;
            consolidado.BPCSTonoAntiguo = entConsolidado.BPCSTonoAntiguo;
            consolidado.DescripcionGenericoAntiguo = entConsolidado.DescripcionGenericoAntiguo;
            consolidado.DescripcionTonoAntiguo = entConsolidado.DescripcionTonoAntiguo;
            consolidado.Lanzamiento = entConsolidado.Lanzamiento;
            consolidado.CUC = entConsolidado.CUC;
            consolidado.SAP = entConsolidado.SAP;
            consolidado.BPCSGenerico = entConsolidado.BPCSGenerico;
            consolidado.BPCSTono = entConsolidado.BPCSTono;
            consolidado.IndicadorGratis = entConsolidado.IndicadorGratis;
            consolidado.DescripcionSet = entConsolidado.DescripcionSet;
            consolidado.DescripcionProducto = entConsolidado.DescripcionProducto;
            consolidado.DescripcionCatalogo = entConsolidado.DescripcionCatalogo;
            consolidado.CompuestaVariable = entConsolidado.CompuestaVariable;
            consolidado.NumeroGrupo = entConsolidado.NumeroGrupo;
            consolidado.FactorCuadre = entConsolidado.FactorCuadre;
            consolidado.FlagTop = entConsolidado.FlagTop;
            consolidado.Tono = entConsolidado.Tono;
            consolidado.Marca = entConsolidado.Marca;
            consolidado.Categoria = entConsolidado.Categoria;
            consolidado.Tipo = entConsolidado.Tipo;
            consolidado.DescuentoSet = entConsolidado.DescuentoSet;
            consolidado.ReglaSet = entConsolidado.ReglaSet;
            consolidado.GAPMNvsImpreso = entConsolidado.GAPMNvsImpreso;
            consolidado.GAPUSDvsImpreso = entConsolidado.GAPUSDvsImpreso;
            consolidado.IndicadorCxC = entConsolidado.IndicadorCxC;
            consolidado.FactoRepeticion = entConsolidado.FactoRepeticion;
            consolidado.POUnitarioMN = entConsolidado.POUnitarioMN;
            consolidado.POSetMN = entConsolidado.POSetMN;
            consolidado.PNSetMN = entConsolidado.PNSetMN;
            consolidado.PNUnitarioMN = entConsolidado.PNUnitarioMN;
            consolidado.Unidades = entConsolidado.Unidades;
            consolidado.P1 = entConsolidado.P1;
            consolidado.P2 = entConsolidado.P2;
            consolidado.P3 = entConsolidado.P3;
            consolidado.P4 = entConsolidado.P4;
            consolidado.P5 = entConsolidado.P5;
            consolidado.P6 = entConsolidado.P6;
            consolidado.P7 = entConsolidado.P7;
            consolidado.Comentario = entConsolidado.Comentario;
            consolidado.CODP = entConsolidado.CODP;
            consolidado.NumeroProductosOferta = entConsolidado.NumeroProductosOferta;
            consolidado.TipoPlan = entConsolidado.TipoPlan;
            consolidado.IndicadorSubcampana = entConsolidado.IndicadorSubcampana;
            consolidado.CantidadSAPDiferentes = entConsolidado.CantidadSAPDiferentes;
            consolidado.NumeroRepeticionesSAP = entConsolidado.NumeroRepeticionesSAP;
            consolidado.UsuarioCreacion = entConsolidado.UsuarioCreacion;
            consolidado.FechaCreacion = entConsolidado.FechaCreacion;
            consolidado.UsuarioModificacion = entConsolidado.UsuarioModificacion;
            consolidado.FechaModificacion = entConsolidado.FechaModificacion;


            if (consolidado == null)
            {
                return HttpNotFound();
            }
            return View(consolidado);
        }

        // POST: Consolidado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            //Consolidado consolidado = db.Consolidado.Find(id);
            //db.Consolidado.Remove(consolidado);
            //db.SaveChanges();


            BL_Consolidado objConsolidado = new BL_Consolidado();
            objConsolidado.Delete(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }



        // POST: Consolidado/Exportar
        [HttpGet]
        public void Exportar()
        {
            //IEnumerable<Consolidado> consolidado = db.Consolidado.Include(c => c.Campana).Include(c => c.Campana1).Include(c => c.Categoria).Include(c => c.Marca).Include(c => c.Pais).Include(c => c.Palanca);

            


            BL_Consolidado objConsolidado = new BL_Consolidado();
            ConsolidadoModel entConsolidadoModel = new ConsolidadoModel();
            entConsolidadoModel.PageSize = 3000;
            entConsolidadoModel.PageIndex = 1;
            List<ConsolidadoModel> lstConsolidado = objConsolidado.SelectAll(entConsolidadoModel);

            DataTable dt = ToDataTable(lstConsolidado);

            dt.ToExcel("Consolidado");
        }

        public DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();

            // column names 
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others 
                //will follow
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
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
    }
}
