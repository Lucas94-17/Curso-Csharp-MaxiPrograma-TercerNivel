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
    public partial class FormularioPokemon : System.Web.UI.Page
    {
        public bool botonEliminacion {  get; set; }
        public bool ConfimarEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            ConfimarEliminacion = false;
            botonEliminacion = false;
            try
            {
                //Configuracion inicial de la pantalla
                if (!IsPostBack)
                {
                    ElementoNegocio negocio = new ElementoNegocio();
                    List<Elemento> lista = negocio.listar();

                    dropTipo.DataSource = lista;
                    dropTipo.DataValueField = "id";
                    dropTipo.DataTextField = "Descripcion";
                    dropTipo.DataBind();

                    dropDebilidad.DataSource = lista;
                    dropDebilidad.DataValueField = "id";
                    dropDebilidad.DataTextField = "Descripcion";
                    dropDebilidad.DataBind();

                }
                //Configuracion si estamos modificando
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                if (id != "" && !IsPostBack)
                {
                    botonEliminacion = true;
                    PokemonNegocio negocio = new PokemonNegocio();
                    //List<Pokemon> lista = negocio.listar(id); 
                    //Pokemon seleccionado = lista[0];
                    Pokemon seleccionado = (negocio.listar(id))[0];

                    //Guardo pokemon seleccionado en sesion
                    Session.Add("pokeSeleccionado", seleccionado);

                    //pre cargar los datos del pokemon
                    txtId.Text = id;
                    txtNombre.Text = seleccionado.Nombre;
                    txtNumero.Text = seleccionado.Numero.ToString();
                    txtimagenUrl.Text = seleccionado.UrlImagen;
                    txtDescripcion.Text = seleccionado.Descripcion;

                    dropDebilidad.SelectedValue = seleccionado.Debilidad.Id.ToString();
                    dropTipo.SelectedValue = seleccionado.Tipo.Id.ToString();
                    txtimagenUrl_TextChanged(sender, e);

                    if (!seleccionado.Activo)
                        btnDesactivar.Text = "Activar";
                }


            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                //redireccionar a una pantalla de error
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void txtimagenUrl_TextChanged(object sender, EventArgs e)
        {
            imgPokemon.ImageUrl = txtimagenUrl.Text;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Pokemon nuevo = new Pokemon();
                PokemonNegocio negocio = new PokemonNegocio();

                nuevo.Numero = int.Parse(txtNumero.Text);
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.UrlImagen = txtimagenUrl.Text;

                nuevo.Tipo = new Elemento();
                nuevo.Tipo.Id = int.Parse(dropTipo.SelectedValue);

                nuevo.Debilidad = new Elemento();
                nuevo.Debilidad.Id = int.Parse(dropDebilidad.SelectedValue);

                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(txtId.Text);
                    negocio.modificarSp(nuevo);
                }
                else
                    negocio.agregarSP(nuevo);
                Response.Redirect("PokemonListar.aspx",false);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

 

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            ConfimarEliminacion = true;
        }

        protected void btnConfirmaEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckConfirmarEliminacion.Checked)
                {
                    PokemonNegocio negocio = new PokemonNegocio();
                    negocio.eliminar(int.Parse(txtId.Text));
                    Response.Redirect("PokemonListar.aspx");
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);

            }
        }

        protected void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                //Aca recupero el pokemon seleccionado en la sesion
                Pokemon seleccionado = (Pokemon)Session["pokeSeleccionado"];
                negocio.eliminarLogico(seleccionado.Id,!seleccionado.Activo);
                Response.Redirect("PokemonListar.aspx");
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);

            }
        }
    }
}