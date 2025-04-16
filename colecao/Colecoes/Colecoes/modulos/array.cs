using System;

namespace Colecao.Modulos
{
    public class ArrayModule
    {
        public static void Executar()
        {
            string[] alunos = new string[5] 
            { "André", "Julia", "Athony", "Laura", "Gael" };
            Console.WriteLine($"No indice zero esta: {alunos[0]}");
            int[] numero = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numero[0]);
            
            foreach(int numeros in numero)
            {
                Console.WriteLine(numeros);

            }
            char[] letras = new char[5]
            { 'A','N','D','R','E'};
            foreach(char letra in letras)
            {
                Console.WriteLine(letra);
            }

            //tipo de array

            //ARRAY SORT COLOCA EM ORDEM CRESCENTE

            int[] number = {5,4,3,2,1};
            Array.Sort(number);
            foreach(int numbers in number){
                System.Console.WriteLine(numbers);
            }

            int[,] matriz = {
                {1,2,3},
                {5,6,7},
                {8,9,10}
            };
            System.Console.WriteLine($"O numero na matriz é: {matriz[1,2]}");

            int[] index = {10,30,20,40};
            int encontrado = Array.IndexOf(index, 30);
            System.Console.WriteLine($"O indice de 30 é {encontrado}");

            int[] numeroInteiro = {1,2,3,4,5,6};
            int soma = 0;
            foreach(int numeros in numeroInteiro){
               soma +=numeros;
               System.Console.WriteLine(soma);
            }

            int[] maior = {1,23,44,55};
            int maiorNumero = maior[0];
            foreach(int maiores in maior){
                if(maiores > maiorNumero){
                    maiorNumero = maiores;
                }
            }
            System.Console.WriteLine($"o maior valor é : {maiorNumero}");

            int[] menor = {1,2,3,4,5,6,7,8};
            int menorNumero = menor[0];
            foreach(int menores in menor){
                if(menores < menorNumero){
                    menorNumero = menores;
                }

            }
            System.Console.WriteLine($"o menor numero é : {menorNumero}");

            int[] numInvert = {1,2,3,4,5,6,7};
            Array.Reverse(numInvert);
            foreach(int revers in numInvert){
                System.Console.WriteLine(revers);
            }

            int[,] tabela = {
                {1,2,3},
                {4,5,6}
            };
            foreach(int table in tabela){
                Console.WriteLine(table + "\t");
            }

            int[] pares = {1,2,3,4,5,6,7,8};
            foreach(int par in pares){
                if(par % 2 == 0){
                    System.Console.WriteLine(par);
                }
            }


        }
    }
}
