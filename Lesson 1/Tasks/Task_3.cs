using System;

// Тематика: покупка игрового предмета

class Program
{
    static void BuyItem()
    {
        int coins = 1000;
        int price = 800;

        Console.WriteLine($"Монеты: {coins}");
        Console.WriteLine($"Цена предмета: {price}");

        Console.Write("Количество предметов: ");
        int count = Convert.ToInt32(Console.ReadLine());

        if (count <= 0)
        {
            Console.WriteLine("Количество должно быть больше нуля.");
            return;
        }

        int total = price * count;

        if (coins >= total)
        {
            Console.WriteLine("Покупка выполнена.");
        }
        else
        {
            Console.WriteLine("Недостаточно монет.");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n======= GAME SHOP =======");
            Console.WriteLine("1. Купить предмет");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                BuyItem();
            }

        } while (choice != 0);
    }
}