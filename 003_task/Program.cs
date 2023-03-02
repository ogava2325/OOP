//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте программу в которой создайте класс «Банковский Счет».
//В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету,
//сумма счета. В теле метода создайте следующие методы: Метод, который рассчитывает
//количество дней, начиная с даты открытия счета; Метод который выводит информацию о
//количестве рассчитанных дней; Метод который рассчитывает сумму, которая будет на счете
//через определенное количество лет (количество лет – параметр метода); Метод который
//выводит информацию о сумме. Также продумать над конструктором класса. В методе Main()
//создайте экземпляр класса «Банковский Счет», присвойте всем полям значение через свойства
//доступа, а также на экземпляр класса вызовите методы для отображения количества дней и
//суммы.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_task
{
    class BankAccount
    {
        public DateTime OpeningDate { get; set; }
        public byte Percent { get; set;}
        public int Ammount { get; set; }
        private double ShowDays()
        {
            return (DateTime.Today.Subtract(OpeningDate)).TotalDays;
        }
        public void TotalDays() 
        {
            Console.WriteLine($"Total days since you've opened an account is {ShowDays()}");
        }
        public void MoneyAfterYears(byte years)
        {
            for(int i = 0; i < years; i++)
            {
                Ammount += Ammount * Percent / 100;
            }
        }
        public void ShowMoney()
        {
            Console.WriteLine($"Total amount of money on a bank account is {Ammount}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.OpeningDate = new DateTime(2023, 2, 1);
            account.Percent = 10;
            account.Ammount = 100;
            account.MoneyAfterYears(3);
            account.ShowMoney();

        }
    }
}
