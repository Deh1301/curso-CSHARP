using System.Collections.Generic;
using System.Collections;

namespace Colecoes.modulos{
    class Set{
        public static void Executar(){
            HashSet<int> numeros = new HashSet<int> {1,2,3,4,5};
            numeros.Add(10);
            numeros.Add(4);
            
            foreach(int num in numeros){
                System.Console.WriteLine(num);
            }
        }
    }
}