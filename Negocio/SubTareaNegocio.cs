using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class SubTareaNegocio
    {
        public List<SubTarea> listarSubTareas(int Id_Ticket) 
        {
            AccesoDatos datos = new AccesoDatos();
            List<SubTarea> subtareas = new List<SubTarea>();

            try
            {
                datos.setearProcedure("spListarSubtareas");
                datos.setearParametros("@Id", Id_Ticket);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    SubTarea subtareaaux = new SubTarea();
                    subtareaaux.Id = (int)datos.Lector["Id"];
                    subtareaaux.Descripcion = (string)datos.Lector["Descripcion"];
                    subtareaaux.Fecha = (DateTime)datos.Lector["Fecha"];
                    subtareaaux.Id_Creador = (int)datos.Lector["Creador"];
                    subtareaaux.Estado = (bool)datos.Lector["Estado"];

                    subtareas.Add(subtareaaux);
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
            return subtareas;
        }
    }
}
