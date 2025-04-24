using System;
using System.Collections.Generic;
using System.Collections;

namespace MetodosFuncao{
    class MetodoFunc{
        public static void Main(string[] args){
            System.Console.WriteLine("\nBem vindo Ao modulo Metodos E Funções!");
            System.Console.WriteLine("\n1-Lambda");
            System.Console.WriteLine("\nSelecione o Exercicio:");

            string escolha = Console.ReadLine();
            switch(escolha){
                case "1":
                System.Console.WriteLine("\nOs valores do exercicio sao:");
                Lambda.Executar();
                break;
            }
        }
    }
}