using System;

// Тематика: промокод магазина

class Program
{
    static void ApplyPromo()
    {
        Console.Write("Введите сумму заказа: ");
        double order = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите промокод: ");
        string promo = Console.ReadLine();

        if (order <= 0)
        {
            Console.WriteLine("Некорректная сумма.");
            return;
        }

        if (promo == "GAME10")
        {
            double discount = order * 0.10;
            order -= discount;

            Console.WriteLine($"Итоговая сумма: {order}");
        }
        else
        {
            Console.WriteLine("Промокод недействителен.");
        }
    }

    static void Main()
    {
        ApplyPromo();
    }
}