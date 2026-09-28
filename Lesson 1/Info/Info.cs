using System;

class Program
{
    static void ShowTerm(int number)
    {
        Console.WriteLine("\n========================================");

        switch (number)
        {
            case 1:
                Console.WriteLine("TEST CASE\n");
                Console.WriteLine(
                    "Подробное описание одной проверки программы. " +
                    "Содержит условия, шаги, данные и ожидаемый результат.");
                break;

            case 2:
                Console.WriteLine("CHECKLIST\n");
                Console.WriteLine(
                    "Список проверок, которые необходимо выполнить. " +
                    "Обычно записывается кратко.");
                break;

            case 3:
                Console.WriteLine("PRECONDITIONS\n");
                Console.WriteLine(
                    "Предусловия — условия, которые должны быть выполнены " +
                    "до начала теста. Например: пользователь уже зарегистрирован.");
                break;

            case 4:
                Console.WriteLine("TEST STEPS\n");
                Console.WriteLine(
                    "Шаги теста — последовательность действий, которые " +
                    "необходимо выполнить для проверки.");
                break;

            case 5:
                Console.WriteLine("TEST DATA\n");
                Console.WriteLine(
                    "Тестовые данные — значения, которые используются " +
                    "во время проверки.");
                break;

            case 6:
                Console.WriteLine("EXPECTED RESULT\n");
                Console.WriteLine(
                    "Результат, который программа должна показать " +
                    "при правильной работе.");
                break;

            case 7:
                Console.WriteLine("ACTUAL RESULT\n");
                Console.WriteLine(
                    "Результат, который программа фактически показала " +
                    "при выполнении теста.");
                break;

            case 8:
                Console.WriteLine("PASS\n");
                Console.WriteLine(
                    "Проверка успешно пройдена. Фактический результат " +
                    "соответствует ожидаемому.");
                break;

            case 9:
                Console.WriteLine("FAIL\n");
                Console.WriteLine(
                    "Проверка не пройдена. Фактический результат " +
                    "отличается от ожидаемого.");
                break;

            case 10:
                Console.WriteLine("TEST SUITE\n");
                Console.WriteLine(
                    "Набор связанных Test Case, которые проверяют " +
                    "одну функциональность или часть системы.");
                break;

            case 11:
                Console.WriteLine("TEST SCENARIO\n");
                Console.WriteLine(
                    "Общее описание того, что необходимо проверить. " +
                    "Один сценарий может содержать несколько Test Case.");
                break;

            case 12:
                Console.WriteLine("TEST ENVIRONMENT\n");
                Console.WriteLine(
                    "Среда тестирования — устройство, операционная система, " +
                    "версия программы и другие условия выполнения теста.");
                break;

            default:
                Console.WriteLine("Такого термина нет.");
                break;
        }

        Console.WriteLine("========================================");
    }

    static void ShowMenu()
    {
        Console.WriteLine("\n========== TEST CASE ==========");
        Console.WriteLine("1. Test Case");
        Console.WriteLine("2. Checklist");
        Console.WriteLine("3. Preconditions");
        Console.WriteLine("4. Test Steps");
        Console.WriteLine("5. Test Data");
        Console.WriteLine("6. Expected Result");
        Console.WriteLine("7. Actual Result");
        Console.WriteLine("8. Pass");
        Console.WriteLine("9. Fail");
        Console.WriteLine("10. Test Suite");
        Console.WriteLine("11. Test Scenario");
        Console.WriteLine("12. Test Environment");
        Console.WriteLine("0. Выход");
        Console.WriteLine("===============================");
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