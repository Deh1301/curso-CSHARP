namespace fundamentosCs{
    public class Variaveis{
        public static void Executar(){
            double raio = 20.0;
            int valor = 10;
            string palavra = "\nessa";
            
            var nome = "Andre";
            const double PI = 3.14;
            double area= PI * raio * raio;
            double dividas = 55.5;
            const double pagamento = 500.00;
            double resultado = pagamento / dividas;
            bool estaChovendo = true;
            byte idade = 45;
            sbyte saldo = sbyte.MinValue;
            short salario = short.MinValue;
            float precoComp = 122.00f;
            char letra = 'b';
            char proxima = (char)(letra + 1);



            Console.WriteLine(raio);
            Console.Write(valor);
            Console.WriteLine(palavra);
            Console.WriteLine("A area é " + area);
            Console.WriteLine(nome);
            Console.WriteLine("o resultado é ",resultado);
            Console.WriteLine("esta chovendo?" + estaChovendo);
            Console.WriteLine(salario);
            Console.WriteLine(saldo);
            Console.WriteLine(precoComp);
            Console.WriteLine(letra);
            Console.WriteLine(proxima);
            Console.WriteLine(idade);
        }
    }
}