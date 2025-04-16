namespace fundamentosCs{
    public class Inferencias{
        public static void infTipos(){
            var nome = "Andre";
            string profissao = "programador";
            int valor = 5000;
            Console.WriteLine("o {0} se chama {1} e recebe {2:c}", profissao,nome,valor);
            Console.Write($"O {nome} tem como profissao ser {profissao}, e ganha {valor:c}.");
            //forma de interpolação pelo index

        }
    }
}