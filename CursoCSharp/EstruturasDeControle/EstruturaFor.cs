using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                
                somatorio += notaAtual;
            }


            //if (tamanhoTurma > 0)
            //{
            //    double media = somatorio / tamanhoTurma;
            //}
            //else
            //{
            //    double media = 0;
            //}

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("A media da turma é: {0}", media);
        }
    }
}
