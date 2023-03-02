﻿//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте программу в которой создайте класс «Котенок».
//В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз. Для каждого
//поля, создать свойство с двумя методами доступа. Также в теле класса создайте метод,
//который будет выводить на консоль «Мяу», метод должен принимать один аргумент –
//количество «Мяу» котенка, выводить «Мяу» соответствующее количество раз. В методе Main()
//создайте экземпляр класса «Котенок», присвойте всем полям значение через свойства доступа, а
//также вызовите метод с помощью которого котенок говорит «Мяу», в качестве аргумента метода
//передайте 3.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_task
{
    class Kitty
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public string CoatColor { get; set; }
        public string EyeColor { get; set; }
        public void Mew(int numberMews)
        {
            for(int i = 0; i < numberMews; i++) 
            {
                Console.Write("Mew\t");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitty kitty = new Kitty();
            kitty.Name = "Kira";
            kitty.Age = 1;
            kitty.CoatColor = "Black";
            kitty.EyeColor = "Green";
            kitty.Mew(3);
        }
            
    }

}
