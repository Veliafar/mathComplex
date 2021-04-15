using System;

namespace numberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Киселев Денис
            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            //
            // Cначала написал вариант где мы можем добавить только положительное и ноль, потом изменил, чтобы можно было добавить все числа и складывались только положительные и 0

            Console.WriteLine("  Здравствуйте! Эта программа будет просить ввести числа,\nпока вы не введете 0, потом она посчитатет сумму всех нечетных положительных чисел.");

            List<int> nums = new List<int>() { };

            int enteredNum;
            do
            {
                enteredNum = getNumAndAddToList(nums);
            }
            while (enteredNum != 0);

            Console.WriteLine(nums);

            int sum = 0;
            foreach (int num in nums)
            {
                if (num >= 0)
                {
                    sum += num;
                }
            }

            Console.WriteLine($"\nСумма ваших чисел равна --> {sum}");
        }

        private static int getNumAndAddToList(List<int> nums)
        {
            Console.Write("\n");
            int enteredNum;
            int.TryParse(Console.ReadLine(), out enteredNum);

            nums.Add(enteredNum);

            return enteredNum;
        }
    }
}
