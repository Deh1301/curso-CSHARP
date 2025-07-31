using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laços
{
    public class forLaço
    {
        public static void Executar()
        {
            int num = 0;
            // for (int i = 0; i < num; i++)
            // {
            //     System.Console.WriteLine($"O valor atualizado é:{i}");
            // }

            while (num < 21)
            {
                System.Console.WriteLine($"o valor é : {num}");
                num++;
            }

            string[] nome = { "Andre", "Julia", "Anthony", "Laura" };
            foreach (string nomes in nome)
            {
                System.Console.WriteLine(nomes);
            }

            List<string> identidade = new List<string>();
            identidade.Add("aNDRÉ");
            identidade.Add("Julia");
            identidade.Add("Anthony");

            foreach (string Id in identidade)
            {
                System.Console.WriteLine($"A identidade é: {Id}");
            }

            System.Console.WriteLine("..... ESPAÇO .....");

            identidade.Add("Laura");
            foreach (string Id in identidade)
            {
                System.Console.WriteLine($"A identidade é: {Id}");
            }

        }
    }
}