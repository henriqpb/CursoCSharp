﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9.0;
            bool bomComportamento = true;
            string resultado = nota > 7.0 && bomComportamento ? "Aprovado" : "Reprovado";

            //primeira parte ? segunda parte : terceira parte;

            Console.WriteLine(resultado);
        }
    }
}
