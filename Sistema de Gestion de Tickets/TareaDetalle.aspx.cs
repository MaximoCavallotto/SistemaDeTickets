using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_Gestion_de_Tickets
{
    public partial class TareaDetalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int IdTicket = int.Parse(Request.QueryString["Id"]);

            SubTareaNegocio subTareaNeg = new SubTareaNegocio();
            dgvSubTareas.DataSource = subTareaNeg.listarSubTareas(IdTicket);
            dgvSubTareas.DataBind();
        }
    }
}