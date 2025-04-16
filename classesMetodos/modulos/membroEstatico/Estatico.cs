namespace ClassesMetodos{

    public class CalculoEstatico{
        public static int Somar(int a, int b){
            return a + b;  
        }

        public int Multi(int a, int b){
            return a * b;
        }
    }




    class MemborEstatico{
        public static void Executar(){
            var estatico = new CalculoEstatico();
            Console.WriteLine(estatico.Multi(4,4));
            Console.WriteLine(CalculoEstatico.Somar(2,2));
            

        }
    }
}