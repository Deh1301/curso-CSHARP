class Var
{
    public static void Main(string[] args)
    {
        Console.WriteLine("De 1 a 4 escolha uma opçao:");
        int.TryParse(Console.ReadLine(), out int nota);
        switch (nota){
            case 1:
            Console.WriteLine("Voce escolheu Adição");
            Console.WriteLine("Entre com o primeiro numero:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo numero:");
            int num2 = int.Parse(Console.ReadLine());
            int somar = num+num2;
            Console.WriteLine($"A soma entre os dois é {somar}");

            break;
            case 2: 
            Console.WriteLine("Voce escolheu Subtração");
            
            Console.WriteLine("Entre com o primeiro numero:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());
            int subtrair = numero-numero2;
            Console.WriteLine($"A subtração entre os dois é {subtrair}");

            break;

            case 3: 
            Console.WriteLine("Voce escolheu Multiplicação:");
            Console.WriteLine("Digite o primeiro numero");
            int numMulti = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int numMulti2 = int.Parse(Console.ReadLine());
            int multiplicar = numMulti * numMulti2;
            Console.WriteLine($"A multiplicação dos dois numeros é {multiplicar}");

            break;

            case 4:
            Console.WriteLine("Voce escolheu divisão");
            Console.WriteLine("Digite o primeiro numero:");
            int dividirNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int dividirNum2 = int.Parse(Console.ReadLine());
            int divisao = dividirNum / dividirNum2;
            Console.WriteLine($"A divisão dos dois numeros é {divisao}");
            break;
            default:
            Console.WriteLine("Opção Invalida");
            break;

        }





    }
}