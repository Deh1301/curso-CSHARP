using System.Collections;
using System.Collections.Generic;
using System;

namespace Colecoes.modulos{
    class Produto{
        public string Nome{get;set;}
        public double Preco{get;set;}

        public Produto(string nome, double preco){
            Nome=nome;
            Preco=preco;
        }
        public override bool Equals(object obj)
        {
            if(obj is Produto produto){
                return this.Nome == produto.Nome;
            } 
            return false;
        }
    }
    class Equalidade{
        public static void Executar(){
            var p1 = new Produto("Caneta",1.99);
            var p2 = new Produto("Caneta",1.99);

            System.Console.WriteLine(p1 == p2);
            System.Console.WriteLine(p1 != p2);
            System.Console.WriteLine(p1.Equals(p2));
        }
    }
}