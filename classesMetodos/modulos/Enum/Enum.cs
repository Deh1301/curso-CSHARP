namespace ClassesMetodos
{
    public enum Genero { Acao, Aventura, Terror };
    public enum Homem {Criança, Adulto, Idoso};
    public class Filme
    {
        public string Titulo;
        public Genero GeneroFilme;
    }

    public class Pessoas{
        public string Humano;
        public Homem GeneroPessoa;

    }

    // class Enum
    // {
    //     public static void Executar()
    //     {
    //         int id = (int)Genero.Acao;
    //         Console.WriteLine(id);
    //         var filme = new Filme();
    //         filme.Titulo= "Vingadores";
    //         filme.GeneroFilme = Genero.Acao;

    //         Console.WriteLine("{0} é {1}!", filme.Titulo, 
    //         filme.GeneroFilme);

    //         id = (int)Genero.Aventura;
    //         Console.WriteLine(id);
    //         filme.Titulo = "A era do Gelo";
    //         filme.GeneroFilme = Genero.Aventura;

    //         Console.WriteLine($"{filme.Titulo} é um filme de {filme.GeneroFilme}!"
    //         );

    //         int nomes = (int)GeneroPessoa.Criança;
    //         Console.WriteLine(nomes);

    //     }

    // }
    
}