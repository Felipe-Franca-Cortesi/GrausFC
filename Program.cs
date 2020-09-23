using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("------Converter temperatura-----");

            Console.Write("Informe a temperatura em °F: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double c = (f - 32) / 1.8;
            Console.WriteLine($"°F = {f}");
            Console.WriteLine($"{f}°F equivalem a {c}°C");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();


        }
    }
}
