namespace ClassesMetodos
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;
        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
            Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
    {

        public static void Executar()
        {
            var cliente = new Cliente("André", new DateTime(2000, 01, 13));
            Console.WriteLine(cliente.GetDataDeNascimento());
            cliente = new Cliente("Andre Calixto", new DateTime(2002,02,13));
            Console.WriteLine(cliente.GetDataDeNascimento());
        }
    }
}