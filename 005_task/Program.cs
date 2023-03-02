//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте программу, в которой создайте класс «Точка» – для описания координат точки на
//координатной прямой рис No1. В теле класса создайте следующие закрытые поля: целочисленное
//поле для описания координаты точки X и целочисленное поле для описания координаты точки
//Y, а также строковое поле для имени точки. Создать три свойства с методами доступа get и
//set, а также конструктор класса, который будет инициализировать данные поля значениями
//аргументов. Далее создайте класс «Фигура». В теле класса фигура создайте одно поле типа масив
//«Точек» и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3
//(треугольника) и 4 аргумента (четырехугольника). В теле класса «Фигура» создайте два метода: 1 -
//й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» и
//возвращать длину стороны, формула для расчета d = √(x2 − x1
//)
//2 + (y2 − y1
//)
//2 и метод для
//расчета периметра фигуры (подсказка – в методе циклом перебирать массив «Точек», пока в нем
//будут элементы, и рассчитывать длину стороны). В методе Main() создать и рассчитать периметр
//треугольника, квадрата, прямоугольника, точки выбрать произвольные.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _005_task
{
    class Point
    {
        int x;
        int y;
        string name;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
    class Shape
    {
        Point[] points = new Point[10];
        private double perimetr = 0;
        public Shape(params Point[] parametrs)
        {
            for(int i = 0; i < parametrs.Length; i++)
            {
                points[i] = parametrs[i];
            }
        }
        
        public void SideLength()
        {
            double d = 0;
            for(int i = 0; points[i] != null;i++) 
            {
                if (points[i + 1] == null)
                {
                    d = Math.Sqrt(Math.Pow((points[i].X - points[0].X), 2) + Math.Pow((points[i].Y - points[0].Y), 2));
                    Console.WriteLine($"{points[i].Name}{points[0].Name} = {d}");
                    perimetr+= d;
                }
                else { 
                    
                    d = Math.Sqrt(Math.Pow((points[i].X - points[i + 1].X), 2) + Math.Pow((points[i].Y - points[i + 1].Y), 2));
                    Console.WriteLine($"{points[i].Name}{points[i + 1].Name} = {d}");
                    perimetr += d;
                }
                
            }

        }
        public void Perimetr()
        {
            Console.WriteLine($"Perimetr = {perimetr}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(2, 1, "A");
            Point pointB = new Point(2, 4, "B");
            Point pointC = new Point(6, 4, "C");
            Point pointD = new Point(6, 1, "D");
            Shape triangle = new Shape(pointA,pointB,pointC);
            triangle.SideLength();
            triangle.Perimetr();
            Shape rectangle = new Shape(pointA, pointB, pointC, pointD);
            // Console.WriteLine($"{point.X} {point.Y} {point.Name}");
        }
    }
}
