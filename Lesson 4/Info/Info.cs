using System;

class Program
{
    static void ShowTerm(int number)
    {
        Console.WriteLine("\n========================================");

        switch (number)
        {
            case 1:
                Console.WriteLine("ЭКВИВАЛЕНТНЫЙ КЛАСС\n");
                Console.WriteLine(
                    "Группа входных значений, которые должны " +
                    "обрабатываться программой одинаковым образом.");
                break;

            case 2:
                Console.WriteLine("EQUIVALENCE PARTITIONING\n");
                Console.WriteLine(
                    "Техника тест-дизайна, при которой входные данные " +
                    "разделяются на классы эквивалентности.");
                break;

            case 3:
                Console.WriteLine("ВАЛИДНЫЙ КЛАСС\n");
                Console.WriteLine(
                    "Класс данных, значения которого соответствуют " +
                    "требованиям программы.");
                break;

            case 4:
                Console.WriteLine("НЕВАЛИДНЫЙ КЛАСС\n");
                Console.WriteLine(
                    "Класс данных, значения которого не соответствуют " +
                    "требованиям программы.");
                break;

            case 5:
                Console.WriteLine("ПРЕДСТАВИТЕЛЬ КЛАССА\n");
                Console.WriteLine(
                    "Конкретное значение, выбранное для проверки " +
                    "эквивалентного класса.");
                break;

            case 6:
                Console.WriteLine("DECISION TABLE\n");
                Console.WriteLine(
                    "Таблица решений — способ описать поведение программы " +
                    "для различных комбинаций условий.");
                break;

            case 7:
                Console.WriteLine("УСЛОВИЕ\n");
                Console.WriteLine(
                    "Обстоятельство, которое влияет на поведение программы. " +
                    "Например: пользователь является VIP.");
                break;

            case 8:
                Console.WriteLine("ПРАВИЛО\n");
                Console.WriteLine(
                    "Правило в таблице решений описывает, что должна сделать " +
                    "программа при определенной комбинации условий.");
                break;

            case 9:
                Console.WriteLine("КОМБИНАЦИЯ УСЛОВИЙ\n");
                Console.WriteLine(
                    "Набор одновременно выполняющихся условий.");
                break;

            case 10:
                Console.WriteLine("ЛОГИЧЕСКОЕ AND\n");
                Console.WriteLine(
                    "Оператор AND означает «И». Все связанные условия " +
                    "должны быть истинными.");
                break;

            case 11:
                Console.WriteLine("ЛОГИЧЕСКОЕ OR\n");
                Console.WriteLine(
                    "Оператор OR означает «ИЛИ». Достаточно, чтобы " +
                    "истинным было хотя бы одно условие.");
                break;

            case 12:
                Console.WriteLine("ТЕСТОВАЯ КОМБИНАЦИЯ\n");
                Console.WriteLine(
                    "Конкретный набор входных данных, выбранный " +
                    "для проверки определенного сочетания условий.");
                break;

            default:
                Console.WriteLine("Такого термина нет.");
                break;
        }

        Console.WriteLine("========================================");
    }

    static void ShowMenu()
    {
        Console.WriteLine("\n======= ЭКВИВАЛЕНТНЫЕ КЛАССЫ =======");
        Console.WriteLine("1. Эквивалентный класс");
        Console.WriteLine("2. Equivalence Partitioning");
        Console.WriteLine("3. Валидный класс");
        Console.WriteLine("4. Невалидный класс");
        Console.WriteLine("5. Представитель класса");
        Console.WriteLine("6. Decision Table");
        Console.WriteLine("7. Условие");
        Console.WriteLine("8. Правило");
        Console.WriteLine("9. Комбинация условий");
        Console.WriteLine("10. Логическое AND");
        Console.WriteLine("11. Логическое OR");
        Console.WriteLine("12. Тестовая комбинация");
        Console.WriteLine("0. Выход");
        Console.WriteLine("====================================");
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