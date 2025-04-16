namespace ClassesMetodos
{
    enum DiaSemana
    {
        Domingo,
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }
    class Enumerado
    {
        public static void Executar()
        {

            DiaSemana hoje = DiaSemana.Segunda;
            if(hoje == DiaSemana.Segunda){
                System.Console.WriteLine("Eita segundou!");
            }
            DiaSemana dia = (DiaSemana)5;
            System.Console.WriteLine(dia);

        }
    }
}