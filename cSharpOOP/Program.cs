using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task1();
        }

        public static void Task1()
        {
            Console.WriteLine("Задача 1.");
            Console.WriteLine("Для класса банковский счет переопределить операторы == и != для " +
                "сравнения информации в двух счетах. Переопределить метод Equals аналогично " +
                "оператору ==, не забыть переопределить метод GetHashCode(). Переопределить " +
                "методToString() для печати информации о счете. Протестировать функционирование " +
                "переопределенных методов и операторов на простом примере.\n");
            var account1 = new BankAccount(1000);
            var account2 = new BankAccount(1000);
            var account3 = new BankAccount(1000);
            account2.CopyIdFrom(account1);
            Console.WriteLine("\n" + account1);
            Console.WriteLine(account2);

            Console.WriteLine();
            Console.WriteLine($"account1 == account 2: {account1 == account2}");

            Console.WriteLine();
            Console.WriteLine($"account1 == account 3: {account1 == account3}");

            Console.WriteLine();
            Console.WriteLine($"account1.Equals(account2): {account1.Equals(account2)}");
            
            Console.WriteLine();
            Console.WriteLine($"account1.GetHashCode() == account2.GetHashCode():" +
                $" {account1.GetHashCode() == account2.GetHashCode()}");
            Console.WriteLine();
        }


        public static void TryTransferMoney(BankAccount transferTo, BankAccount transferFrom, float amount)
        {
            Console.WriteLine($"\nПопытка перевода со счета {transferFrom.Id} на счет {transferTo.Id} суммы {amount}");
            if (transferTo.TransferFromAnotherAccount(transferFrom, amount))
                Console.WriteLine("Переведено успешно");
            else Console.WriteLine("Отказ в переводе");
        }
    }
}
