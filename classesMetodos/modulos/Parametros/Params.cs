namespace ClassesMetodos{
    class Params{

        public static void Recepcionar(params string[] pessoas){
            foreach(var pessoa in pessoas){
                Console.WriteLine($"Ola {pessoa}");
            }
        }

        public static void Contador(params int[] numero){
            foreach(int num in numero){
                Console.WriteLine($"E contando {num}");
            }
        }
        public static void Executar(){
            Recepcionar("Andre","Julia","Anthony","Laura");
            Contador(1,2,3,4,5,6,7,8,9,10);

        }
    }
}