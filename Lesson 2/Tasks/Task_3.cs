using System;

// Тематика: игровое оружие

class Program
{
    static void Shoot()
    {
        int ammo = 10;

        Console.Write("Сколько раз выстрелить: ");
        int count = Convert.ToInt32(Console.ReadLine());

        if (count <= 0)
        {
            Console.WriteLine("Количество выстрелов некорректно.");
            return;
        }

        if (count > ammo)
        {
            Console.WriteLine("Недостаточно патронов.");
            return;
        }

        ammo -= count;

        Console.WriteLine("Выстрел выполнен.");
        Console.WriteLine($"Осталось патронов: {ammo}");
    }

    static void Main()
    {
        Shoot();
    }
}