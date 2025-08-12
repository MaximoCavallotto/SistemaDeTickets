using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TareaNegocio
    {
        public List<Tarea> listarTareas()
        { 
            List<Tarea> tareas = new List<Tarea>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select T.Id, T.Fecha, T.Nombre, T.Descripcion, T.Id_Estado from Tickets T");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tarea aux = new Tarea();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.IdEstado = (int)datos.Lector["Id_Estado"];

                    tareas.Add(aux);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
            return tareas;
        
        
        }

        public void altaTarea(Tarea nuevaTarea)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into Tickets (Fecha, Nombre, Descripcion, Id_Estado) values (GETDATE(), @Nombre,@Descripcion , 1)");
                datos.setearParametros("@Nombre", nuevaTarea.Nombre);
                datos.setearParametros("@Descripcion", nuevaTarea.Descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
            
            //insert into Tickets(Fecha, Nombre, Descripcion, Id_Estado) values(GETDATE(), '', '', 1)


        }
    }
}
