using System;
using System.Globalization;


namespace fundamentosCs{
    public class FormNum{
        public static void Formatar(){
            double num = 12.12;
            Console.WriteLine(num.ToString("C"));// basicamente o toString serviu para formatar o valor para um valor monetario
            Console.WriteLine(num.ToString("F1"));
            Console.WriteLine(num.ToString("P"));



            CultureInfo usa = new CultureInfo("en-US");
            Console.WriteLine(num.ToString("C",usa));

        }

    }
}