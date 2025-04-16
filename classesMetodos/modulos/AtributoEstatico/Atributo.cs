namespace ClassesMetodos{
    public class Produto{
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto){
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto(){

        }

        public double CalcDesconto(){
            return Preco - Preco * Desconto;
        }
    }

    

    class AtributosEstaticos{
        public static void Executar(){

            var produto = new Produto(){
                Nome = "Carro",
                Preco = 54.000,
                Desconto = 0.2
            };

            Console.WriteLine("preco com desconto {0}", produto.CalcDesconto());

        }
    }
}