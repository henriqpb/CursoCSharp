﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.1759;//tipo nome = valor;
            

            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));
            

            
            CultureInfo cultura = new CultureInfo("en-US");//tipo nome = valor;
            Console.WriteLine(valor.ToString("C0", cultura));
            Console.WriteLine(valor.ToString("#.####", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //preenche zeros a esquerda.



        }   

    }
}
