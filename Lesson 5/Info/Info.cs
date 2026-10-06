using System;

class Program
{
    static void ShowTerm(int number)
    {
        switch (number)
        {
            case 1:
                Console.WriteLine("\nBUG / DEFECT");
                Console.WriteLine(
                    "Bug или Defect — несоответствие фактического поведения " +
                    "программы требованиям или ожидаемому результату.");
                break;

            case 2:
                Console.WriteLine("\nBUG REPORT");
                Console.WriteLine(
                    "Bug Report — документ, в котором тестировщик подробно " +
                    "описывает обнаруженный дефект.");
                break;

            case 3:
                Console.WriteLine("\nSUMMARY");
                Console.WriteLine(
                    "Summary — краткое описание проблемы в одной строке. " +
                    "По Summary должно быть понятно, что произошло.");
                break;

            case 4:
                Console.WriteLine("\nDESCRIPTION");
                Console.WriteLine(
                    "Description — подробное описание обнаруженной проблемы " +
                    "и дополнительная информация о ней.");
                break;

            case 5:
                Console.WriteLine("\nENVIRONMENT");
                Console.WriteLine(
                    "Environment — окружение, в котором обнаружен дефект: " +
                    "устройство, операционная система, версия программы и другие условия.");
                break;

            case 6:
                Console.WriteLine("\nPRECONDITIONS");
                Console.WriteLine(
                    "Preconditions — условия, которые должны быть выполнены " +
                    "до начала воспроизведения дефекта.");
                break;

            case 7:
                Console.WriteLine("\nSTEPS TO REPRODUCE");
                Console.WriteLine(
                    "Steps to Reproduce — последовательность действий, " +
                    "необходимая для воспроизведения дефекта.");
                break;

            case 8:
                Console.WriteLine("\nTEST DATA");
                Console.WriteLine(
                    "Test Data — данные, которые используются во время проверки: " +
                    "логин, пароль, число, промокод и другие значения.");
                break;

            case 9:
                Console.WriteLine("\nEXPECTED RESULT");
                Console.WriteLine(
                    "Expected Result — результат, который должен произойти " +
                    "согласно требованиям программы.");
                break;

            case 10:
                Console.WriteLine("\nACTUAL RESULT");
                Console.WriteLine(
                    "Actual Result — результат, который фактически произошел " +
                    "при выполнении теста.");
                break;

            case 11:
                Console.WriteLine("\nEVIDENCE");
                Console.WriteLine(
                    "Evidence — доказательство существования дефекта: " +
                    "скриншот, видео, лог или другой материал.");
                break;

            case 12:
                Console.WriteLine("\nREPRODUCIBILITY");
                Console.WriteLine(
                    "Reproducibility — возможность повторно воспроизвести " +
                    "обнаруженный дефект.");
                break;

            case 13:
                Console.WriteLine("\nATTACHMENT");
                Console.WriteLine(
                    "Attachment — файл, приложенный к Bug Report: " +
                    "скриншот, видео, лог или другой необходимый материал.");
                break;

            case 14:
                Console.WriteLine("\nWORKAROUND");
                Console.WriteLine(
                    "Workaround — временный способ обойти проблему, " +
                    "не исправляя сам дефект.");
                break;

            case 15:
                Console.WriteLine("\nCLEAR STEPS");
                Console.WriteLine(
                    "Clear Steps — шаги воспроизведения должны быть конкретными, " +
                    "понятными и последовательными.");
                break;

            case 16:
                Console.WriteLine("\nDUPLICATE BUG");
                Console.WriteLine(
                    "Duplicate Bug — дефект, который уже был зарегистрирован " +
                    "в другом Bug Report.");
                break;

            case 17:
                Console.WriteLine("\nNOT A BUG");
                Console.WriteLine(
                    "Not a Bug — результат проверки, который не является дефектом, " +
                    "потому что фактическое поведение соответствует требованиям.");
                break;

            case 18:
                Console.WriteLine("\nGOOD BUG REPORT");
                Console.WriteLine(
                    "Хороший Bug Report позволяет разработчику понять проблему " +
                    "и воспроизвести ее без дополнительных догадок.");
                break;

            default:
                Console.WriteLine("\nТермин с таким номером отсутствует.");
                break;
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine("QA DICTIONARY — LESSON 6");
            Console.WriteLine("====================================");

            Console.WriteLine("1. Bug / Defect");
            Console.WriteLine("2. Bug Report");
            Console.WriteLine("3. Summary");
            Console.WriteLine("4. Description");
            Console.WriteLine("5. Environment");
            Console.WriteLine("6. Preconditions");
            Console.WriteLine("7. Steps to Reproduce");
            Console.WriteLine("8. Test Data");
            Console.WriteLine("9. Expected Result");
            Console.WriteLine("10. Actual Result");
            Console.WriteLine("11. Evidence");
            Console.WriteLine("12. Reproducibility");
            Console.WriteLine("13. Attachment");
            Console.WriteLine("14. Workaround");
            Console.WriteLine("15. Clear Steps");
            Console.WriteLine("16. Duplicate Bug");
            Console.WriteLine("17. Not a Bug");
            Console.WriteLine("18. Good Bug Report");
            Console.WriteLine("0. Выход");

            Console.Write("\nВыберите термин: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice != 0)
                ShowTerm(choice);

        } while (choice != 0);
    }
}