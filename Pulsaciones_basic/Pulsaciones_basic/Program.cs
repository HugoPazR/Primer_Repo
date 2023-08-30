using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsaciones_basic
{
    internal class Program
    {
        List<Personas> ListPerson = new List<Personas>();
        
        public void Registrar()
        {
            String Id, name;
            char sex, SON = 'S';
            int years;
            float pulsa = 0;

            

            while (SON == 'S')
            {
                Personas Person = new Personas();

                Console.Clear();
                Console.WriteLine("**** REGISTROS DE DATOS PACIENTE ****\n");

                Console.WriteLine("Digite su identificacion: "); Id = Console.ReadLine();
                Person.setIdentificacion(Id);

                Console.WriteLine("Digite su nombre: "); name = Console.ReadLine();
                Person.setNombre(name);

                Console.WriteLine("Digite su edad: "); years = int.Parse(Console.ReadLine());
                Person.setEdad(years);

                do
                {
                    Console.WriteLine("Digite su sexo: (M -> Masculino, F -> Femenino)"); 
                    sex = char.ToUpper(Console.ReadLine()[0]);
                } while ((sex == 'F') && (sex == 'M'));
                Person.setSexo(sex);

                if (sex == 'M')
                {
                    pulsa = (float)((210 - Person.getEdad()) / 10.0);

                }

                if (sex == 'F')
                {
                    pulsa = (float)((220 - Person.getEdad()) / 10.0);

                }

                Person.setPulsaciones(pulsa);

                ListPerson.Add(Person);


                do
                {
                    Console.WriteLine("¿DESEA AGREGAR MAS PACIENTES? (S/N)");
                    SON = char.ToUpper(Console.ReadLine()[0]);

                } while ((SON != 'S') && (SON != 'N'));
                Console.ReadKey();
                
            }

        }

        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("****INFORME DE PACIENTES REGISTRADOS****\n");

            foreach (var person in ListPerson)
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine("****FIN DEL INFORME****");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program ob = new Program();

            char SON = 'S';
            int OP = 0;
            while (SON == 'S')
            {

                Console.Clear();
                Console.WriteLine("CENTRAL DE PROPIETARIOS DE AUTOS\n"
                                + "     MENU DE OPCIONES:\n"
                                + "1. REGISTRAR\n"
                                + "2. MOSTRAR\n"
                                + "3. SALIR\n");
                OP = int.Parse(Console.ReadLine());
                switch (OP)
                {
                    case 1:
                        ob.Registrar();
                        break;
                    case 2:
                        ob.Mostrar();
                        break;
                    case 3:
                        SON = 'N';
                        Console.WriteLine("Saliendo...\npulse una tecla para salir");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("VALOR FUERA DE PARAMETROS");
                        Console.ReadKey();
                        break;

                }

            }

        }
    }
}
