using System;
using System.Collections;
using System.Collections.Generic;

namespace orientacaoObjeto{
    interface IAnimal{
        public void Som();

    }
    class Bicho : IAnimal{
        public void Som()
        {
            System.Console.WriteLine("i ala");
        }
    }

    class Interface{
        public static void Executar(){
            Bicho bicho = new Bicho();
            bicho.Som();
        }
    }
}