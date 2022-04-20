using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class BankAccountTask4
    {
        private static protected ulong _lastAccountID = 10000000;

        private ulong _id;
        private float _balance;
        private BankAccountType _bankAccountType;

        public ulong Id { get { return _id; } set { _id = value; } }
        public float Balance { get { return _balance; } set { _balance = value; } }
        public BankAccountType BankAccountType
        {
            get { return _bankAccountType; }
            set { _bankAccountType = value; }
        }

        public BankAccountTask4(float balance, BankAccountType accountType)
        {
            this.Id = _lastAccountID++;
            _balance = balance;
            _bankAccountType = accountType;
        }

        public BankAccountTask4(float balance): this(balance, BankAccountType.current)
        {
        }
        public BankAccountTask4(BankAccountType accountType) : this(0, accountType)
        {
        }

        public BankAccountTask4(): this(0, BankAccountType.current)
        {
        }

        public string GetBankAccountType()
        {
            switch (this.BankAccountType)
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
            result = $"Счет №\t{this.Id}\n" +
                     $"Тип:\t{this.GetBankAccountType()}\n" +
                     $"Баланс:\t{this.Balance}";
            return result;
        }
    }
}
