namespace ClassesMetodos{

    public class Automovel{
        public string Marca {get; set;}
        public string Modelo {get;set;}

        

        public Automovel(string marca,string modelo){
            Marca = marca;
            Modelo = modelo;
            
            
        }

        public Automovel(){}

        
    }

    public class Humano {
        public string Identidade {get;set;}
        public int Anos {get;set;}

        public Humano(string identidade, int anos){
            Identidade = identidade;
            Anos = anos;

        }
    }
    class GetSet{
        public static void Executar(){
            var carro1 = new Automovel("Chevrolet","Celta");
            var carro2 = new Automovel("Honda Civic", "Honda");
    
            Console.WriteLine(carro1.Modelo);
            Console.WriteLine(carro1.Marca);

            Console.WriteLine(carro2.Modelo);
            Console.WriteLine(carro2.Marca);




            carro1.Modelo = "Corsa";
            Console.WriteLine(carro1.Modelo);

            var pessoa = new Humano("André", 24);
            Console.WriteLine(pessoa.Identidade);
            Console.WriteLine(pessoa.Anos);
            

        }
    }
}