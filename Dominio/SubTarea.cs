using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class SubTarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Ticket { get; set; }
        public  int Id_Creador { get; set; } 
        public bool Estado { get; set; }
    }
}
