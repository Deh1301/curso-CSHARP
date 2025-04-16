namespace Estruturas{
    public class UsandoBreak{
        public static void usoBreak(){
            Random random = new Random();
            int numero = random.Next(1,51);

            Console.WriteLine($"O numero é {numero}");
            for (int i = 0; i <= 50; i++){
                Console.WriteLine($"O valor que eu quero é esse: '{numero}'. O {i} é o numero que eu quero?");
                if(i == numero){
                    Console.WriteLine("Sim");
                    break;

                } else{
                    Console.WriteLine("Não");
                }
            }
            Console.WriteLine("Fim!");
        }
    }
}