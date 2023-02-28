using System.Globalization;



namespace Curso01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, areaTriangulo, areaCirculo, areaQuadrado, areaTrapezio,areaRetangulo, pi= 3.14159f;
            Console.WriteLine("Digite o valor de A, B, C. SEPARE OS VALORES COM SPACE");
            string[] v = Console.ReadLine().Split(" ");
            a = float.Parse(v[0]);
            b = float.Parse(v[1]);
            c = float.Parse(v[2]);
            areaTriangulo = (a * c) / 2;
            areaCirculo = pi * (c * c);
            areaTrapezio = ((a + b) * c) / 2;
            areaQuadrado = b * b;
            areaRetangulo = a * b;
            Console.WriteLine("Triangulo: {0}",areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: {0}", areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: {0}", areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: {0}", areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: {0}", areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}