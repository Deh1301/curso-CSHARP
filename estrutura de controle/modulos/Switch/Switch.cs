namespace Estruturas
{
    public class EstruturaSwitch
    {
        public static void SwitchCase()
        {
            Console.WriteLine("Avalie o atendimento de 1 a 5");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota)
            {
                case 1:
                    case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                
            }



     
        }
        public static void SwitchCase2(){
            Console.WriteLine("Agora digite a nota:");
            int.TryParse(Console.ReadLine(), out int nota);


            switch (nota){
                case 1:
                Console.WriteLine("Pessima nota");
                break;
                case 10:
                Console.WriteLine("Aprovado com excelencia");
                break;
                default:
                Console.WriteLine("nota invalida");
                break;

            }

            
        }
    }
}

