namespace fundamentosCs{
    public class Converte{
        public static void Conversao(){
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 6.0;
            Console.WriteLine($"O valor inicial é: {nota}");
            int notaTruncada = (int) nota;
            Console.WriteLine($"Nota truncada: seu valor é {notaTruncada}");
            Console.WriteLine("Digite a idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"idade inserida: {idadeInteiro}");
            idadeInteiro= Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");
            Console.WriteLine("Digite o numero:");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine($"Resultado é {numero}");
          
        }
        
    }
}
