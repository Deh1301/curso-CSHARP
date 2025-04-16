using System;
using System.Collections;
using System.Collections.Generic;

namespace Colecoes.modulos{
    class ColecoesQueueFila{
        public static void Executar(){
            var fila = new Queue<string>();
            fila.Enqueue("André");
            fila.Enqueue("Julia");
            fila.Enqueue("Anthony");

            System.Console.WriteLine(fila.Peek());
            System.Console.WriteLine(fila.Count());
            System.Console.WriteLine(fila.Dequeue());
            System.Console.WriteLine(fila.Count());

            Queue<string> nome = new Queue<string>();
          
            nome.Enqueue("Andre");
            nome.Enqueue("Julia");

            System.Console.WriteLine("os nomes sao \n");

            foreach(string nomes in nome){
                System.Console.WriteLine(nomes);
            }
           
        }
    }
}