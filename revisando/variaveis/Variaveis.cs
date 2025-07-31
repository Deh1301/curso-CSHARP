using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace variaveisInicio
{
    public class Variaveis
    {
        public static void Executar()
        {
            int num = 10;
            string nome = "André";
            char caracter = 'A';
            double numeros = 7.7;
            bool valor = true;

            System.Console.WriteLine($"o numero é: {num}");
            System.Console.WriteLine(nome);
            System.Console.WriteLine(caracter);
            System.Console.WriteLine(numeros);
            System.Console.WriteLine(valor);
        }
    }
}