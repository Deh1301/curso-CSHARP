namespace ClassesMetodos{
    struct Persona{
        public string Nome {get;set;}
        public int Idade {get;set;}

        public Persona(string nome, int idade){
            Nome = nome;
            Idade = idade;

        }

        public void Mensagem(){
         System.Console.WriteLine($"O nome é {Nome}, e a idade é {Idade}" );
        }
    }
    class Saida{
        public static void Executar(){
            Persona persona = new Persona("André",25);
            persona.Mensagem();
            
        }
    }
}