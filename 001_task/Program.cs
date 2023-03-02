//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте программу в которой создайте класс «Адрес».
//В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
//Для каждого поля, создать свойство с двумя методами доступа. Также в классе необходимо
//создать метод для отображения информации про адрес. В методе Main() создайте экземпляр
//класса «Адрес», присвойте всем полям значение через свойства доступа, а также на экземпляр
//класса вызовите метод, который выводит информацию про адрес
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_task
{
    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Street: {Street}");
            Console.WriteLine($"HouseNumber: {HouseNumber}");
            Console.WriteLine($"FlatNumber: {FlatNumber}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Country = "UA";
            address.City = "Kyiv";
            address.Street = "Verbytskogo";
            address.HouseNumber = 23;
            address.FlatNumber = 123;
            address.ShowInfo();
        }
    }
}
