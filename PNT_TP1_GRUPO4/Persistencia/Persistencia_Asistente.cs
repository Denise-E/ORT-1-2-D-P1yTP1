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
                else
                {
                    i++; 
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

           
            if (asistente != null)
            {
                actualizado = true;

                string n = !string.IsNullOrEmpty(a.nombre) ? (asistente.nombre = a.nombre) : asistente.nombre;
                string apell = !string.IsNullOrEmpty(a.apellido) ? (asistente.apellido = a.apellido) : asistente.apellido;
                short ed = a.edad > 0 ? (asistente.edad = a.edad) : asistente.edad; 
                string turn = !string.IsNullOrEmpty(a.turno) ? (asistente.turno = a.turno) : asistente.turno;
                string desc = !string.IsNullOrEmpty(a.descripcion) ? (asistente.descripcion = a.descripcion) : asistente.descripcion;

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
            List<Asistente> asistentesEncontrados = new List<Asistente>();

            foreach (var item in this.asistentes)
            {
                if(item.edad == edad)
                {
                    asistentesEncontrados.Add(item);
                }
            }

            return asistentesEncontrados;
        }

        public List<Asistente> BuscarAsistentePorTurno(string turno)
        {
            List<Asistente> asistentesEncontrados = new List<Asistente>(); 

            foreach (var item in this.asistentes)
            {
                if (item.turno == turno)
                {
                    asistentesEncontrados.Add(item);
                }
            }

            return asistentesEncontrados;
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
