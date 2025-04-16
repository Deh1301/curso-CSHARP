namespace Estruturas{
    public class UsandoContinue{
        public static void UsoContinue(){
            int intervalo = 50;
            Console.WriteLine($"O numero par é {intervalo}");
            for(int i = 0; i < intervalo ; i++){
                if(i % 2 == 1){
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}