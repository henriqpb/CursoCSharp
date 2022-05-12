using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            //"1" -> 1

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            //double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //converte . e , independente da lingua do sistema

            Console.WriteLine($"{nome} {idade} R${salario}");

        }
    }
}
