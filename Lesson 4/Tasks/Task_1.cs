using System;

// Тематика: скидка в интернет-магазине

class Program
{
    static void CheckDiscount()
    {
        Console.Write("VIP клиент? 1/0: ");
        int vip = Convert.ToInt32(Console.ReadLine());

        Console.Write("Сумма заказа: ");
        double order = Convert.ToDouble(Console.ReadLine());

        if (vip == 1 || order >= 10000)
        {
            Console.WriteLine("Скидка 20%.");
        }
        else
        {
            Console.WriteLine("Скидка 5%.");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n======= SHOP =======");
            Console.WriteLine("1. Проверить скидку");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CheckDiscount();
            }

        } while (choice != 0);
    }
}