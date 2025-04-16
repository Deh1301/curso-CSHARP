namespace ClassesMetodos{
    public class OpcaoCarro{
        double desconto = 0.1;
        string nome;
        public string Nome{
            get {
                return "Opção : " + nome;
            }
            set {
                nome = value;
            }
        }
        public double Preco {get;set;}
        public double PrecoDesconto{
            get => Preco - (desconto * Preco);
        }

        public OpcaoCarro(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }

    }
    class Props{
        public static void Executar(){
            var carro = new OpcaoCarro("Vidro Elétrico", 3499.9);
            Console.WriteLine(carro.Nome);
            Console.WriteLine(carro.Preco);
        }
    }
}