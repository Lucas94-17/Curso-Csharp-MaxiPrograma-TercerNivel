using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pokedex_web
{
    public partial class MenuLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnpagina2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina2Login.aspx", false);
        }

        protected void btnpagina1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1Login.aspx", false);
        }
    }
}