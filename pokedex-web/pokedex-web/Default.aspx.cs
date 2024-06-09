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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Pokemon> ListaPokemon { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            ListaPokemon = negocio.listarConSp();

            if (!IsPostBack)
            {
                Repetidor.DataSource = ListaPokemon;
                Repetidor.DataBind();
            }
            
        }

        protected void btnEjemplo_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
        }
    }
}