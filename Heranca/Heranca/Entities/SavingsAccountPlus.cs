using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {

        //Não é possível herdar elementos da classe "SavingsAccount pois ela está com a palavra "sealed"."
        //Serve para proteger alguma regra de negócio que não pode ser exposta
    }
}
