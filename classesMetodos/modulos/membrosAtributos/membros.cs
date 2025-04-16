namespace ClassesMetodos
{
    public class Membros
    {
        public static void MembrosClasse()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Andre";
            pessoa.Idade = 24;
            Console.WriteLine($"Ola o nome é {pessoa.Nome} e a idade é {pessoa.Idade} anos");

            //    var profissao = new Pessoa();
            //    profissao.Nome = "Programador";
            //    Console.WriteLine($"E a profissao dele é:{profissao.Nome}");
        }

        public static void ProfissaoDados()
        {
            Profissao profissao = new Profissao();
            profissao.NomeProfissao = "Desenvolvedor de Software";
            profissao.Salario= 5000;
            Console.WriteLine($"A profissao é {profissao.NomeProfissao} e o salario médio é de {profissao.Salario} reais.");
        }

    }
}