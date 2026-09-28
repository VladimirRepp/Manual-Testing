using System;

// Тематика: доступ к игровому режиму

class Program
{
    static void CheckAccess()
    {
        Console.Write("Уровень игрока: ");
        int level = Convert.ToInt32(Console.ReadLine());

        Console.Write("Есть Premium? 1/0: ");
        int premium = Convert.ToInt32(Console.ReadLine());

        if (level >= 30 || premium == 1)
        {
            Console.WriteLine("Доступ разрешен.");
        }
        else
        {
            Console.WriteLine("Доступ запрещен.");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n======= GAME MODE =======");
            Console.WriteLine("1. Проверить доступ");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CheckAccess();
            }

        } while (choice != 0);
    }
}