namespace fundamentosCs{
    public class OpAritimeticos{
        public static void operadoresAri(){
            var preco = 1000;
            var imposto = 350;
            var desconto = 0.1;
            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);
            Console.WriteLine($"o preço total é {totalDesconto} ");
            int valorPS4 = 2900;
            int valorEntrada = 500;
            int valorRestante = valorPS4 - valorEntrada;
            Console.WriteLine($"O valor restante a pagar é {valorRestante}");

            double peso = 64.2;
            double altura = 1.61;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"o calculo do imc é: {imc}");

            double alt = 240.3;
            double largura = 56.4;
            double raio = alt / largura * largura;
            Console.WriteLine($"resultado é {raio}");
            
        }
    }
}