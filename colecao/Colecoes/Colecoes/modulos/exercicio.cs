using System;
namespace Colecao.Modulos
{
    public class Exercicio
    {
        public static void Executar()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            int maior = numeros[0];
            
            foreach(int numero in numeros)
            {
                if(numero > maior)
                {
                    maior = numero;
                    
                }
            }
            Console.WriteLine(maior);

            int[] numeros2 = { 2, 4, 5, 6, };
            numeros2[0] = 3;
            Console.WriteLine(numeros2[0]);

            int[] numeroPar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Numeros pares:");
            foreach(int numero in numeroPar)
            {
                if(numero %2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            string[] nomes= {"André","Julia","Anthony", "Laura"};
            foreach(string nome in nomes){
                if(nome == "André"){
                    System.Console.WriteLine("Encontramos");

                }
            }

            
        }
    }
}