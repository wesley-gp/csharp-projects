namespace Curso02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            while (true)
            {
                Console.WriteLine("digite sua senha: ");
                senha = int.Parse(Console.ReadLine());
                if (senha == 2002) 
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else 
                {
                    Console.WriteLine("Senha errada, tente novamente");
                    continue;
                }
            }
        }
    }
}