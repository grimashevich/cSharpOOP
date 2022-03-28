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
            Task2();
            Task3();
        }

        public static void Task1()
        {
            Console.WriteLine("Задача 1.");
            Console.WriteLine("В класс банковский счет, созданный в упражнениях, добавить метод, " +
                "который переводит деньги с одного счета на другой. У метода два параметра: " +
                "ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – " +
                "сумма.\n");
            var account1 = new BankAccount(1000, 00);
            var account2 = new BankAccount(100, 00);
            Console.WriteLine("\n" + account1);
            Console.WriteLine(account2);

            TryTransferMoney(account2, account1, 600);
            Console.WriteLine("\n" + account1);
            Console.WriteLine(account2);

            TryTransferMoney(account2, account1, 500);
            Console.WriteLine("\n" + account1);
            Console.WriteLine(account2);
        }

        public static void Task2()
        {
            Console.WriteLine("\n\n- - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Задача 2.");
            Console.WriteLine("Реализовать метод, который в качестве входного параметра принимает " +
                "строку string, возвращает строку типа string, буквы в которой идут в обратном " +
                "порядке. Протестировать метод.\n");
            string str1 = "REVERSE";
            string str2 = StringReverse.StrReverse(str1);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

        public static void Task3()
        {
            Console.WriteLine("\n\n- - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Задача 3.");
            Console.WriteLine("* Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail " +
                "адрес. Разделителем между ФИО и адресом электронной почты является символ &: " +
                "Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru " +
                "Сформировать новый файл, содержащий список адресов электронной почты. Предусмотреть " +
                "метод, выделяющий из строки адрес почты. Методу в качестве параметра передается " +
                "символьная строка s, e-mail возвращается в той же строке s: public void SearchMail " +
                "(ref string s).\n");
            
            int count = 0;
            var parser = new EmailParser();
            string inFile = "../../Lesson3/inFile.txt"; //Осносительный адрес от дебаг каталога
            string outFile = "../../Lesson3/outFile.txt"; //Осносительный адрес от дебаг каталога
            if (parser.ParseFromFile(inFile, outFile, ref count) && count > 0)
                Console.WriteLine($"Парсинг прошел успешно. Добыто адресов: {count}");
            else
                Console.WriteLine("Ничего спарсить не удалось");
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
