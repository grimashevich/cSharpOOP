using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class BankAccount
    {
        private static protected ulong _lastAccountID = 10000000;

        private protected ulong _id;
        private protected float _balance;
        private protected BankAccountType _bankAccountType;

        public ulong Id { get { return _id; } set { _id = value; } }
        public float Balance { get { return _balance; } }
        public BankAccountType BankAccountType
        {
            get { return _bankAccountType; }
            set { _bankAccountType = value; }
        }

        public BankAccount(float balance, BankAccountType accountType)
        {
            this.Id = _lastAccountID++;
            _balance = balance;
            _bankAccountType = accountType;
        }

        public BankAccount(float balance) : this(balance, BankAccountType.current)
        {
        }
        public BankAccount(BankAccountType accountType) : this(0, accountType)
        {
        }

        public BankAccount() : this(0, BankAccountType.current)
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
            result = $"Счет № {this.Id}\t" +
                     $"Тип: {this.GetBankAccountType()}\t" +
                     $"Баланс: {this.Balance}";
            return result;
        }

        public bool AddToBalance(float amount)
        {
            try { this._balance += checked(amount); }
            catch (System.OverflowException) { return false; }
            return true;
        }

        public bool WithdrawFromAccount(float amount)
        {
            if (this._balance >= amount)
            {
                this._balance -= amount;
                return true;
            }
            return false;
        }

        public bool TransferFromAnotherAccount(BankAccount donor, float amount)
        {
            if (donor == this)
                return false;
            if (donor.WithdrawFromAccount(amount))
            {
                if (this.AddToBalance(amount))
                    return true;
                else { donor.AddToBalance(amount); }
            }
            return false;
        }
    }
}
