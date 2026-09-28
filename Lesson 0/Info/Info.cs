using System;

class Program
{
    static void ShowTerm(int number)
    {
        Console.WriteLine("\n========================================");

        switch (number)
        {
            case 1:
                Console.WriteLine("ТЕСТИРОВАНИЕ ПО\n");
                Console.WriteLine(
                    "Тестирование программного обеспечения — это процесс " +
                    "проверки программы, чтобы определить, соответствует ли " +
                    "она требованиям и правильно ли работает.");
                break;

            case 2:
                Console.WriteLine("QA (QUALITY ASSURANCE)\n");
                Console.WriteLine(
                    "QA — обеспечение качества программного обеспечения. " +
                    "QA включает процессы и действия, которые помогают " +
                    "предотвращать ошибки и повышать качество продукта.");
                break;

            case 3:
                Console.WriteLine("РУЧНОЕ ТЕСТИРОВАНИЕ\n");
                Console.WriteLine(
                    "Ручное тестирование — проверка программы человеком " +
                    "без использования автоматических тестов.");
                break;

            case 4:
                Console.WriteLine("АВТОМАТИЗИРОВАННОЕ ТЕСТИРОВАНИЕ\n");
                Console.WriteLine(
                    "Автоматизированное тестирование — выполнение " +
                    "проверок программой или специальным инструментом " +
                    "без постоянного участия человека.");
                break;

            case 5:
                Console.WriteLine("ТРЕБОВАНИЕ\n");
                Console.WriteLine(
                    "Требование описывает, что программа должна делать " +
                    "или каким требованиям должна соответствовать.");
                break;

            case 6:
                Console.WriteLine("ОЖИДАЕМЫЙ РЕЗУЛЬТАТ\n");
                Console.WriteLine(
                    "Ожидаемый результат — то, что должно произойти, " +
                    "если программа работает правильно.");
                break;

            case 7:
                Console.WriteLine("ФАКТИЧЕСКИЙ РЕЗУЛЬТАТ\n");
                Console.WriteLine(
                    "Фактический результат — то, что действительно произошло " +
                    "при выполнении действия в программе.");
                break;

            case 8:
                Console.WriteLine("BUG / ДЕФЕКТ\n");
                Console.WriteLine(
                    "Дефект — ошибка в программе, из-за которой фактическое " +
                    "поведение отличается от ожидаемого.");
                break;

            case 9:
                Console.WriteLine("SUT (SYSTEM UNDER TEST)\n");
                Console.WriteLine(
                    "SUT — система, которую в данный момент тестируют. " +
                    "Это может быть программа, игра, сайт, API или отдельный модуль.");
                break;

            case 10:
                Console.WriteLine("ТЕСТОВЫЙ СЦЕНАРИЙ\n");
                Console.WriteLine(
                    "Тестовый сценарий — описание того, что необходимо " +
                    "проверить в программе.");
                break;

            case 11:
                Console.WriteLine("TEST CASE\n");
                Console.WriteLine(
                    "Test Case — подробная проверка, содержащая условия, " +
                    "шаги выполнения, тестовые данные и ожидаемый результат.");
                break;

            case 12:
                Console.WriteLine("CHECKLIST\n");
                Console.WriteLine(
                    "Checklist — список проверок, которые необходимо выполнить. " +
                    "Обычно содержит краткие пункты без подробных шагов.");
                break;

            default:
                Console.WriteLine("Такого термина нет.");
                break;
        }

        Console.WriteLine("========================================");
    }

    static void ShowMenu()
    {
        Console.WriteLine("\n========== ТЕРМИНЫ QA ==========");
        Console.WriteLine("1. Тестирование ПО");
        Console.WriteLine("2. QA");
        Console.WriteLine("3. Ручное тестирование");
        Console.WriteLine("4. Автоматизированное тестирование");
        Console.WriteLine("5. Требование");
        Console.WriteLine("6. Ожидаемый результат");
        Console.WriteLine("7. Фактический результат");
        Console.WriteLine("8. Bug / Дефект");
        Console.WriteLine("9. SUT");
        Console.WriteLine("10. Тестовый сценарий");
        Console.WriteLine("11. Test Case");
        Console.WriteLine("12. Checklist");
        Console.WriteLine("0. Выход");
        Console.WriteLine("================================");
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

        Console.WriteLine("\nПрограмма завершена.");
    }
}