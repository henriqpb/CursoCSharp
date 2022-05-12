using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class PrimeiroPrograma
    {
        public static void Executar()
        {
            //Console.Write("Primeiro ");
            //Console.WriteLine("Programa");
            //Console.WriteLine("Terminou!");

            //-EXE-01
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());

            //int X = A + B;
            //Console.WriteLine("X = " + X);


            //-EXE-02
            //CultureInfo cultura = new CultureInfo("en-US");

            //double PI = 3.14159;
            //double raio = double.Parse(Console.ReadLine());
            //double areaCirculo = PI * Math.Pow(raio, 2);
            //string respostaString = areaCirculo.ToString("F4", cultura);

            //Console.WriteLine("A="+respostaString);


            //-EXE-03
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());

            //int SOMA = A + B;
            //Console.WriteLine("SOMA = " + SOMA);

            //-EXE-04
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());

            //int PROD = A * B;
            //Console.WriteLine("PROD = " + PROD);

            //-EXE-05
            //CultureInfo cultura = new CultureInfo("en-US");
            //double A = double.Parse(Console.ReadLine());
            //double B = double.Parse(Console.ReadLine());

            //double media = ((A*3.5) + (B*7.5)) /11;
            //string respostaString = media.ToString("F5", cultura);
            //Console.WriteLine("MEDIA = " + respostaString);

            //-EXE-06
            //CultureInfo cultura = new CultureInfo("en-US");
            //double A = double.Parse(Console.ReadLine());
            //double B = double.Parse(Console.ReadLine());
            //double C = double.Parse(Console.ReadLine());

            //double media = ((A * 2) + (B * 3) + (C * 5) )  / 10;
            //string respostaString = media.ToString("F1", cultura);
            //Console.WriteLine("MEDIA = " + respostaString);


            //-EXE-07

            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());

            //int diferenca = (A*B) - (C*D);

            //Console.WriteLine("DIFERENCA = " + diferenca);

            //-EXE-08

            //CultureInfo cultura = new CultureInfo("en-US");

            //int numFunc = int.Parse(Console.ReadLine());
            //int horas = int.Parse(Console.ReadLine());
            //double valorHoras = double.Parse(Console.ReadLine());

            //double salario = horas * valorHoras;
            //string respostaString = salario.ToString("F2", cultura);


            //Console.WriteLine("NUMBER " + numFunc);
            //Console.WriteLine("SALARY = U$ " + respostaString);



            //-EXE-1009-SALARIO COM BONUS------------------------------------------------------------------------

            //CultureInfo cultura = new CultureInfo("en-US");

            //string nomeFunc = Console.ReadLine();
            //double salario = double.Parse(Console.ReadLine());
            //double totalVendas = double.Parse(Console.ReadLine());

            //double totalReceber = salario + (totalVendas * 0.15);

            //string respostaString = totalReceber.ToString("F2", cultura);
            //Console.WriteLine("TOTAL = R$ " + respostaString);



            //-EXE-1010-CALCULO SIMPLES--------------------------------------------------------

            //CultureInfo cultura = new CultureInfo("en-US");

            ////id qnt valor

            //string[] peca1 = Console.ReadLine().Split(' ');
            //string[] peca2 = Console.ReadLine().Split(' ');


            //int quantidade1 = Convert.ToInt32(peca1[1]);

            //double preco1 = Convert.ToDouble(peca1[2]);

            //int quantidade2 = Convert.ToInt32(peca2[1]);

            //double preco2 = Convert.ToDouble(peca2[2]);


            //double valor1 = quantidade1  * preco1 ;
            //double valor2 = quantidade2  * preco2 ;
            //double valorTotal = valor1 + valor2 ;

            //string respostaString = valorTotal.ToString("F2", cultura);
            //Console.WriteLine("VALOR A PAGAR: R$ " + respostaString);


            ////-EXE-1013-O MAIOR------------------------------------------------------





            ////-EXE-1018-CEDULAS------------------------------------------------------

            //int entradaValor =  int.Parse(Console.ReadLine());

            ////FAZER UM LAÇO PELAMOR DE DEUS

            //int nota100 = (entradaValor / 100);
            //int restoDe100 = (entradaValor % 100);
            //int nota50 = (restoDe100 / 50);
            //int restoDe50 = (restoDe100 % 50);
            //int nota20 = (restoDe50 / 20);
            //int restoDe20 = (restoDe50 % 20);
            //int nota10 = (restoDe20 / 10);
            //int restoDe10 = (restoDe20 % 10);
            //int nota5 = (restoDe10 / 5);
            //int restoDe5 = (restoDe10 % 5);
            //int nota2 = (restoDe5 / 2);
            //int restoDe2 = (restoDe5 % 2);
            //int nota1 = (restoDe2 / 1);
            //int restoDe1 = (restoDe2 % 1);


            //Console.WriteLine(entradaValor);
            //Console.WriteLine(nota100 + " nota(s) de R$ 100,00");

            //Console.WriteLine(nota50 + " nota(s) de R$ 50,00");

            //Console.WriteLine(nota20 + " nota(s) de R$ 20,00");

            //Console.WriteLine(nota10 + " nota(s) de R$ 10,00");

            //Console.WriteLine(nota5 + " nota(s) de R$ 5,00");

            //Console.WriteLine(nota2 + " nota(s) de R$ 2,00");

            //Console.WriteLine(nota1 + " nota(s) de R$ 1,00");







            ////-EXE-1019-CONVERSÃO DE TEMPO------------------------------------------------------

            //int entradaSegundos =  int.Parse(Console.ReadLine());

            //int hora = (entradaSegundos / 3600);
            //int restoHora = (entradaSegundos % 3600);
            //int minuto = (restoHora / 60);
            //int segundo = (restoHora % 60);


            //Console.WriteLine(hora + ":" + minuto + ":" + segundo);



            //-EXE-1020-IDADE EM DIAS------------------------------------------------------

            //int entradaDias =  int.Parse(Console.ReadLine());


            //int anos = (entradaDias / 365);

            //int anosResto = (entradaDias % 365);

            //int meses = (anosResto / 30);

            //int dias = (anosResto % 30);


            //Console.WriteLine(anos + " ano (s)");

            //Console.WriteLine(meses + " mes (es)");
            //Console.WriteLine(dias + " dia (s)");


            //-EXE-1021-NOTAS E MOEDAS------------------------------------------------------


            int entradaValor = int.Parse(Console.ReadLine());

            //FAZER UM LAÇO PELAMOR DE DEUS

            int nota100 = (entradaValor / 100);
            int restoDe100 = (entradaValor % 100);
            int nota50 = (restoDe100 / 50);
            int restoDe50 = (restoDe100 % 50);
            int nota20 = (restoDe50 / 20);
            int restoDe20 = (restoDe50 % 20);
            int nota10 = (restoDe20 / 10);
            int restoDe10 = (restoDe20 % 10);
            int nota5 = (restoDe10 / 5);
            int restoDe5 = (restoDe10 % 5);
            int nota2 = (restoDe5 / 2);
            int restoDe2 = (restoDe5 % 2);
            int nota1 = (restoDe2 / 1);
            int restoDe1 = (restoDe2 % 1);


            Console.WriteLine(entradaValor);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");

            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");

            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");

            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");

            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");

            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");

            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");

        }

    }
}
