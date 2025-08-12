using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public bool Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Nombre, Area, Usuario, Contraseña, EsAdmin from Usuarios where Usuario = @usuario and Contraseña = @contraseña");
                datos.setearParametros("@usuario", usuario.UsuarioNombre);
                datos.setearParametros("@contraseña", usuario.Contraseña);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.Nombre = (string)datos.Lector["Nombre"];
                    usuario.Area = (string)datos.Lector["Area"];
                    usuario.UsuarioNombre = (string)datos.Lector["Usuario"];
                    usuario.Contraseña = (string)datos.Lector["Contraseña"];
                    usuario.esAdmin = (bool)datos.Lector["EsAdmin"];

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            { datos.cerrarConexion(); }
        }
    }
}
