using System;
using System.Collections;
using System.Collections.Generic;

namespace orientacaoObjeto{
    abstract class Zoo{
        public abstract void EmitirSom();
        public virtual void Dormir(){
            System.Console.WriteLine("zzzzzzz");

        } 
    }

    class Leao : Zoo{
        public override void EmitirSom()
        {
            System.Console.WriteLine("RRRRRRRRRRRRAAAAAAAAAAAAAAAAGGGGGHHHHHHHHHH");
        }
        public override void Dormir(){
            System.Console.WriteLine("zzz...");
        }
    }

    class Passaro : Zoo{
        public override void EmitirSom()
        {
            System.Console.WriteLine("fiu fiu");
        }
        public override void Dormir(){
            System.Console.WriteLine("zzzzz");

        }
    }
    class Serpente : Zoo{
        public override void EmitirSom()
        {
            System.Console.WriteLine("SHHHHHHHHHHHHH");
        }

        public override void Dormir(){
            System.Console.WriteLine("zzzzzz");
        }
    }

    class Desafio{
        public static void Executar(){
            List<Zoo> zoos = new List<Zoo>(){
                new Leao(),
                new Passaro(),
                new Serpente()

            };
            foreach(var animais in zoos){
                System.Console.WriteLine($"{animais.GetType().Name}:");
                animais.EmitirSom();
                animais.Dormir();
                System.Console.WriteLine();
            }

        }
    }
}