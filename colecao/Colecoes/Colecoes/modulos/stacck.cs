using System;
using System.Collections.Generic;
using System.Collections;

namespace Colecoes.modulos{
    class ColecaoStack{
        public static void Executar(){
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach(var item in pilha){
                System.Console.WriteLine($"{item}");
            }
            System.Console.WriteLine($"{pilha.Pop()}");
            System.Console.WriteLine($"{pilha.Peek()}");
            System.Console.WriteLine(pilha.Count);
        }

    }
}