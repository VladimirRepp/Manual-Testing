using System;

class Program
{
    static void ShowTerm(int number)
    {
        Console.WriteLine("\n========================================");

        switch (number)
        {
            case 1:
                Console.WriteLine("ГРАНИЧНОЕ ЗНАЧЕНИЕ\n");
                Console.WriteLine(
                    "Значение, находящееся на границе допустимого " +
                    "диапазона или рядом с ней.");
                break;

            case 2:
                Console.WriteLine("BOUNDARY VALUE ANALYSIS\n");
                Console.WriteLine(
                    "Анализ граничных значений — техника тест-дизайна, " +
                    "при которой особое внимание уделяется значениям " +
                    "на границах диапазона.");
                break;

            case 3:
                Console.WriteLine("ДОПУСТИМЫЙ ДИАПАЗОН\n");
                Console.WriteLine(
                    "Диапазон значений, которые программа должна принимать.");
                break;

            case 4:
                Console.WriteLine("МИНИМАЛЬНОЕ ЗНАЧЕНИЕ\n");
                Console.WriteLine(
                    "Наименьшее значение, которое считается допустимым.");
                break;

            case 5:
                Console.WriteLine("МАКСИМАЛЬНОЕ ЗНАЧЕНИЕ\n");
                Console.WriteLine(
                    "Наибольшее значение, которое считается допустимым.");
                break;

            case 6:
                Console.WriteLine("ЗНАЧЕНИЕ НИЖЕ МИНИМУМА\n");
                Console.WriteLine(
                    "Значение, которое находится непосредственно " +
                    "ниже разрешенной нижней границы.");
                break;

            case 7:
                Console.WriteLine("ЗНАЧЕНИЕ ВЫШЕ МАКСИМУМА\n");
                Console.WriteLine(
                    "Значение, которое находится непосредственно " +
                    "выше разрешенной верхней границы.");
                break;

            case 8:
                Console.WriteLine("ВНУТРЕННЕЕ ЗНАЧЕНИЕ\n");
                Console.WriteLine(
                    "Значение внутри допустимого диапазона, " +
                    "которое не является границей.");
                break;

            case 9:
                Console.WriteLine("ГРАНИЧНАЯ ОШИБКА\n");
                Console.WriteLine(
                    "Ошибка, связанная с неправильной обработкой " +
                    "границы допустимого диапазона.");
                break;

            case 10:
                Console.WriteLine("ДИАПАЗОН\n");
                Console.WriteLine(
                    "Набор значений между минимальной и максимальной границами.");
                break;

            case 11:
                Console.WriteLine("ЭКВИВАЛЕНТНЫЙ КЛАСС\n");
                Console.WriteLine(
                    "Группа значений, которые программа должна обрабатывать " +
                    "одинаковым образом.");
                break;

            case 12:
                Console.WriteLine("EQUIVALENCE PARTITIONING\n");
                Console.WriteLine(
                    "Разбиение входных данных на группы, внутри которых " +
                    "значения считаются эквивалентными с точки зрения тестирования.");
                break;

            default:
                Console.WriteLine("Такого термина нет.");
                break;
        }

        Console.WriteLine("========================================");
    }

    static void ShowMenu()
    {
        Console.WriteLine("\n========== ГРАНИЧНЫЕ ЗНАЧЕНИЯ ==========");
        Console.WriteLine("1. Граничное значение");
        Console.WriteLine("2. Boundary Value Analysis");
        Console.WriteLine("3. Допустимый диапазон");
        Console.WriteLine("4. Минимальное значение");
        Console.WriteLine("5. Максимальное значение");
        Console.WriteLine("6. Значение ниже минимума");
        Console.WriteLine("7. Значение выше максимума");
        Console.WriteLine("8. Внутреннее значение");
        Console.WriteLine("9. Граничная ошибка");
        Console.WriteLine("10. Диапазон");
        Console.WriteLine("11. Эквивалентный класс");
        Console.WriteLine("12. Equivalence Partitioning");
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