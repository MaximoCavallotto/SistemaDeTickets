using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Sistema_de_Gestion_de_Tickets
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.UsuarioNombre = txtboxUsuario.Text;
            usuario.Contraseña = txtboxContraseña.Text;

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            if (usuarioNegocio.Loguear(usuario))
            {
                Response.Redirect("Panel.Aspx", false);
            }
            else {
                lblLogFalla.Visible = true;
            }
            

            
        }
    }
}