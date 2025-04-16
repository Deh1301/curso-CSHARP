using System;
using System.Collections;
using System.Collections.Generic;

namespace orientacaoObjeto{
    class Seres{
        public string Nome {get;set;}
        private int Dados{get;set;}

        //internal string Nomes{get;set;}
        //protected double number {get;set;}

        public Seres(string nome, int dados){
            Nome= nome;
            Dados= dados;
        }
        

           public static void executando(){
            Seres seres = new Seres("humano",20);
            System.Console.WriteLine(seres.Dados);

           }
        

    }
    
    // class Resgatar{
    //     public static void Executar(){
    //         Seres seres = new Seres("aaaaa", 20);
    //         System.Console.WriteLine(seres.Dados); // aqui causa erro por que ele nao e acessivel devido a proteção
    //     }
    // }

}