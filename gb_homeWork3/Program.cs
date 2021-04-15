using System;

namespace mathComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Киселев Денис
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.

            Console.WriteLine("Здравствуйте! Это программа считает комплексные числа.");
            Console.WriteLine("\nВыбирете действие и введите числа.");

            ComplexCalculator();

            char isRepeat = 'n';
            char repeatAnswer = 'y';
            isRepeat = CheckIsRepeat(isRepeat);

            while (isRepeat.Equals(repeatAnswer))
            {
                ComplexCalculator();
                isRepeat = CheckIsRepeat(isRepeat);
            }
        }

        private static char CheckIsRepeat(char isRepeat)
        {
            Console.Write("\nЕсли хотите выбрать другое действие - напишите Y в любом регистре: ");
            char.TryParse(Console.ReadLine().ToLower(), out isRepeat);
            return isRepeat;
        }

        private static void ComplexCalculator()
        {
            Console.WriteLine("\n\nСложение - 1");
            Console.WriteLine("\nВычитание - 2");
            Console.WriteLine("\nУмножение - 3");
            Console.WriteLine("\nДеление - 4");

            int actionNumber;

            bool isNum = getActionNum(out actionNumber);
            while (!isNum || actionNumber < 1 || actionNumber > 4)
            {
                isNum = getActionNum(out actionNumber);
            }

            Complex complex1 = GetComplexNum(1);
            Console.WriteLine($"\nВаше первое число: {complex1.IntoString()}");

            Complex complex2 = GetComplexNum(2);
            Console.WriteLine($"\nВаше второе число: {complex2.IntoString()}");

            switch (actionNumber)
            {
                case 1:

                    Complex sum = Complex.Sum(complex1, complex2);
                    Console.WriteLine($"\n\nРезультат сложения: {sum.IntoString()}");
                    break;
                case 2:
                    Complex sub = Complex.Sub(complex1, complex2);
                    Console.WriteLine($"\n\nРезультат вычитания: {sub.IntoString()}");
                    break;
                case 3:
                    Complex multi = Complex.Multi(complex1, complex2);
                    Console.WriteLine($"\n\nРезультат умножения: {multi.IntoString()}");
                    break;
                case 4:
                    Complex divide = Complex.Multi(complex1, complex2);
                    Console.WriteLine($"\n\nРезультат деления: {divide.IntoString()}");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private static Complex GetComplexNum(double complexCount)
        {
            Console.Write($"\nВведите первое число - для комплексного числа №{complexCount}: ");
            double x1;
            x1 = getIntNum();

            Console.Write($"\nВведите второе число - для комплексного числа №{complexCount}: ");
            double x2;
            x2 = getIntNum();

            return new Complex(x1, x2);
        }

        private static double getIntNum()
        {
            double intNumber;


            bool isNum = double.TryParse(Console.ReadLine(), out intNumber);
            while (!isNum)
            {
                Console.Write("\nВведите число: ");
                isNum = double.TryParse(Console.ReadLine(), out intNumber);
            }
            return intNumber;
        }

        private static bool getActionNum(out int actionNumber)
        {
            Console.Write("\n\nВведите число в соответствие с действием: ");
            return int.TryParse(Console.ReadLine(), out actionNumber);
        }
    }
}

