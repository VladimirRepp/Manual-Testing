using System;

// Задание для разбора со студентами

class Program
{
    static void Register()
    {
        Console.Write("\nВведите логин: ");
        string login = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        Console.Write("Введите возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (login.Length < 3 || login.Length > 15)
        {
            Console.WriteLine("Некорректный логин.");
            return;
        }

        if (password.Length < 6)
        {
            Console.WriteLine("Некорректный пароль.");
            return;
        }

        if (age < 12)
        {
            Console.WriteLine("Регистрация запрещена.");
            return;
        }

        Console.WriteLine("Аккаунт успешно создан!");
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n======= GAME ACCOUNT =======");
            Console.WriteLine("1. Регистрация");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Register();
            }

        } while (choice != 0);
    }
}