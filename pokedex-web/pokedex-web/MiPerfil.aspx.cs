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
            try
            {
                if (!IsPostBack)
                {
                    if (Seguridad.sesionActiva(Session["trainee"]))
                    {
                        Trainee user = (Trainee)Session["trainee"];
                        txtEmail.Text = user.Email;
                        txtEmail.ReadOnly = true;
                        txtNombre.Text = user.Nombre;
                        txtApellido.Text = user.Apellido;
                        txtFechaNacimiento.Text = user.FechaNacimiento.ToString("yyyy-MM-dd");
                        if (!string.IsNullOrEmpty(user.ImagenPerfil))
                            imgNuevoPerfil.ImageUrl = "~/Img/" + user.ImagenPerfil;
                    }
                }

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate();
                if (!Page.IsValid)
                {
                    return;
                }
                TraineeNegocio traineeNegocio = new TraineeNegocio();
                Trainee user = (Trainee)Session["trainee"];
                //Escribir img si se cargo algo
                if (txtImagen.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Img/");
                    txtImagen.PostedFile.SaveAs(ruta + "perfil-" + user.Id + ".jpg");
                    user.ImagenPerfil = "perfil-" + user.Id + ".jpg";

                }

                user.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                user.Apellido = txtApellido.Text;
                user.Nombre = txtNombre.Text;
                traineeNegocio.actualizar(user);
                Image imgAvatar = (Image)Master.FindControl("imgAvatar");
                imgAvatar.ImageUrl = "~/Img/" + user.ImagenPerfil; 

            }
            catch (Exception ex)
            {

                Session.Add("error",ex.ToString());
            }
        }
    }
}