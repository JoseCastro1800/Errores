using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudiante = new List<Estudiante>();

            var agregar = true;

            while(agregar)
            {
                

                try
                {
                    var E = new Estudiante();
                    int Ma = E.Matricula;

                    Console.WriteLine("Ingrese Matricula");
                    int Matricula = 0;
                    bool result;

                    result = int.TryParse(Console.ReadLine(), out Matricula);

                    if (result == false)
                    {
                        Console.WriteLine("Ingrese un numero");
                    }

                    Console.WriteLine("Ingrese Nombre:");
                    E.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Carrera:");
                    E.Carrera = Console.ReadLine();
                    Console.WriteLine("Ingrese Semestre:");
                    E.Semestre = Convert.ToInt32(Console.ReadLine());

                   if (Console.ReadLine()=="N")
                    {
                        agregar = false;
                    }


                }
                catch(Exception ex)
                {
                    Console.WriteLine("Intente nuevamente");
                }
                Console.WriteLine("Desea agregar otro usuario");

            }
            
            Console.ReadKey();

        }
    }
}
