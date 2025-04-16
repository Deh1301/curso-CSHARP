using System.Collections;

namespace Colecoes.modulos{
    class ColecaoArrayList{
        public static void Executar(){
            var arrayDeLista = new ArrayList{
                "Teclado",
                30,
                true

            };
            System.Console.WriteLine(arrayDeLista[0]);
            List<int> ints = new List<int>();
            ints.Add(10);
            ints.Add(20);
            foreach(int num in ints){
                System.Console.WriteLine(num);
            }
        }

    } 

}