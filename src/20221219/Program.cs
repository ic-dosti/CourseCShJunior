using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первые переменные
            string nameAlex;
            nameAlex = "Alex";

            // Выводим строку-приглашение
            Console.Write("Введите свое имя: ");

            // Сохраняем текст в соответствующую перменную
            var name = Console.ReadLine();

            // Выводим имя на консоль
            Console.WriteLine($"Привет {name}");
            Console.WriteLine(nameAlex);

            // Константы
            const string nameKris = "Kris";
            Console.WriteLine(nameKris);

            // Логические типы
            Console.WriteLine(true);
            Console.WriteLine(false);

            // Целочисленные типы int
            Console.WriteLine(-800);
            Console.WriteLine(668);
            Console.WriteLine(55);

            // Числа в двоичной записи
            Console.WriteLine(0b1011);       
            Console.WriteLine(0b1010101);     
            Console.WriteLine(0b10010);

            // Вещественные литералы
            Console.WriteLine(3.24e15);
            Console.WriteLine(1.1E-17);

            // Символьные литералы
            Console.WriteLine('H');
            Console.WriteLine('E');
            Console.WriteLine('L');
            Console.WriteLine('L');
            Console.WriteLine('O');

            // Строковые литералы
            Console.WriteLine("Hello word");

            // Типизация
            int numberA;
            numberA = 2005;

            // Вывод значений
            Console.WriteLine($"Имя Person 1: {nameAlex}  Возраст: {numberA}");
            Console.WriteLine("Имя Person 2: {1}  Возраст: {0}", numberA, name);

            // Арифметика
            int a, b, c, d;
            int o1, o2, o3, o4;
            a = 100;
            b = 150;
            c = 200;
            d = 250;

            o1 = a + b;
            o2 = c - d;
            o3 = d * c;
            o4 = d / o1;

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
            Console.WriteLine(o4);
        }
    }
}

