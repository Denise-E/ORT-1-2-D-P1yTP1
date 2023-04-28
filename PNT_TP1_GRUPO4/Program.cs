using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_GRUPO4.Persistencia;
using TP1_GRUPO4.Negocios;
using TP1_GRUPO4.Negocios.Actividades;
using TP1_GRUPO4.Negocios.Entidades;

namespace TP1_GRUPO4
{
    internal class Program
    {
        static Actividad_asistente actividad = new Actividad_asistente();
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("MANEJO DE ASISTENTES");
            Console.WriteLine("-------");
            Console.WriteLine("1 - Alta Asistente");
            Console.WriteLine("2 - Modificar Asistente");
            Console.WriteLine("3 - Buscar Asistente por ID");
            Console.WriteLine("4 - Listar a todos los Asistentes");
            Console.WriteLine("5 - Borrar Asistente");
            Console.WriteLine("6 - Buscar Asistente por edad"); 
            Console.WriteLine("7 - Buscar Asistente por turno"); 
            Console.WriteLine("8 - Eliminar Asistentes de una edad especifica");
            Console.Write("Ingrese una de las opciones: ");

            short sel = Convert.ToInt16(Console.ReadLine());

            switch (sel)
            {
                case 1:
                    {
                        Crear();
                        break;
                    }
                case 2:
                    {
                        Update();
                        break;
                    }
                case 3:
                    {
                        Read();
                        break;
                    }
                case 4:
                    {
                        ReadAll();
                        break;
                    }
                case 5:
                    {
                        Delete();
                        break;
                    }
                case 6:
                    {
                        BuscarAsistentePorEdad();
                        break;
                    }
                case 7:
                    {
                        BuscarAsistentePorTurno();
                        break;
                    }
                case 8:
                    {
                        EliminarAsistentesDeEdadEspecifica();
                        break;
                    }
            }

        }

        static void EliminarAsistentesDeEdadEspecifica()
        {
            Console.Clear();
            Console.WriteLine("Borrar Asistentes con edad especificada");

            Console.WriteLine("Ingrese la edad necesitada: ");
            short edad = short.Parse(Console.ReadLine());

            int eliminados = actividad.EliminarAsistentesDeEdadEspecifica(edad);

            if (eliminados > 0)
            {
                Console.WriteLine(eliminados + " Asistente eliminado");
            }
            else
            {
                Console.WriteLine("Ningun Asistente fue eliminado");
            }

            Console.ReadKey();
            Main();
        }

        static void Crear()
        {
            Console.Clear();
            Console.WriteLine("Agregar Asistente");

            Asistente asistente = new Asistente();
            Console.WriteLine("Ingrese su id: ");
     
           int id_verificado;
           bool id_checked = Int32.TryParse(Console.ReadLine(), out id_verificado);

            while (!id_checked)
            {
                Console.WriteLine("Ingrese un id valido: ");
                id_checked = Int32.TryParse(Console.ReadLine(), out id_verificado);
            }
            asistente.id = id_verificado;


            Console.WriteLine("Ingrese su nombre: ");
            asistente.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            asistente.apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            short edad_verificada;
            bool edad_checked = short.TryParse(Console.ReadLine(), out edad_verificada);

            while (!edad_checked)
            {
                Console.WriteLine("Ingrese una edad valida: ");
                id_checked = short.TryParse(Console.ReadLine(), out edad_verificada);
            }
            asistente.edad = edad_verificada;


            Console.WriteLine("Ingrese su turno: ");
            asistente.turno = Console.ReadLine();
            Console.WriteLine("Ingrese su descripcion: ");
            asistente.descripcion = Console.ReadLine();


            bool estado = actividad.Create(asistente);

            if (estado)
            {
                Console.WriteLine("Se guardo correctamente al Asistente");
            }
            else
            {
                Console.WriteLine("No pudo guardarse al Asistente");
            }

            Console.ReadKey();
            Main();

        }

