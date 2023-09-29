using ExamenT.metodos;
using ExamenT;

namespace ExamenT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int result = Examen.Suma(n);
            Console.WriteLine($"El resultado de la suma es: {result}");




            Examen examen = new Examen();
            Console.WriteLine("Ingresa un numero");
            int nDes = int.Parse(Console.ReadLine());
            examen.Descendentes(nDes);


            Console.Write("Ingrese el valor máximo: ");
            if (int.TryParse(Console.ReadLine(), out int valorMaximo))
            {
                Examen numeros = new Examen();
                numeros.Ascendentes(0, valorMaximo);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
            }


                Examen menu = new Examen();
                menu.SeleccionarOpcion();
            



        }

    }
}