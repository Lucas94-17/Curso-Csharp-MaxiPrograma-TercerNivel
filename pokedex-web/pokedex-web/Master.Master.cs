using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pokedex_web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page is Login || Page is Registro || Page is WebForm1))
            {
                if (!(Seguridad.sesionActiva(Session["trainee"])))
                {
                    Response.Redirect("Login.aspx", false);
                }
            }

        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("trainee");
            Response.Redirect("Login.aspx");

        }

        protected void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPruebaMail.aspx", false);
        }

        protected void btnMiPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("MiPerfil.aspx", false);
        }
    }
}