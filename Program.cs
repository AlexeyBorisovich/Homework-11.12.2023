using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        bool isDivisible = CheckDivisibility(userNumber);

        if (isDivisible)
        {
            Console.WriteLine($"{userNumber} кратно 7 и 23.");
        }
        else
        {
            Console.WriteLine($"{userNumber} не кратно одновременно 7 и 23.");
        }
    }
    static bool CheckDivisibility(int number)
    {
        return (number % 7 == 0) && (number % 23 == 0);
    }
}