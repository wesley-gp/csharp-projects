using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar um Programa que calcule a idade do cliente a partir da sua data de nascimento
            var anoAtual = DateTime.Now.Year; 
            Console.Write("Em que ano você nasceu? ");
            int ano = int.Parse(Console.ReadLine());
            int idade = anoAtual - ano;
            Console.WriteLine("você tem {0} anos!", idade);
            Console.ReadLine();
        }
    }
}
