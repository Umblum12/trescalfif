using System;

namespace trescalfif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            Double Cal1, Cal2, Cal3, resultado;
            //ingresar los valores de variables
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ingresa la primer calificacion: ");
            Cal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la segunda calificacion: ");
            Cal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la tercer calificacion: ");
            Cal3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            //Colocar el procedimiento
            if (Cal1 >= 5 || Cal2 >= 5 || Cal3 >= 5)
            {
                Console.WriteLine("el promedio es" + (Cal1+Cal2+Cal3)/3);
            }
            //Imprimir en pantalla el resultado
            if (resultado >= 10)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Tu calificacion es aprobatoria: " + resultado);
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Tu calificacion es reprobatoria: " + resultado);
                Console.WriteLine("--------------------------------------------");
            }
            Console.ReadKey(true);
        }
    }
}
