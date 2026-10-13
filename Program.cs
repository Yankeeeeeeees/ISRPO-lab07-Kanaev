using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {

        // 1.1
        // string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};

        // for (int i = days.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(days[i]);
        // }

        // 1.2
        // double[] temps = {15.5, 13.2, -5.0, 0.0, 10.1, 20.3, 25.6};
        // foreach (double temp in temps)
        // {
        //     Console.Write($"{temp} ");
        // }
        


        // 2.0
        int[] prices = { 120, 45, 300, 80, 15, 210 };
        // int sum = 0;
        // int sred = 0;
        // int more100 = 0;
        // for (int i = 0; i < prices.Length; i++)
        // {
        //     sum += prices[i];
        //     sred = sum / prices.Length;
        //     if (prices[i] > 100)
        //     {
        //         more100++;
        //     }
        // }
        // Console.WriteLine($"Сумма: {sum}");
        // Console.WriteLine($"Среднее: {sred}");
        // Console.WriteLine($"Количество товаров дороже 100: {more100}");


        //  3.0
        // int minPrice = 0;
        // int maxPrice = 0;
        // int index = 0;
        // for (int i = 0; i < prices.Length; i++)
        // {
        //     if (prices[i] < prices[minPrice])
        //     {
        //         minPrice = i;
        //     }
        //     if (prices[i] > prices[maxPrice])
        //     {
        //         maxPrice = i;
        //         index = i;
        //     }

        // }
        // Console.WriteLine($"Минимальная цена: {prices[minPrice]}");
        // Console.WriteLine($"Максимальная цена: {prices[maxPrice]} и его индекс: {index}");
        //  4.0
        // int[] balance = { 100, -50, 20, -5, 0, 75 };
        // for (int i = 0; i < balance.Length; i++)
        // {
        //     if (balance[i] < 0)
        //     {
        //         balance[i] = 0;
        //     }
        // }
        // foreach (int b in balance)
        // {
        //     Console.Write($"{b} ");
        // }




        // 5.0
        // int[] poom= new int[5];
        // Console.WriteLine("Введите 5 чисел:");
        // for (int i = 0; i < poom.Length; i++)
        // {
        //     poom[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.WriteLine("Числа в обратном ппорядке: ");
        // for (int i = poom.Length - 1; i >= 0; i--)
        // {
        //     Console.Write($"{poom[i]} ");
            
        // }
        // Console.WriteLine("");
        // int evenCount = 0;
        // for (int i = 0; i < poom.Length; i++)
        // {
        //     if (poom[i] % 2 == 0)
        //     {
        //         evenCount++;    
        //     }
        // }

        // Console.WriteLine($"Количество четных чисел: {evenCount}");


        // 6.0

        // string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
        // string userInput = Console.ReadLine()!;
        // for (int i = 0; i < names.Length; i++)
        // {
        //     if (names[i] == userInput)
        //     {
        //         Console.WriteLine($"Имя {userInput} найдено в массиве. Индекс: {i}");
        //         return;
        //     }
        // }
        // Console.WriteLine($"Имя {userInput} не найдено в массиве.");


        // итоговое задание

        int[] grades = {2, 4, 5, 3, 5};
        // int sum = grades.Sum();
        int sum = 0;
        int min = 0;
        int max = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        double average = (double)sum / grades.Length;
        foreach (int grade in grades)
        {
            Console.Write($"{grade} ");
        }
        Console.WriteLine(" ");
        Console.WriteLine($"\nСредний балл: {average}");
        // Console.WriteLine($"Максимальный балл: {grades.Max()}");
        foreach (int grade in grades)
        {
            if (grade > min)
            {
                min = grade;
            }
            if (grade < max)
            {
                max = grade;
            }
        }
        // Console.WriteLine($"Минимальный балл: {grades.Min()}");

        int count2 = 0;
        int count5 = 0;
        foreach (int grade in grades)
        {
            if (grade == 2)
            {
                count2++;
            } else if (grade == 5)
            {
                count5++;
            }
        }
        Console.WriteLine($"Двоек: {count2}, пятерок: {count5}");

        if (average >= 4.5)
        {
            Console.WriteLine("Отличник");
        } else if (average >= 3.5)
        {
            Console.WriteLine("Хорошист");
        } else
        {
            Console.WriteLine("Есть над чем поработать");
        }





    }   

}   