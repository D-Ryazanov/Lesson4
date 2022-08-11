using System;

class Program
{
    public static void Main(string[] args)
    {

        void Task25()
        {
            // Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) 
            // и возводит число A в степень B.

            Console.WriteLine("Введите натуральное число которое хоттите возвести в степень");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите натуральную степень в которую хотите возвести число");
            int deg = Convert.ToInt32(Console.ReadLine());
            int result = num;
            if (deg > 0)
            {
                while (deg > 1)
                {
                    result = result * num;
                    deg--;
                }
                Console.WriteLine(num + " в " + deg + " степени равен " + result + ".");
            }
            else
            {
                Console.WriteLine("Число " + deg + " не является натуральным.");
            }
        }

        void Task27()
        {
            // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

            Console.WriteLine("Введите число сумму цифр которого хотите посчитать");
            int num = Convert.ToInt32(Console.ReadLine());
            int savenum = num;
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine("Сумма цифр числа " + savenum + " равна " + sum + ".");

        }

        void Task29()
        {
            // Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

            int[] array = new int[8];
            Random random = new Random();
            int temporary;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int a = 0; a < i; a++)
                    if (Math.Abs(array[a]) > Math.Abs(array[i]))
                    {
                        temporary = array[a];
                        array[a] = array[i];
                        array[i] = temporary;
                    }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        Console.WriteLine("Укажите какое задание хотите проверить (25, 27, 29)");
        int task = Convert.ToInt32(Console.ReadLine());
        if (task == 25)
        {
            Task25();
        }
        else if (task == 27)
        {
            Task27();
        }
        else if (task == 29)
        {
            Task29();
        }
        else
        {
            Console.WriteLine("Такого задания нет.");
        }
    }
}