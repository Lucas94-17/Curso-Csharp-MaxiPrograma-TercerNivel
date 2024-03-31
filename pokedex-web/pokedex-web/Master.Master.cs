using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace pokedex_web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imgAvatar.ImageUrl = "../img/imagenes-de-usuario.png";

            if (!(Page is Login || Page is Registro || Page is WebForm1 || Page is Error))
            {
                if (!(Seguridad.sesionActiva(Session["trainee"])))
                {
                    Response.Redirect("Login.aspx", false);
                }
                else
                {
                    Trainee user = (Trainee)Session["trainee"];
                    lblUser.Text = user.Email;
                    if (!string.IsNullOrEmpty(user.ImagenPerfil))
                    {
                        imgAvatar.ImageUrl = "~/Img/" + user.ImagenPerfil;
                    }
                }
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
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