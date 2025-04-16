
namespace ClassesMetodos;

public class Classes
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("\nOla esse é o modulo de classes deseja Continuar? Sim/Não\n");
       
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1-Membros");
        Console.WriteLine("2-Metodos de Retornar");
        System.Console.WriteLine("3-ClassesXobjeto");
        Console.WriteLine("4-Desafio");
        Console.WriteLine("5-Parametros");
        Console.WriteLine("6-GET SET");
        Console.WriteLine("7-Propriedades");
        System.Console.WriteLine("Selecione pelo numero:");
        string entrada = Console.ReadLine();
        switch(entrada){

            case "0":
            Console.WriteLine("Encerrando o programa. Até logo!");
            await Task.Delay(2000);
            return;

            case "1":
            Console.WriteLine("O EXERCICIO ESTA EM EXECUÇÃO ... \n");
            await Task.Delay(2000);
            Membros.MembrosClasse();
            Membros.ProfissaoDados();
            break;
            case "2":

            Console.WriteLine("O EXERCICIO ESTA EM EXECUÇÃO ... \n");
            await Task.Delay(2000);
            MetodoRetorno.Executar();
            Instanciar.Executar();
            MemborEstatico.Executar();
            AtributosEstaticos.Executar();
            break;
            case "3":

            Console.WriteLine("O EXERCICIO ESTA EM EXECUÇÃO ... \n");
            await Task.Delay(2000);
            ClassesXobjeto.classeXobjeto();
            break;
            case "4":

            Console.WriteLine("O EXERCICIO ESTA EM EXECUÇÃO ... \n");
            await Task.Delay(2000);
            Desafio.Executar();
            break;
            case "5":

            Console.WriteLine("O EXERCICIO ESTA EM EXECUÇÃO ... \n");
            await Task.Delay(2000);
            Params.Executar();
            ParametroNomeado.Executar();
            break;

            case "6":
            Console.WriteLine("O EXERCICIO ESTA EM EXECUÇÃO ... \n");
            await Task.Delay(2000);
            GetSet.Executar();
            break;

            case "7":
            Console.WriteLine("O EXERCICIO ESTA EM EXECUÇÃO ... \n");
            await Task.Delay(2000);
            // Props.Executar();
            // Readonly.Executar();
            // Enum.Executar();
            // Enumerado.Executar();
            // Struct.Executar();
            Saida.Executar();
            break;

            default:
            System.Console.WriteLine("Erro ao selecionar, encerrando...");
            await Task.Delay(2000);
            break;


        }
        
    }

}