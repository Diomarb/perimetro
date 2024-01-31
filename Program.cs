using System;
using System.Linq.Expressions;

class PerimetroDelCuadrado
{
    static void Main(string[] args)

    {
        try
        {
            //introducir el lado de el cuadrado//
            Console.WriteLine("Coloque el valor del lado de el cuadrado:");

            double lado = Convert.ToDouble(Console.ReadLine());
            double perimetro = lado * 4;
            //mostrar resultado//
            Console.WriteLine("El perimetro de cuadrado es:" + perimetro);


        }
        catch (FormatException)
        {
            //manejo de exepcion para entrada no numerica//
            Console.WriteLine("Error.Coloque un valor numerico");
        }

    }
}
            

