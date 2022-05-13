using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;


namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // Estrturas de Controle
                {"Estrutura if - Estrturas de Controle", EstruturasIf.Executar},
                {"Estrutura if / Else - Estrturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura if / Else / if - Estrturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrturas de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estrturas de Controle", EstruturaForEach.Executar},
                {"Usando o Breack - Estrturas de Controle", UsandoBreak.Executar},
                {"Usando o Continue - Estrturas de Controle", UsandoContinue.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}