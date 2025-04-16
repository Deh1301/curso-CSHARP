namespace ClassesMetodos{
    class Calcular{
        public int Somar(int a, int b){
            return a+b;
        }
        // public int Somar(int c, int d, int e){ //metodo nao se repete a assinatura . sua assinatura e unica e no caso seria o nome e os parametro

        //     return c + d + e;
        // }
        public int Subtrair(int a, int b){
            return a - b;
        }
    }

    class CalculoAvançado{
        int memoria;
        public CalculoAvançado Somar(int a){
            memoria += a;
            return this;
        }

        public CalculoAvançado Multiplicar (int a){
            memoria *= a;
            return this;
        }

        public CalculoAvançado Limpar(){
            Console.WriteLine(memoria);
            return this;
        }

        public CalculoAvançado Saida(){
            Console.WriteLine(memoria);
            return this;
        }


    }

    public class Informar {
        
        public string Dados;
        

    }

    class MetodoRetorno{
        public static void Executar(){
            var calculando = new Calcular();
            var resultado = calculando.Somar(2,2);
            Console.WriteLine(resultado);
            Console.WriteLine(calculando.Subtrair(41,4));

            var calculos = new CalculoAvançado();
            calculos.Somar(3).Multiplicar(6).Limpar().Saida();

            Informar informar = new Informar();
            informar.Dados = "Julia Gostosa";
            Console.WriteLine(informar);

        }
    }

    
    
}