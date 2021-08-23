using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLab01_1
{
    class Program
    {
        static void Raiz()
        {
            for(int a = 1; a <= 10; a++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es {1}", a, Math.Sqrt(a));
            }
        }
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            String opcion;
            
            do
            {
                Console.Clear();
                Console.WriteLine("[1] SUMA DE DOS NUMEROS");
                Console.WriteLine("[2] IMPRIMIR LA RAIZ CUADRADA DE LOS PRIMEROS NUMEROS ENTEROS");
                Console.WriteLine("[0] SALIR");
                Console.WriteLine("ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a,b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando....");
                        Raiz();
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
    }
}
