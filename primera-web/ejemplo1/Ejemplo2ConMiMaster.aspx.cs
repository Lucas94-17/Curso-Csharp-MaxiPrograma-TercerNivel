using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class Ejemplo2ConMiMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPass.Text;
            Label1.Text = nombre;

            Session.Add("usuario", nombre);
            Session.Add("password",password);

            //Response.Redirect("Default.aspx?nombre=" + nombre,false);
            Response.Redirect("Default.aspx",false);
        }
    }
}