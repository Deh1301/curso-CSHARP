namespace ClassesMetodos{
    class ParametroNomeado{
        public static void Formato(int mes, int dia, int ano){
            Console.WriteLine("A data de nascimento de André é :{0:D2}/{1:D2}/{2}",dia,mes,ano);
        }

        public static void Profissao(string Nome, int salario){
            Console.WriteLine($"Andre é {Nome} e recebe {salario} reais");
        }
        public static void Executar(){
            Formato(mes:1,dia:13,ano:2000);
            Profissao(Nome:"Programador",salario:5000);
        
        }

        
    }
}