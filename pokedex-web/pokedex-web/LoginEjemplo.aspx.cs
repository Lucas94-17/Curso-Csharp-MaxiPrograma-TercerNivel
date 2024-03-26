using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pokedex_web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Session.Add("error", "Debes loguearte primero");
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario Usuario;
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                //Usuario.User = txtUsuario.Text;
                Usuario = new Usuario(txtUsuario.Text,txtPassword.Text , false);
                if (negocio.Loguearse(Usuario))
                {
                    Session.Add("Usuario",Usuario);
                    Response.Redirect("MenuLogin.aspx",false);

                }
                else
                {
                    Session.Add("error", "Usuario o password incorrecto");
                    Response.Redirect("Error.aspx",false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);

            }
        }
    }
}