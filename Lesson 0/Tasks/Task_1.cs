using System;


class Program
{
    static int coins = 1000;

    static void ShowCoins()
    {
        Console.WriteLine($"\nМонеты: {coins}");
    }

    static void BuyItem()
    {
        int price = 700;

        Console.WriteLine($"\nЦена предмета: {price}");

        if (coins >= price)
        {
            coins -= price;
            Console.WriteLine("Предмет куплен!");
        }
        else
        {
            Console.WriteLine("Недостаточно монет.");
        }
    }

    static void AddCoins()
    {
        Console.Write("\nВведите количество монет: ");
        int value = Convert.ToInt32(Console.ReadLine());

        coins += value;

        Console.WriteLine("Монеты добавлены.");
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n========== GAME SHOP ==========");
            Console.WriteLine("1. Показать монеты");
            Console.WriteLine("2. Купить предмет");
            Console.WriteLine("3. Добавить монеты");
            Console.WriteLine("0. Выход");
            Console.WriteLine("===============================");

            Console.Write("Выберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowCoins();
                    break;

                case 2:
                    BuyItem();
                    break;

                case 3:
                    AddCoins();
                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine("Неизвестная команда.");
                    break;
            }

        } while (choice != 0);
    }
}
