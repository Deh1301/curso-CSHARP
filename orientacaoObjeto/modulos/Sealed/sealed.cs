using System;
using System.Collections;
using System.Collections.Generic;

namespace orientacaoObjeto{
    sealed class SemFIlho{
        public double Valor(){
            return 20000;
        }
    }
    // class Filho : SemFIlho{
        //  nao pode acessar por que a classe impossibilita acesso por estar selada.
        //  nao pode ter acesso de uma sub classe
    // }
}