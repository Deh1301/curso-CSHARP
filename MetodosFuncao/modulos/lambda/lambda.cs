using System;
using System.Collections;
using System.Collections.Generic;

namespace MetodosFuncao{
    class Lambda{
        public static void Executar(){
            Func<int,int,int> somar = (a,b) => a+b;
            System.Console.WriteLine(somar(3,4));
        }
    }
}