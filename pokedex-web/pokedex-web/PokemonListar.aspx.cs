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
        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
}