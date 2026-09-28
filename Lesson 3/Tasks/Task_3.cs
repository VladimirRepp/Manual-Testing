using System;

// Тематика: игровой возраст

class Program
{
    static void CheckAge()
    {
        Console.Write("Введите возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 12 && age <= 65)
        {
            Console.WriteLine("Возраст подходит.");
        }
        else
        {
            Console.WriteLine("Возраст не подходит.");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n========= GAME =========");
            Console.WriteLine("1. Проверить возраст");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CheckAge();
            }

        } while (choice != 0);
    }
}