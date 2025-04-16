namespace ClassesMetodos
{
    public class Carro
    {
        public string Modelo;
        public int Ano;

        public Carro(string modelo, int ano) //sem o this e so colocar m e a minusculo nos atributos do construtor
        {
            Modelo = modelo;
            Ano = ano;
        }

        public Carro()
        {
            //Construtor padrão quando nao recebe nenhum parametro
        }
    }


    class Construtores
    {
        public static void ExercicioCarro()
        {
            var carro2 = new Carro();    //construtor padrao
            carro2.Modelo = "Corolla";
            carro2.Ano = 2020;
            Console.WriteLine($"O carro é {carro2.Modelo} e o ano é {carro2.Ano}");


            Carro carro = new Carro("Honda Civic", 2007);
            // carro.Modelo = "Honda Civic";
            // carro.Ano = 2007;
            Console.WriteLine($"O carro é {carro.Modelo} e o ano é {carro.Ano}");

            var carro3 = new Carro()
            {
                Ano = 2010,
                Modelo = "Celta"
            };
            Console.WriteLine($"O carro é {carro3.Modelo} e o ano é {carro3.Ano}");






        }
    }
}