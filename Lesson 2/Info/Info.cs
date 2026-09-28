using System;

class Program
{
    static void ShowTerm(int number)
    {
        Console.WriteLine("\n========================================");

        switch (number)
        {
            case 1:
                Console.WriteLine("ПОЗИТИВНОЕ ТЕСТИРОВАНИЕ\n");
                Console.WriteLine(
                    "Проверка программы с корректными данными " +
                    "и правильными действиями пользователя.");
                break;

            case 2:
                Console.WriteLine("НЕГАТИВНОЕ ТЕСТИРОВАНИЕ\n");
                Console.WriteLine(
                    "Проверка поведения программы при некорректных " +
                    "данных или неправильных действиях пользователя.");
                break;

            case 3:
                Console.WriteLine("POSITIVE SCENARIO\n");
                Console.WriteLine(
                    "Сценарий, в котором пользователь выполняет " +
                    "правильные действия и вводит корректные данные.");
                break;

            case 4:
                Console.WriteLine("NEGATIVE SCENARIO\n");
                Console.WriteLine(
                    "Сценарий, в котором проверяется реакция программы " +
                    "на ошибочные или неожиданные действия.");
                break;

            case 5:
                Console.WriteLine("ВАЛИДНЫЕ ДАННЫЕ\n");
                Console.WriteLine(
                    "Данные, которые соответствуют требованиям программы.");
                break;

            case 6:
                Console.WriteLine("НЕВАЛИДНЫЕ ДАННЫЕ\n");
                Console.WriteLine(
                    "Данные, которые не соответствуют требованиям программы.");
                break;

            case 7:
                Console.WriteLine("КОРРЕКТНЫЙ ВВОД\n");
                Console.WriteLine(
                    "Значение введено в допустимом формате и диапазоне.");
                break;

            case 8:
                Console.WriteLine("НЕКОРРЕКТНЫЙ ВВОД\n");
                Console.WriteLine(
                    "Значение имеет неправильный формат или находится " +
                    "за пределами допустимого диапазона.");
                break;

            case 9:
                Console.WriteLine("ОБЯЗАТЕЛЬНОЕ ПОЛЕ\n");
                Console.WriteLine(
                    "Поле, которое пользователь должен заполнить, " +
                    "чтобы продолжить выполнение операции.");
                break;

            case 10:
                Console.WriteLine("ВАЛИДАЦИЯ\n");
                Console.WriteLine(
                    "Проверка введенных данных на соответствие требованиям.");
                break;

            case 11:
                Console.WriteLine("ERROR MESSAGE\n");
                Console.WriteLine(
                    "Сообщение об ошибке, которое программа показывает " +
                    "пользователю при возникновении некорректной ситуации.");
                break;

            case 12:
                Console.WriteLine("ОБРАБОТКА ОШИБКИ\n");
                Console.WriteLine(
                    "Поведение программы при возникновении ошибки. " +
                    "Программа должна корректно реагировать на ошибочные данные.");
                break;

            default:
                Console.WriteLine("Такого термина нет.");
                break;
        }

        Console.WriteLine("========================================");
    }

    static void ShowMenu()
    {
        Console.WriteLine("\n======= ПОЗИТИВНОЕ / НЕГАТИВНОЕ =======");
        Console.WriteLine("1. Позитивное тестирование");
        Console.WriteLine("2. Негативное тестирование");
        Console.WriteLine("3. Positive Scenario");
        Console.WriteLine("4. Negative Scenario");
        Console.WriteLine("5. Валидные данные");
        Console.WriteLine("6. Невалидные данные");
        Console.WriteLine("7. Корректный ввод");
        Console.WriteLine("8. Некорректный ввод");
        Console.WriteLine("9. Обязательное поле");
        Console.WriteLine("10. Валидация");
        Console.WriteLine("11. Error Message");
        Console.WriteLine("12. Обработка ошибки");
        Console.WriteLine("0. Выход");
        Console.WriteLine("========================================");
    }

    static void Main()
    {
        int choice;

        do
        {
            ShowMenu();

            Console.Write("Выберите термин: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice != 0)
            {
                ShowTerm(choice);
            }

        } while (choice != 0);
    }
}