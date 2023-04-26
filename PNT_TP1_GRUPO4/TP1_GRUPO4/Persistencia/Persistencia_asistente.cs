using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_GRUPO4.Negocios.Entidades;

namespace TP1_GRUPO4.Persistencia
{
    public class Persistencia_asistente
    {
        List<Asistente> asistentes = new List<Asistente>();

        public bool Create(Asistente p)
        {
            bool fueAgregado = false;

            if (p != null)
            {
                fueAgregado = true;
                asistentes.Add(p);
            }

            return fueAgregado;
        }

        public Asistente Read(int id)
        {
            Asistente p = null;
            int i = 0;

            while (p == null && i < asistentes.Count())
            {
                Asistente buscado = asistentes[i];

                if (buscado.id == id)
                {
                    p = buscado;
                }
            }

            return p;
        }

        public List<Asistente> ReadAll()
        {
            return this.asistentes;
        }

        public bool Update(Asistente a)
        {
            bool actualizado = false;
            Asistente asistente = Read(a.id);

            Console.WriteLine("ASISTENTE sin MODIFICADar " +  asistente.ToString());

            if (asistente != null)
            {
                actualizado = true;

                string n = a.nombre != "" ? (asistente.nombre = a.nombre) : asistente.nombre;
                string apell = a.apellido != "" ? (asistente.apellido = a.apellido) : asistente.apellido;
                short ed = a.edad != null ? (asistente.edad = a.edad) : asistente.edad; // OJO QUE NO SE RECIBIRIA COMO NULL SI NO ME PASAN NINGUN VALOR
                string turn = a.turno != "" ? (asistente.turno = a.turno) : asistente.turno;
                string desc = a.descripcion != "" ? (asistente.descripcion = a.descripcion) : asistente.descripcion;

                Console.WriteLine("ASISTENTE MODIFICADO " + asistente.ToString());
            }

            return actualizado;
        }

        public bool Delete(int id)
        {
            bool borrado = false;
            Asistente asistente = Read(id);

            if(asistente != null)
            {
                borrado = true;
                asistentes.Remove(asistente);
            }

            return borrado;
            
        }

        public List<Asistente> BuscarAsistentePorEdad(short edad)
        {
            List<Asistente> asistentes = new List<Asistente>();

            foreach (var item in asistentes)
            {
                if(item.edad == edad)
                {
                    asistentes.Add(item);
                }
            }

            return asistentes;
        }

        public List<Asistente> BuscarAsistentePorTurno(string turno)
        {
            List<Asistente> asistentes = new List<Asistente>();

            foreach (var item in asistentes)
            {
                if (item.turno == turno)
                {
                    asistentes.Add(item);
                }
            }

            return asistentes;
        }

        public int EliminarAsistentesDeEdadEspecifica(short edad)
        {
            int cont = 0;
           int i = 0;

           while( i < asistentes.Count())
            {
                Asistente asist = asistentes.ElementAt(i);

                if(asist.edad == edad)
                {
                    asistentes.Remove(asist);
                    cont++;
                }
                else
                {
                    i++;
                }
            }

            return cont;
        }
    }
}
