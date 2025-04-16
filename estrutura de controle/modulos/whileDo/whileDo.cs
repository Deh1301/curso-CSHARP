namespace Estruturas
{
    public class WhileDo
    {
        public static void whileEdoWhile()
        {
            int palpite = 0;
            Random random = new Random();
            int numeroAlt = random.Next(1, 20);
            bool numeroEncontrado = false;
            int tentativaRes = 5;
            int tentativa = 0;

            while (tentativaRes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Qual o palpite:");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                tentativa++;
                tentativaRes--;

                if (numeroAlt == palpite)
                {
                    numeroEncontrado = true;
                    var cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado em {tentativaRes}");
                    Console.BackgroundColor = cor;

                }
                else if (palpite > numeroAlt)
                {
                    Console.WriteLine("O numero é maior tente novamente!!");
                }
                else if (palpite < numeroAlt)
                {
                    Console.WriteLine("O numero é menor, tente novamente");
                }

            }




        }

    }
    public class SegundoWhile
    {
        public static void WhileDois()
        {
            int proposta = 0;
            Random random1 = new Random();
            int numeroOp = random1.Next(1, 5);
            bool numeroAchado = false;
            int nTentativas = 0;
            int numTentativas = 5;

            while (numTentativas > 0 && !numeroAchado)
            {
                Console.WriteLine("Qual é o numero?");
                string entrar = Console.ReadLine();
                int.TryParse(entrar, out proposta);
                nTentativas++;
                numTentativas--;

                if (numeroOp == proposta)
                {
                    var cores = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns Numero achado");
                    Console.ForegroundColor = cores;
                    numeroAchado = true;


                }
                else if (proposta != numeroOp && numTentativas == 0)
                {
                    var corError = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Voce excedeu o numero de tentativas");
                    Console.ForegroundColor = corError;
                }

            }

        }
    }

    public class DoWhile{
        public static void doWhile(){
            string entrada;
            do{
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem vindo {entrada}");
                
                Console.WriteLine("Desja Continuar?S/N");
                
                entrada= Console.ReadLine();
                
                

            }while(entrada.ToLower() == "s");
        }
    }
}
