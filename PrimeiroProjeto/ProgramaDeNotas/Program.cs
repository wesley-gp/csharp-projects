using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ler notas de alunos e seus nomes enquanto não dizer pra parar e
            mostrar a menor e maior nota e o seu respectivo nome. MOSTRAR A MEDIA DA TURMA TB*/
            string aluno, nomeMaior="", nomeMenor="", continuar;
            float nota, notaMaior=0, notaMenor=0, somaNota = 0, media;
            int cont = 1;
            Console.WriteLine("Leitor de Nota");
            while (true)
            {
                Console.Write("Digite o nome do(a) {0}° Aluno(a): ",cont);
                aluno = Console.ReadLine();
                Console.Write("Digite a nota do(a) {0}° Aluno(a): ",cont);
                nota = float.Parse(Console.ReadLine());
                if (nota>notaMaior)
                {
                    notaMaior = nota;
                    nomeMaior = aluno;
                }
                if (cont == 1 || nota < notaMenor)
                {
                    notaMenor = nota;
                    nomeMenor = aluno;
                }
                somaNota += nota;
                cont++;
                Console.Write("quer continuar? [S/N]: ");
                continuar = Console.ReadLine();
                continuar = continuar.ToUpper();
                if (String.Equals(continuar, "S"))
                {
                    continue;
                }
                else
                {
                    break;  
                }
            }
            media = somaNota / cont;
            Console.WriteLine("A media da turma é {0}!",media);
            Console.WriteLine("O aluno {0} tem a maior nota, que é um {1}.",nomeMaior,notaMaior);
            Console.WriteLine("O aluno {0} tem a menor nota, que é um {1}.", nomeMenor, notaMenor);
            Console.WriteLine("digite qualquer tecla para encerrar.");
            Console.ReadKey();
        }
    }
}
