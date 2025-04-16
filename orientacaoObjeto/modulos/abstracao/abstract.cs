using System;
namespace orientacaoObjeto{
    abstract class Animal{
        
        public abstract void Som();
    }

    class Cachorro: Animal{
        public override void Som()
        {
            System.Console.WriteLine("Au Au");
        }
    }

    class Gato: Animal{
        public override void Som()
        {
            System.Console.WriteLine("Miau miau");
        }
    }

    class Abstract{
        public static void Executar(){
            List<Animal> animals = new List<Animal>(){
                new Cachorro(),
                new Gato()

            };
            foreach(var animal in animals){
                animal.Som();
            }
        }
    }
}