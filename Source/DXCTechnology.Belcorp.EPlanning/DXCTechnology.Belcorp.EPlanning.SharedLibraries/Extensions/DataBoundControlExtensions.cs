using System.Web.UI.WebControls;

namespace DXCTechnology.Belcorp.ePlanning.SharedLibraries.Extensions
{
    public static class DataBoundControlExtensions
    {
        public static void DataBind(this BaseDataBoundControl control, object datasource)
        {
            control.DataSource = datasource;
            control.DataBind();
        }

        public static void InsertarSeleccione(this DropDownList control, string valor = "")
        {
            control.Items.Insert(0, new ListItem("Seleccione", valor));
        }
    }
}
