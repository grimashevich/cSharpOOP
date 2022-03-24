using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class BankAccountTask3: BankAccountBase
    {
        private static protected ulong _lastAccountID = 10000000;

        public BankAccountTask3(float balance, BankAccountType accountType)
        {
            SetAccountAutoID();
            _balance = balance;
            _bankAccountType = accountType;
        }

        public BankAccountTask3(float balance): this(balance, BankAccountType.current)
        {
        }
        public BankAccountTask3(BankAccountType accountType) : this(0, accountType)
        {
        }

        public BankAccountTask3(): this(0, BankAccountType.current)
        {
        }

        public void SetAccountAutoID() { this._id = _lastAccountID++; }

        public ulong GetId() => this._id;
        public float GetBalance() { return this._balance; }

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