       static void Update() 
        {
            Console.Clear();
            Console.WriteLine("Actualizar Asistente");
            Asistente asistente = new Asistente();
            Console.WriteLine("Ingrese su id: ");
            asistente.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre: ");
            asistente.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            asistente.apellido = Console.ReadLine();


            Console.WriteLine("Ingrese su edad: ");
            asistente.edad = short.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese su turno: ");
            asistente.turno = Console.ReadLine();
            Console.WriteLine("Ingrese su descripcion: ");
            asistente.descripcion = Console.ReadLine();

            //Console.WriteLine("Asistencia NOMBRE UPDATE: " + asistente.nombre);

            bool actualizado = actividad.Update(asistente);

            if (actualizado)
            {
                Console.WriteLine("Asistente actualizado");
            }
            else
            {
                Console.WriteLine("Asistente no actualizado");
            }

            Console.ReadKey();
            Main();

        }

        static void Read()
        {
            Console.Clear();
            Console.WriteLine("Leer Asistente");
            Console.WriteLine("Ingrese su id: ");
            int id = Convert.ToInt16(Console.ReadLine());

            Asistente a = actividad.Read(id);

            Console.WriteLine("Detalles del asistente: "); 

            if (a != null)
            {
                Console.WriteLine("ID: " + $"{a.id}");
                Console.WriteLine("Nombre: " + $"{a.nombre}");
                Console.WriteLine("Apellido: " + $"{a.apellido}");
                Console.WriteLine("Edad: " + $"{a.edad}");
                Console.WriteLine("Turno: " + $"{a.turno}");
                Console.WriteLine("Descripcion: " + $"{a.descripcion}");
            }
            else
            {

                Console.WriteLine("No se encontro el Asistente con id " + $"{id}");

            }

            Console.ReadKey();
            Main();

        }

        static void ReadAll()
        {
            Console.Clear();
            Console.WriteLine("Asistentes: ");

            List<Asistente> asistente = actividad.ReadAll();

            //Console.WriteLine("ASISTENTES EN READ ALL " + asistente.Count);

            if (asistente.Count != 0)
            {
                foreach (var a in asistente)
                {
                    Console.WriteLine("id " + $"{a.id}");
                    Console.WriteLine("Nombre " + $"{a.nombre}");
                    Console.WriteLine("Apellido " + $"{a.apellido}");
                    Console.WriteLine("Edad " + $"{a.edad}");
                    Console.WriteLine("Turno " + $"{a.turno}");
                    Console.WriteLine("Descripcion " + $"{a.descripcion}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron Asistentes");
            }

            Console.ReadKey();
            Main();

        }

        static void Delete()
        {
            Console.Clear();
            Console.WriteLine("Borrar Asistente");

            Console.WriteLine("Ingrese su id: ");
            int id = int.Parse(Console.ReadLine());

            bool eliminado = actividad.Delete(id);

            if (eliminado)
            {
                Console.WriteLine("Asistente eliminado");
            }
            else
            {
                Console.WriteLine("Asistente no eliminado");
            }

            Console.ReadKey();
            Main();

        }

        static void BuscarAsistentePorEdad()
        {
            Console.Clear();
            Console.WriteLine("Buscando Asistentes por Edad");

            Console.WriteLine("Ingrese la edad buscada: ");
            short edad = short.Parse(Console.ReadLine());

            List<Asistente> buscados = actividad.BuscarAsistentePorEdad(edad);

            if (buscados.Count() > 0)
            {
                Console.WriteLine("Se encontraron " + buscados.Count() + " Asistentes con la edad solicitada");
            }
            else
            {
                Console.WriteLine("No se encontraron Asistentes con esa edad ");
            }

            Console.ReadKey();
            Main();

        }

        static void BuscarAsistentePorTurno()
        {
            Console.Clear();
            Console.WriteLine("Buscando Asistentes por Turno");

            Console.WriteLine("Ingrese el turno buscado: ");
            string turno = Console.ReadLine();

            List<Asistente> buscados = actividad.BuscarAsistentePorTurno(turno);

            if (buscados.Count() > 0)
            {
                Console.WriteLine("Se encontraron " + buscados.Count() + " Asistentes en el turno solicitado");
            }
            else
            {
                Console.WriteLine("No se encontraron Asistentes en el turno solicitado ");
            }

            Console.ReadKey();
            Main();
        }
    }
}
