using System.Collections;
using System.Collections.Generic;
using System;

namespace orientacaoObjeto{
    class Objetos{
        public void Elemento(){

        }
    }

    class Eletronico : Objetos{
        public void Elemento(){
            string Nome = "Controle";
            System.Console.WriteLine($"O nome do elemento é {Nome}");
        }
    }

    class Heranca{
        public static void Executar(){
            Eletronico eletronico = new Eletronico();
            eletronico.Elemento();
        }
    }
}