using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Sistema_de_Gestion_de_Tickets
{
    public partial class Panel : System.Web.UI.Page
    {
        public List<Tarea> ListaTareas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            TareaNegocio tareaNegocio = new TareaNegocio();
            ListaTareas = tareaNegocio.listarTareas();

            repRepetidor.DataSource = ListaTareas;
            repRepetidor.DataBind();
        }

        protected void btnVerTarea_Click(object sender, EventArgs e)
        {
            Button btnVerTarea = (Button)sender;
            int Id = int.Parse(btnVerTarea.CommandArgument);
            Response.Redirect("TareaDetalle.aspx?Id=" + Id ,false);
        }
    }
}