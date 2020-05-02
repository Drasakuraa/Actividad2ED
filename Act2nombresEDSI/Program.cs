using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act2nombresEDSI
{
    class Program
    {

        static void Main(string[] args)
        {
            //Se debe utilizar la estructura de arreglos unidimensionales: 
            //Hacer una aplicación en C# de consola, donde se solicite 
            //ingresar nombre de 10 personas, al terminar de ingresar esas 10 personas, 
            //debe de mostrar una lista con los nombres ingresados.

            string[] nombresPersonas = new string[10];
            for (int i = 0; i < nombresPersonas.Length; i++)
            {
                Console.Write($"Escriba el nombre de la persona { (i + 1) }: ");
                nombresPersonas[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombresPersonas.Length; i++)
            {
                Console.WriteLine($"El nombre de la persona { (i + 1) } es: { nombresPersonas[i]}");
            }
            Console.ReadLine();

        }

    }
}
    
