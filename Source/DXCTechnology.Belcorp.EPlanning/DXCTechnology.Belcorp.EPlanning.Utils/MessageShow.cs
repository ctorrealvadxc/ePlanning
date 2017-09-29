using System;

namespace DXCTechnology.Belcorp.ePlanning.SharedLibreries
{
    public class MessageShow
    {

        #region MENSAJES DE ERROR (en window.load)
        /// <summary>
        /// Lanza un mensaje de error en el cliente al terminar la carga de la página
        /// </summary>
        /// <param name="pPagina">Página desde donde se lanza el mensaje.</param>
        /// <param name="pTitulo">Título de la ventana del mensaje.</param>
        /// <param name="pMensajeHTML">Mensaje a ser mostrado (acepta etiquetas HTML)</param>
        public static void MostrarErrorTitulo(System.Web.UI.Page pPagina, string pTitulo, string pMensajeHTML)
        {
            pPagina.ClientScript.RegisterStartupScript(pPagina.GetType(), string.Format("sct_{0}", DateTime.Now.ToString("yyyyMMddHHmmssffff")), "<script>$(window).load(function () {$('#msj_error').mostrarError('" + pTitulo + "','" + pMensajeHTML + "');})</script>", false);
        }
        /// <summary>
        /// Lanza un mensaje de error en el cliente al terminar la carga de la página
        /// </summary>
        /// <param name="pPagina">Página desde donde se lanza el mensaje.</param>
        /// <param name="pMensajeHTML">Mensaje a ser mostrado (acepta etiquetas HTML)</param>
        public static void MostrarError(System.Web.UI.Page pPagina, string pMensajeHTML)
        {
            MostrarErrorTitulo(pPagina, "Ha ocurrido un error.", pMensajeHTML);
        } 
        #endregion

        #region MENSAJES DE EXITO (en window.load)
        /// <summary>
        /// Lanza un mensaje de éxito en el cliente al terminar la carga de la página
        /// </summary>
        /// <param name="pPagina">Página desde donde se lanza el mensaje.</param>
        /// <param name="pTitulo">Título de la ventana del mensaje.</param>
        /// <param name="pMensajeHTML">Mensaje a ser mostrado (acepta etiquetas HTML)</param>
        public static void MostrarOkTitulo(System.Web.UI.Page pPagina, string pTitulo, string pMensajeHTML)
        {
            pPagina.ClientScript.RegisterStartupScript(pPagina.GetType(), string.Format("sct_{0}", DateTime.Now.ToString("yyyyMMddHHmmssffff")), "<script>$(window).load(function () {$('#msj_exito').mostrarOK('" + pTitulo + "','" + pMensajeHTML + "');})</script>", false);
        }
        /// <summary>
        /// Lanza un mensaje de éxito en el cliente al terminar la carga de la página
        /// </summary>
        /// <param name="pPagina">Página desde donde se lanza el mensaje.</param>
        /// <param name="pMensajeHTML">Mensaje a ser mostrado (acepta etiquetas HTML)</param>
        public static void MostrarOk(System.Web.UI.Page pPagina, string pMensajeHTML)
        {
            MostrarOkTitulo(pPagina, "Se ha ejecutado correctamente.", pMensajeHTML);
        } 
        #endregion

    }
}
