using System.Data;

namespace Estruturas
{
    public class ForEach
    {
        public static void forEach()
        {
            var palavra = "opa!";
            string[] fruta = {"Maça","Banana","Laranja"};
            foreach(var letra in fruta){
                Console.WriteLine(letra);

            }
            int[] numeros = {10,2,4,5,7,8};
            foreach(int num in numeros){
                Console.WriteLine(num);
            }

            
            


        }
    }
}