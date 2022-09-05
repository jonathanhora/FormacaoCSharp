using System;
using System.Globalization;

namespace Exec01Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retagulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();
            double diagonal = retangulo.Diagonal();

            Console.WriteLine($"AREA = {area.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {perimetro.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
