namespace Curso03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            do
            {
                Console.WriteLine("digite os valores de x e y: ");
                string[] valores = Console.ReadLine().Split(' ');
                 x = int.Parse(valores[0]);
                 y = int.Parse(valores[1]);
                string quadrante = VerQuadrante(x,y);
                Console.WriteLine(quadrante);
            } while (x != 0 && y != 0);
        }
        public static string VerQuadrante(int a, int b)
        {
            string result;
            if (a > 0 && b > 0)
            {
                result = "primeiro";
            }
            else if (a < 0 && b > 0)
            {
                result = "segundo";
            }
            else if (a < 0 && b < 0)
            {
                result = "terceiro";
            }
            else
            {
                result = "quarto";
            }
            return result;
        }
    }
}