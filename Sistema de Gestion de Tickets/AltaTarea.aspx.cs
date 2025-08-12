using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Sistema_de_Gestion_de_Tickets
{
    public partial class AltaTarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            TareaNegocio tareaNegocio = new TareaNegocio();
            Tarea nuevaTarea = new Tarea();

            nuevaTarea.Nombre = txtboxNombre.Text;
            nuevaTarea.Descripcion = txtboxDescripcion.Text;

            tareaNegocio.altaTarea(nuevaTarea);
            Response.Redirect("Panel.aspx", false);


        }
    }
}