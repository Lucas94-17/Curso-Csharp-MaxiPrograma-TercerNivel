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
    public partial class WebForm2 : System.Web.UI.Page
    {
        public bool FiltroAvanzado { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Seguridad.esAdmin(Session["trainee"]))
            {
                Session.Add("error", "Se requiere permisos de admin para acceder a esta pantalla");
                Response.Redirect("Error.aspx",false);
            }
            PokemonNegocio negocio = new PokemonNegocio();
            Session.Add("listaPokemons", negocio.listarConSp());
            dgvpokemons.DataSource = Session["listaPokemons"];
            dgvpokemons.DataBind();
        }
        protected void dgvPokemons_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvpokemons.PageIndex = e.NewPageIndex  ;
            dgvpokemons.DataBind();
        }
        protected void dgvPokemos_SelectIndexChanged(object sender, EventArgs e)
        {
            string id = dgvpokemons.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioPokemon.aspx?id=" + id);
        }

        protected void Filtro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> lista = (List<Pokemon>)Session["listaPokemons"];
            List<Pokemon> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(Filtro.Text.ToUpper()));
            dgvpokemons.DataSource= listaFiltrada;
            dgvpokemons.DataBind();
        }

        protected void chkAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            FiltroAvanzado = chkAvanzado.Checked;
            Filtro.Enabled = !FiltroAvanzado;
        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCriterio.Items.Clear();
            if(ddlCampo.SelectedItem.ToString() == "Número")
            {
                ddlCriterio.Items.Add("Igual a");
                ddlCriterio.Items.Add("Mayor a");
                ddlCriterio.Items.Add("Menor a");
            }
            else
            {
                ddlCriterio.Items.Add("Contiene");
                ddlCriterio.Items.Add("Comienza con");
                ddlCriterio.Items.Add("Termina con");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                dgvpokemons.DataSource= negocio.filtrar(
                    ddlCampo.SelectedItem.ToString(),
                    ddlCriterio.SelectedItem.ToString(),
                    txtFiltroAvanzado.Text,
                    ddlEstado.SelectedItem.ToString());
                dgvpokemons.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                
            }
        }

        protected void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            
            if (FiltroAvanzado)
            {
                ddlCriterio.SelectedItem.ToString();
                ddlEstado.SelectedItem.ToString();
                txtFiltroAvanzado.Text = "";
            }
            else
            {
                dgvpokemons.DataSource = Session["listaPokemons"];
                dgvpokemons.DataBind();
                Filtro.Text = "";
            }
        }
    }
}

//hacer boton para que borre el filtro y recarge de nuevo la tabla