using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio2;

namespace Ejemplo_Formulario
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlistColor.Items.Add("Rojo");
                ddlistColor.Items.Add("Negro");
                ddlistColor.Items.Add("Blanco");
                ddlistColor.Items.Add("Gris");
            }

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["Id"].ToString());
                List<Auto> temporal = (List<Auto>)Session["ListaAutos"];
                Auto seleccionado = temporal.Find(x => x.Id == id);
                txtModelo.Text = seleccionado.Modelo;
                txtId.Text = seleccionado.Id.ToString();
                txtFecha.Text = seleccionado.Fecha.ToString("dd/MM/yyyy");
                txtDescripcion.Text = seleccionado.Descripcion;
                checkUsado.Checked = seleccionado.Usado;
                btnAceptar.Enabled = false;
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.Id =int.Parse(txtId.Text);
            auto.Modelo = txtModelo.Text;
            auto.Descripcion = txtDescripcion.Text;
            auto.Color = ddlistColor.SelectedValue;
            auto.Fecha = DateTime.Parse(txtFecha.Text);
            auto.Usado = checkUsado.Checked;

            if(rdbimportado.Checked)
            {
                auto.Importado = true;
            }
            else if(rdbNacional.Checked)
            {
                auto.Importado = false;
            }

            //((List<Auto>)Session["ListaAutos"]).Add(auto);
            List<Auto> temporal = (List<Auto>)Session["ListaAutos"];
            temporal.Add(auto);

            Response.Redirect("Default.aspx");
        }

        protected void checkUsado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}