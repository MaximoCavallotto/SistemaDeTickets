using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contraseña { get; set; }
        public bool esAdmin { get; set; }

    }
}
