using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GRUPO4.Negocios.Entidades
{
    public class Asistente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public short edad { get; set; }
        public string turno { get; set; }
        public string descripcion { get; set; }


        override
        public string ToString()
        {
            return "Nombre " + nombre + " Apellido " + apellido + " Edad " + edad + " Turno " + turno + " Descripcion " + descripcion;
        }
    }
}
