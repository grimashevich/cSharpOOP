using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class BankAccountTask5: BankAccountTask4
    {
        //TODO РАЗОБРАТЬСЯ С НАСЛЕДОВАНИЕМ КОНСТРУКТОРА

        public BankAccountTask5(float balance, BankAccountType accountType)
            : base(balance, accountType)
        {

        }

        public bool AddToBalance(ulong amount)
        {
            try {this.Balance += checked(amount);}
            catch (System.OverflowException) { return false; }
            return true;
        }

        
        public bool WithdrawFromAccount (ulong amount)
        {
            if (this.Balance > amount)
            {
                this.Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
