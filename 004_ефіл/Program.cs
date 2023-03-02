//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте программу, в которой создайте класс «Треугольник». В теле класса создайте три
//закрытых поля для описания сторон треугольника и три свойства для чтения и записи. Также в
//теле класса создайте 3 метода: 1 - й для расчета площади треугольника, формула для расчета , где
//- полупериметр треугольника , a, b, c – длины сторон треугольника, 2-й для расчета периметра
//треугольника, формула для расчета и 3-й для вывода информации о площади и периметре
//треугольника. Создайте конструктор, который в качестве аргументов приминимает стороны
//треугольника и инициализирует поля класса. В методе Main() создайте экземпляр класса
//«Треугольник», задайте произвольное значение сторон треугольника и выведите на экран
//значение периметра и площади треугольника.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ефіл
{
    class Triangle
    {
        private float firstSide;
        private float secondSide;
        private float thirdSide;
        public float FirstSide
        {
            get { return firstSide; }
            set { firstSide = value; }
        }
        public float SecondSide
        {
            get { return secondSide; }
            set { secondSide = value; }
        }
        public float ThirdSide
        {
            get { return thirdSide; }
            set { thirdSide = value; }
        }
        private float Area()
        {
            float p = (firstSide + secondSide + thirdSide)/2;
            return (float)Math.Sqrt(p*(p-firstSide)*(p-secondSide)*(p-thirdSide));
        }
        private float Perimetr()
        {
            return firstSide + secondSide + thirdSide;
        }
        public void ShowAreaAndPerimetr()
        {
            Console.WriteLine($"Area is {Area()}");
            Console.WriteLine($"Perimetr is {Perimetr()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.FirstSide = 3;
            triangle.SecondSide = 4;    
            triangle.ThirdSide = 5;
            triangle.ShowAreaAndPerimetr();
        }
    }
}
