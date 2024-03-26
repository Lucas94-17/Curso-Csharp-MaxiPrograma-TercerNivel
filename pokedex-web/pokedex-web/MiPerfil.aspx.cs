using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace pokedex_web
{
    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                TraineeNegocio traineeNegocio = new TraineeNegocio();
                string ruta = Server.MapPath("./Img/");
                Trainee user = (Trainee)Session["trainee"];
                txtImagen.PostedFile.SaveAs(ruta + "perfil-" + user.Id+ ".jpg");

                user.ImagenPerfil = "perfil-" + user.Id + ".jpg";
                user.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                user.Email = txtEmail.Text;
                user.Apellido = txtApellido.Text;
                user.Nombre = txtNombre.Text;
                traineeNegocio.actualizar(user);

            }
            catch (Exception ex)
            {

                Session.Add("error",ex.ToString());
            }
        }
    }
}