namespace CalculosDeAreas;
using System;
using System.Globalization;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A: ");
        double a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o valor de B: ");
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o valor de C: ");
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double AreaTriangulo = (a * c) / 2;
        double AreaDoCirculo = 3.14159 * (Math.Pow(c, 2.0));
        double AreaDoTrapezio = ((a + b) * c) / 2;
        double AreaDoQuadrado = Math.Pow(b, 2.0);
        double AreaDoRetangulo = a * b;

        Console.WriteLine("Triângulo: " + AreaTriangulo.ToString("f3", CultureInfo.InvariantCulture));
        Console.WriteLine("Círculo: " + AreaDoCirculo.ToString("f3", CultureInfo.InvariantCulture));
        Console.WriteLine("Trapézio: " + AreaDoTrapezio.ToString("f3", CultureInfo.InvariantCulture));
        Console.WriteLine("Quadrado: " + AreaDoQuadrado.ToString("f3", CultureInfo.InvariantCulture));
        Console.WriteLine("Retangulo: " + AreaDoRetangulo.ToString("f3", CultureInfo.InvariantCulture));
        
    }
}
