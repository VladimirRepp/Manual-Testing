using System;

// Программа для разбора со студентами

class Program
{
    static void CheckRating()
    {
        Console.Write("\nВведите рейтинг: ");
        int rating = Convert.ToInt32(Console.ReadLine());

        if (rating >= 1000 && rating <= 3000)
        {
            Console.WriteLine("Рейтинг допустим.");
        }
        else
        {
            Console.WriteLine("Рейтинг недопустим.");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n========= GAME RATING =========");
            Console.WriteLine("1. Проверить рейтинг");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CheckRating();
            }

        } while (choice != 0);
    }
}