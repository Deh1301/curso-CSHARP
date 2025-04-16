namespace Estruturas{
    public class IfElse{
        public static void IfElseCondicao(){
            // int num = -10;
            // if(num == 10){
            //     Console.WriteLine("O numero é positivo");

            // } 
            // bool comportamento = false;
            // string entrada ;
            // Console.WriteLine("Digite a nota do aluno:");
            // entrada = Console.ReadLine();
            // double.TryParse(entrada, out double nota);

            // Console.WriteLine("Possui bom comportamento? (S/N)");
            // entrada = Console.ReadLine();
            // comportamento = entrada.ToLower() == "s";
            
            // if(nota >= 9.0 && comportamento){
            //     Console.WriteLine("Quadro de honra!");
            // }

            Console.WriteLine("Digite o valor:");
            string nota = Console.ReadLine();
            Double.TryParse(nota, out double valor);
            if(valor >= 9.0){
                Console.WriteLine("Quadro de honra");
            } else if(valor >= 7){
                Console.WriteLine("Aprovado");
            } else if(valor >= 5){
                Console.WriteLine("Recuperação");

            } else {
                Console.WriteLine("Reprovado");
            }


        }
    }
}