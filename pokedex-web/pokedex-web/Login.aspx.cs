using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace pokedex_web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            TraineeNegocio Negocio = new TraineeNegocio();
            Trainee trainee = new Trainee();
            try
            {
                trainee.Email = txtEmail.Text;
                trainee.Pass  = txtPassword.Text;
                if (Negocio.Login(trainee))
                {
                    Session.Add("trainee",trainee);
                    Response.Redirect("MiPerfil.aspx", false);
                }
                else
                {
                    Session.Add("error", "user o password incorrectos ");
                    Response.Redirect("error.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }
    }
}