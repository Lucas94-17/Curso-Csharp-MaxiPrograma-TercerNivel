using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio2;

namespace Ejemplo_Formulario
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ListaAutos"] == null)
            {
                AutoNegocio negocio = new AutoNegocio();
                Session.Add("ListaAutos", negocio.Listar());
            }
            dgvAutos.DataSource = Session["ListaAutos"];
            dgvAutos.DataBind();
        }

        protected void dgvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var algo = dgvAutos.SelectedRow.Cells[0].Text;
            var Id = dgvAutos.SelectedDataKey.Value.ToString();

            Response.Redirect("AutoForm.aspx?id=" + Id);
        }
    }
}