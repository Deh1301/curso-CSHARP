using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estruturaControle
{
    public class calculandoImc
    {
        // public double Peso { get; set; }
        // public double Altura { get; set; }

        // public Calculo(double peso, double altura)
        // {
        //     Peso = peso;
        //     Altura = altura;
        // }

        public static void Executar()
        {

            double peso = 68.8;
            double altura = 1.67;
            double somar = peso / (altura * altura);

            string imcValor = somar.ToString("F2");

            System.Console.WriteLine($"O valor do imc é: {imcValor}");


            if (somar < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (somar < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (somar < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }

            System.Console.WriteLine("\nEscolha um numero:");
            System.Console.WriteLine("1-Primeira opção");
            System.Console.WriteLine("2-Segunda opção");
            System.Console.WriteLine("3-Terceira opção");

            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":

                    System.Console.WriteLine("Xuxulia Totosa");
                    break;
                case "2":
                    System.Console.WriteLine("Xuxulia Perfeita");
                    break;

                case "3":
                    System.Console.WriteLine("Xuxulia Deusa");
                    break;

                    

            }

        }
    }
}