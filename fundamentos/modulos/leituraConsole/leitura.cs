using System.Globalization;

namespace fundamentosCs
{
    public class LeituraConsole
    {
        public static void Dados()
        {
            Console.WriteLine("Seja Bem vindo");
            Console.WriteLine("Como podemos chama-lo?");
            var nome = Console.ReadLine();
            Console.WriteLine($"Ola {nome}");
            Console.WriteLine($"Agora que sabemos sua identidade {nome}");
            Console.WriteLine("Gostariamos de saber a sua idade, qual seria?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"A idade é {idade} anos");
            if (idade >= 18)
            {
                Console.WriteLine("Legal, voce é maior de idade");
              

            }
        }
    }
}