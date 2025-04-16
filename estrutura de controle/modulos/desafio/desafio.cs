namespace Estruturas
{
    public class Desafio
    {
        public static void desafioModulo()
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Esse é o menu, escolha uma opção");
            Console.WriteLine("Opções: 1 , 2 , 3 , 4");
            var entrada = int.TryParse(Console.ReadLine(), out int opcao);
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Voce escolheu a opção 1");
                    Console.WriteLine("Cadastre seu nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"Voce digito: {nome}");
                    break;
                case 2:
                    Console.WriteLine("Voce escolheu a opção 2");
                    Console.WriteLine("Digite sua senha");
                    var senha = Console.ReadLine();
                    var senhaAlterar = senha == "1234"? "Voce digito corretamente":"voce erro";
                    Console.WriteLine(senhaAlterar);
                    if(senhaAlterar == "Voce digito corretamente"){
                        Console.WriteLine("Conhecer planos");
                    }
                    break;

            }
        }


    }
}
