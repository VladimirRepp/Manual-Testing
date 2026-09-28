// Тематика: интернет-магазин

using System;

class Program
{
    static int cartItems = 0;

    static void AddProduct()
    {
        Console.Write("Количество товаров: ");
        int count = Convert.ToInt32(Console.ReadLine());

        cartItems += count;

        Console.WriteLine("Товары добавлены в корзину.");
    }

    static void RemoveProduct()
    {
        Console.Write("Количество товаров: ");
        int count = Convert.ToInt32(Console.ReadLine());

        cartItems -= count;

        Console.WriteLine("Товары удалены.");
    }

    static void ShowCart()
    {
        Console.WriteLine($"\nВ корзине товаров: {cartItems}");
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n========== SHOP ==========");
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Удалить товар");
            Console.WriteLine("3. Показать корзину");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;

                case 2:
                    RemoveProduct();
                    break;

                case 3:
                    ShowCart();
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