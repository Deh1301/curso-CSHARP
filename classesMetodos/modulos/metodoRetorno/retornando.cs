namespace ClassesMetodos{
    public class Instanciar{
        public static void Executar(){
            Informar informar = new Informar();
            informar.Dados = "Dados enviados";
            Console.WriteLine(informar.Dados);
        }
    }
}