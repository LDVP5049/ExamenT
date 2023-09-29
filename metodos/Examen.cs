using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenT.metodos
{
    internal class Examen
    {
        public static int Suma(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + Suma(n - 1);
            }

        }

        public void NumerosMas()
        {
            {
                int suma = 0;

                for (int i = 2; i <= 100; i += 2)
                {
                    suma += i;
                }
            }

        }

        public void Descendentes(int nDes)
        {
            if (nDes >= 0)
            {

                Descendentes(nDes - 1);

            }
        }


        public void Ascendentes(int nAs, int valorMaximo)
        {
            if (nAs <= valorMaximo)
            {
                Console.WriteLine(nAs);
                Ascendentes(nAs + 1, valorMaximo);
            }
        }


        public void SeleccionarOpcion()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Opción 1");
            Console.WriteLine("2. Opción 2");
            Console.WriteLine("3. Opción 3");
            Console.Write("Ingrese el número de la opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ha seleccionado la Opción 1.");
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado la Opción 2.");
                        break;
                    case 3:
                        Console.WriteLine("Ha seleccionado la Opción 3.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }
        }
    }
}
