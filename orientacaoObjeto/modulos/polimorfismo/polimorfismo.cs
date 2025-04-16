using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace orientacaoObjeto{
    abstract class Controle{
        public abstract void Ligar();
    }

    class Tv : Controle{
        public override void Ligar(){
            System.Console.WriteLine("A TV esta ligada");

        }

    }

    class ArCondicionado: Controle{
        public override void Ligar()
        {
            System.Console.WriteLine("O ar esta ligado e gelado");
        }
    }

    class Som : Controle{
        public override void Ligar()
        {
            System.Console.WriteLine("O som esta ligado");
        }
    }

    class Polimorfismo {
        public async Task Executar(){
            List<Controle> controles = new List<Controle>(){

            
            new Tv(),
            new ArCondicionado(),
            new Som()
            };
            foreach(var controle in controles)
        {
            System.Console.WriteLine("Você Aperto o controle");
            await Task.Delay(1000);
            controle.Ligar();
        }
        }
        
    }
}