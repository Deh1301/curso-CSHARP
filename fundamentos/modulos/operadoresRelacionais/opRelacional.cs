namespace fundamentosCs{
    public class OpRelacional{
        public static void operadorRelacional(){
            Console.WriteLine("Valor da media:");
            double notaCorte = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da nota do aluno:");
            double nota = double.Parse(Console.ReadLine());
            Console.WriteLine("a nota é menor? {0}", nota < notaCorte);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10);
            Console.WriteLine("Entro em recuperação? {0}", nota < notaCorte);
            // Console.WriteLine("Foi reprovado?{0}", notaCorte < nota / notaCorte);
        }
    }
}