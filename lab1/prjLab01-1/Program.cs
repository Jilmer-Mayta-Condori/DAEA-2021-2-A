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

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static double Division(int a, int b)
        {
            return a / b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        static double ConversorTemperatura (int temperatura, int conversion)
        {
            double valorconvertivo;
            if ( conversion == 1)
            {
                valorconvertivo = ((5*(temperatura-32))/9);
                return valorconvertivo;
            }
            else
            {
                valorconvertivo = (((9*temperatura)/5)+32);
                return valorconvertivo;
            }
        }

        static void NumerosPrimos()
        {
            Console.WriteLine("Los 10 primeros numero primos son: ");
            int contador = 0;
            int numero = 2;
            while (true)
            {
                if ( contador == 10)
                {
                    break;
                }
                else
                {
                    int contadorprimos = 0;
                    for (int x = 1; x <= numero ; x++)
                    {
                        if ( numero % x == 0)
                        {
                            contadorprimos++;
                        }
                    }
                    if (contadorprimos == 2)
                    {
                        Console.WriteLine(numero);
                        contador++;
                    }
                    numero++;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            String opcion;
            int a,b;
            
            do
            {
                Console.Clear();
                Console.WriteLine("[1] SUMA DE DOS NUMEROS");
                Console.WriteLine("[2] RESTA DE DOS NUMEROS");
                Console.WriteLine("[3] MULTIPLICACION DE DOS NUMEROS");
                Console.WriteLine("[4] DIVISION DE DOS NUMEROS");
                Console.WriteLine("[5] IMPRIMIR LA RAIZ CUADRADA DE LOS PRIMEROS NUMEROS ENTEROS");
                Console.WriteLine("[6] IMPRIMIR LOS 10 PRIMEROS NUMEROS PRIMOS");
                Console.WriteLine("[6] CONVERSOR DE TEMPERATURA");
                Console.WriteLine("[0] SALIR");
                Console.WriteLine("ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer valor");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a,b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer valor");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Resta(a,b));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer valor");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Multiplicacion(a,b));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer valor");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Division(a,b));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando....");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        NumerosPrimos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el valor de temperatura");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El valor ingresado desea convertirlo a:");
                        Console.WriteLine("[1] Centígrados");
                        Console.WriteLine("[2] Fahrenheit");
                        Console.WriteLine("Ingresa una opcion y presiona ENTER");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (b == 2)
                        {
                            Console.WriteLine("La conversion de {0} grados centigrados es {1} grados fahrenheit", a, ConversorTemperatura(a,b));
                        }
                        else
                        {
                            Console.WriteLine("La conversion de {0} grados fahrenheit es {1} grados centigrados", a, ConversorTemperatura(a,b));
                        }
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
    }
}
