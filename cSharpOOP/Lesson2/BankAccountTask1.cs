using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class BankAccountTask1: BankAccountBase
    {
        public virtual void SetId(ulong id) {this._id = id; }
        public ulong GetId() => this._id;
        public void SetBalance(float balance) { this._balance = balance; }
        public float GetBalance() { return this._balance; }
        public void SetBankAccountType(BankAccountType accountType) { this._bankAccountType = accountType; }
        public string GetBankAccountType()
        {
            switch (this._bankAccountType)
            {
                case BankAccountType.budget: return "бюджетный";
                case BankAccountType.current: return "текущий";
                case BankAccountType.savings: return "сберегательный";
                case BankAccountType.checking: return "рассчетный";
                default: return "НЕ ОПРЕДЕЛЕН";
            }
        }

        public override string ToString()
        {
            string result;
            result = $"Счет №\t{this.GetId()}\n" +
                     $"Тип:\t{this.GetBankAccountType()}\n" +
                     $"Баланс:\t{this.GetBalance()}";
            return result;
        }
    }
}
