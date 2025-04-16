using System;
using System.Collections.Generic;
using System.Collections;

namespace Colecoes.modulos
{
    class ColecaoDictionary
    {
        public static void Executar()
        {
            var jogo = new Dictionary<int, string>();
            jogo.Add(2007, "God Of War");
            jogo.Add(2013, "GTA V");
            jogo.Add(2018, "God Of War");
            jogo.Add(2016, "The Last Of Us");
            if (jogo.ContainsKey(2016))
            {
                System.Console.WriteLine($"2016: {jogo[2016]}");
            }
            else
            {
                System.Console.WriteLine("nao localizado");
            }

            foreach (KeyValuePair<int, string> jogos in jogo)
            {
                System.Console.WriteLine($"{jogos.Value} é de {jogos.Key}");

            }
            foreach (var valor in jogo)
            {
                System.Console.WriteLine($"O nome do jogo é {valor.Value}");
            }

            var filme = new Dictionary<int, string>();
            filme.Add(2018, "Vingadores");
            filme.Add(2021, "Miranha");
            filme.Add(2025, "SuperMan");

            foreach (KeyValuePair<int, string> filmes in filme)
            {
                System.Console.WriteLine($"O filme é {filmes.Value} e foi lançado em {filmes.Key}");
            }

            System.Console.WriteLine("\n\n");

            Dictionary<double, string> valores = new Dictionary<double, string>{
                {9.5, "Aprovado"},
                {7.0, "Aprovado mas precisa ter atenção"},
                {5.0, "Recuperação"},
                {3.0, "Reprovado"}

            };
            System.Console.WriteLine("Quadro de Notas :");

            foreach (KeyValuePair<double, string> aluno in valores)
            {
              
                System.Console.WriteLine($"Com nota {aluno.Key} esta {aluno.Value}");
            }




        }
    }
}