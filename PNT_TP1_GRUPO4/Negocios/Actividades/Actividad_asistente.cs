using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_GRUPO4.Negocios.Entidades;
using TP1_GRUPO4.Persistencia;

namespace TP1_GRUPO4.Negocios.Actividades
{
    public class Actividad_asistente
    {
        Persistencia_asistente pers = new Persistencia_asistente();

        public bool Create(Asistente p)
        {
            return pers.Create(p);
        }

        public Asistente Read(int id)
        {
            return pers.Read(id);
        }

        public List<Asistente> ReadAll()
        {
            return pers.ReadAll();
        }

        public bool Update(Asistente a)
        {
            return pers.Update(a);
        }

        public bool Delete(int id)
        {
            return pers.Delete(id);
        }

        public List<Asistente> BuscarAsistentePorEdad(short edad)
        {
            return pers.BuscarAsistentePorEdad(edad);
        }

        public List<Asistente> BuscarAsistentePorTurno(string turno)
        {
            return pers.BuscarAsistentePorTurno(turno);
        }

        public int EliminarAsistentesDeEdadEspecifica(short edad)
        {
            return pers.EliminarAsistentesDeEdadEspecifica(edad);
        }
    }
}
