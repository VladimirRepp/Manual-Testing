using System;

class Program
{
    /*
    Описание:
    Программа рассчитывает стоимость заказа
    с учетом промокода.

    Требования:
    1. Стоимость заказа должна быть больше 0.
    2. Промокод GAME10 дает скидку 10%.
    3. При правильном промокоде стоимость уменьшается на 10%.
    4. При неправильном промокоде скидка не предоставляется.
    5. Итоговая стоимость не должна быть отрицательной.

    Задание тестировщика:
    1. Протестируйте расчет стоимости заказа.
    2. Проверьте правильный и неправильный промокод.
    3. Найдите ошибку.
    4. Составьте Bug Report.
    5. Укажите:
       - Summary
       - Description
       - Environment
       - Preconditions
       - Steps to Reproduce
       - Test Data
       - Expected Result
       - Actual Result
       - Reproducibility
       - Evidence

Необходимо проверить как минимум:

Цена	Промокод
1000	GAME10
1000	TEST
1000	пустой
0	GAME10
-100	GAME10

После тестирования студент самостоятельно составляет Bug Report.
    */

    static void Main()
    {
        Console.WriteLine("=== Online Shop ===");

        Console.Write("Enter order price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter promo code: ");
        string promo = Console.ReadLine();

        double total = price;

        if (promo == "GAME10")
        {
            total = price - price * 10 / 100;
        }
        else
        {
            total = price - price * 20 / 100;
        }

        Console.WriteLine("Final price: " + total);
    }
}