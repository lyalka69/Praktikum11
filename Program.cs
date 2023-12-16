using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace praktikum11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.

            //Random random = new Random();
            //int a = random.Next(99);
            //string c = a % 2 == 0 ? "чётное." :  "нечётное.";
            //Console.WriteLine(c);

            //Задача 2.Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.

            //Random random = new Random();
            //int day = random.Next(1,7);

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("monday");
            //        break;

            //    case 2:
            //        Console.WriteLine("tuesday");
            //        break;

            //    case 3:
            //        Console.WriteLine("wednesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("thursday");
            //        break;

            //    case 5:
            //        Console.WriteLine("friday");
            //        break;

            //    case 6:
            //        Console.WriteLine("saturday");
            //        break;

            //    case 7:
            //        Console.WriteLine("sunday");
            //        break;

            //}

            //Задача 3. Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза,
            //если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.

            //Console.Write("input number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("input number: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("input number: ");
            //int c = int.Parse(Console.ReadLine());

            //if (a % 2 == 0 & b % 2 == 0 & c % 2 == 0)
            //{
            //    a /= 2;
            //    b /= 2;
            //    c /= 2;
            //}
            //else if (a % 2 == 0 | b % 2 == 0 | c % 2 == 0)
            //{
            //    a *= 2;
            //    b *= 2;
            //    c *= 2;
            //}
            //else if (a % 2 != 0 & b % 2 != 0 & c % 2 != 0)
            //{
            //    a++;
            //    b++;
            //    c++;
            //}
            //Console.WriteLine($"{a} \n{b} \n{c}");

            //Проведен тест, оцениваемый в целочисленных баллах от нуля до ста.
            //Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 – «отлично»,
            //от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».

            //Random mur = new Random();
            //int a = mur.Next(0, 100);
            //Console.WriteLine($"Ваш балл: {a}");
            //if (90 <= a && a <= 100)
            //{
            //    Console.Write("ваша оценка - отличная");
            //}
            //else if (70 <= a && a <= 89)
            //{
            //    Console.Write("ваша оценка - хорошая");
            //}
            //else if (50 <= a && a <= 69)
            //{
            //    Console.Write("ваша оценка - удовлетворительная");
            //}
            //else if (a < 50)
            //{
            //    Console.Write("ваша оценка - неудовлетворительная");
            //}


            //Задача 5. Дан признак геометрической фигуры на плоскости:
            //к – круг, п – прямоугольник, т - треугольник. Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).

            //Console.Write("Вам даны: п-прямоугольник, т-треугольник, к-круг; \nВыберите одну из данных фигур: ");
            //char shapes = char.Parse(Console.ReadLine());
            //int a, b, c, h, r;
            //double s, p;
            //switch (shapes)
            //{
            //    case 'п':
            //        Console.Write("Введите ширину: ");
            //        a = int.Parse(Console.ReadLine());
            //        Console.Write("Введите длину: ");
            //        b = int.Parse(Console.ReadLine());
            //        s = a * b;
            //        p = 2 * (a + b);
            //        Console.WriteLine($"S = {s} \nP = {p}");
            //        break;
            //    case 'т': 
            //        Console.Write("a= ");
            //        a = int.Parse(Console.ReadLine());
            //        Console.Write("b= ");
            //        b = int.Parse(Console.ReadLine());
            //        Console.Write("c= ");
            //        c = int.Parse(Console.ReadLine());
            //        Console.Write("h= ");
            //        h = int.Parse(Console.ReadLine());
            //        s = (a * h) / 2;
            //        p = a + b + c;
            //        Console.WriteLine($"S = {s} \nP = {p}");
            //        break;
            //    case 'к':
            //        r = int.Parse(Console.ReadLine());
            //        s = Math.PI * Math.Pow(r, 2);
            //        p = 2 * Math.PI * r;
            //        Console.WriteLine($"S = {s} \nP = {p}");
            //        break;
            //}


            //Задача 6.Написать приложение, которое позволяет вычислить сумму страхового взноса(SV) для автомобиля. Входные данные будут вводиться с клавиатуры:

            Console.Write("Марка автомобиля: ");
            string ma = Console.ReadLine();
            Console.Write("Введите срок страхования: ");
            int months = int.Parse(Console.ReadLine());
            double sv, kt = 0;

            if (months < 3)
            {
                kt = 10;
            }
            else if (months >= 3 & months < 6)
            {
                kt = 8;
            }
            else if (months >= 6 & months < 12) 
            {
                kt = 5;
            }
            sv = 50 * months * (1 + kt / 100);

            Console.Write($"Ваш автомобиль марки {ma} был застрахован. \nСумма страхового взноса составила {sv}.");
            


            Console.ReadKey();
        }
    }
}
