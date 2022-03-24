using System;
using System.Collections.Generic;
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
            Task2();
            Task3();
            Task4();
            Task5();
        }

        static void Task1()
        {
            Console.WriteLine("Задача 1." +
                "Создать класс счет в банке с закрытыми полями: номер счета, " +
                "баланс, тип банковского счета (использовать перечислимый тип). " +
                "Предусмотреть методы для доступа к данным– заполнения и чтения. " +
                "Создать объект класса, заполнить его поля и вывести информацию " +
                "об объекте класса на печать");
            Console.WriteLine("- - - - - - - - - - - - - - - ");
            var account1 = new BankAccountTask1();
            account1.SetId(1005486);
            account1.SetBalance(100500);
            account1.SetBankAccountType(BankAccountType.current);
            Console.WriteLine(account1);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - \n");
        }
        static void Task2()
        {
            Console.WriteLine("Задача 2." +
                "Изменить класс счет в банке из упражнения таким образом, чтобы номер " +
                "счета генерировался сам и был уникальным. Для этого надо создать в " +
                "классе статическую переменную и метод, который увеличивает значение " +
                "этого переменной.");
            Console.WriteLine("- - - - - - - - - - - - - - - ");
            var account2 = new BankAccountTask2();
            account2.SetAccountAutoID();
            account2.SetBalance(200500);
            account2.SetBankAccountType(BankAccountType.savings);
            Console.WriteLine(account2);
            Console.WriteLine();
            var account3 = new BankAccountTask2();
            account3.SetAccountAutoID();
            account3.SetBalance(300500);
            account3.SetBankAccountType(BankAccountType.checking);
            Console.WriteLine(account3);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - \n");
        }

        static void Task3()
        {
            Console.WriteLine("Задача 3." +
                "В классе банковский счет, удалить методы заполнения полей. Вместо этих " +
                "методов создать конструкторы. Переопределить конструктор по умолчанию, " +
                "создать конструктор для заполнения поля баланс, конструктор для " +
                "заполнения поля тип банковского счета, конструктор для заполнения " +
                "баланса и типа банковского счета. Каждый конструктор должен вызывать " +
                "метод, генерирующий номер счета.");
            Console.WriteLine("- - - - - - - - - - - - - - - ");
            var account4 = new BankAccountTask3();
            Console.WriteLine(account4);
            Console.WriteLine();
            var account5 = new BankAccountTask3(400500, BankAccountType.budget);
            Console.WriteLine(account5);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - \n");
        }

        static void Task4()
        {
            Console.WriteLine("Задача 4." +
                "Вклассе все методы для заполнения и получения значений полей заменить " +
                "на свойства. Написать тестовый пример.");
            Console.WriteLine("- - - - - - - - - - - - - - - ");
            var account5 = new BankAccountTask4(500500, BankAccountType.current);
            Console.WriteLine(account5);
            Console.WriteLine("\nИзменяем тип счета...\n");
            account5.BankAccountType = BankAccountType.savings;
            Console.WriteLine(account5);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - \n");
        }

        static void Task5()
        {
            Console.WriteLine("Задача 5." +
                "(*)Добавить в класс счет в банке два метода: снять со счета и " +
                "положить на счет. Метод снять со счета проверяет, возможно ли " +
                "снять запрашиваемую сумму, и в случае положительного результата " +
                "изменяет баланс.");
            Console.WriteLine("- - - - - - - - - - - - - - - ");
            var account6 = new BankAccountTask5(600500, BankAccountType.checking);
            Console.WriteLine(account6);
            if (account6.AddToBalance(100000)) { Console.WriteLine("\nДобавили 100к\n"); }
            Console.WriteLine(account6);
            if (account6.WithdrawFromAccount(200000)) { Console.WriteLine("\nСняли 200к\n"); }
            Console.WriteLine(account6);
            if (! account6.WithdrawFromAccount(1000000)) 
                {Console.WriteLine("\nНе смогли снять 1 кк\n"); }
            Console.WriteLine(account6);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - \n");
        }
    }
}
