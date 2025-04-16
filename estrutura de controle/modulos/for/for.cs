namespace Estruturas
{
    public class ForRepetir
    {
        public static void ForRepticao()
        {
            // int num = 30;
            // for(int i = 0; i <= num ; i++){
            //     Console.WriteLine($"atualizando valor: {i}");
            //     if(i == 30){
            //         Console.WriteLine("Voce chego ao valor total");
            //     }
            // }
            Console.WriteLine("QUAL A MEDIA?");
            double media = double.Parse(Console.ReadLine());
            
            int verificar = 5;
            for (int i = 0; i < verificar; i++)
            {
                double entrada;

                Console.WriteLine("Digite o valor da media do aluno:");
                entrada = double.Parse(Console.ReadLine());
                if (entrada >= media)
                {
                    Console.WriteLine("Aprovado");
                }
                else if (entrada >= 4.0)
                {
                    Console.WriteLine("Recuperação");
                }
                
            }
            
        }
    }
}