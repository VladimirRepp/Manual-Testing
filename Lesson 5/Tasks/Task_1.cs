using System;

class Program
{
    /*
    Описание:
    Игрок покупает игровой предмет за внутриигровые монеты.

    Требования:
    1. У игрока есть 1000 монет.
    2. Предмет стоит 500 монет.
    3. Если монет достаточно, покупка разрешена.
    4. После покупки стоимость предмета списывается.
    5. Если монет недостаточно, покупка запрещена.
    6. Баланс игрока не должен становиться отрицательным.

    Задание тестировщика:
    1. Протестируйте покупку.
    2. Найдите ошибку.
    3. Составьте Bug Report.
    4. Укажите:
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

Студент должен протестировать как минимум:
- значение меньше цены;
- значение, равное цене;
- значение больше цены;
- 0;
- отрицательное значение.

После обнаружения проблемы необходимо оформить полноценный Bug Report.
    */

    static void Main()
    {
        int coins = 1000;
        int price = 500;

        Console.WriteLine("=== Game Shop ===");
        Console.WriteLine("Player coins: " + coins);
        Console.WriteLine("Item price: " + price);

        Console.Write("Enter amount of coins: ");
        int playerCoins = int.Parse(Console.ReadLine());

        if (playerCoins > price)
        {
            Console.WriteLine("Purchase successful.");

            playerCoins -= price;

            Console.WriteLine("Coins left: " + playerCoins);
        }
        else
        {
            Console.WriteLine("Not enough coins.");
        }
    }
}