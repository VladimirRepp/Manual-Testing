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
                    "Дефект — это несоответствие фактического поведения программы " +
                    "требованиям или ожидаемому результату.");
                break;

            case 2:
                Console.WriteLine("\nBUG REPORT");
                Console.WriteLine(
                    "Bug Report — описание обнаруженного дефекта с необходимой " +
                    "информацией для его воспроизведения и исправления.");
                break;

            case 3:
                Console.WriteLine("\nBUG LIFECYCLE");
                Console.WriteLine(
                    "Bug Lifecycle — последовательность состояний, через которые " +
                    "проходит дефект от обнаружения до закрытия.");
                break;

            case 4:
                Console.WriteLine("\nNEW");
                Console.WriteLine(
                    "New — дефект обнаружен и зарегистрирован, но еще не обработан командой.");
                break;

            case 5:
                Console.WriteLine("\nASSIGNED");
                Console.WriteLine(
                    "Assigned — дефект назначен конкретному разработчику или команде.");
                break;

            case 6:
                Console.WriteLine("\nIN PROGRESS");
                Console.WriteLine(
                    "In Progress — разработчик занимается исправлением дефекта.");
                break;

            case 7:
                Console.WriteLine("\nFIXED");
                Console.WriteLine(
                    "Fixed — разработчик сообщает, что дефект исправлен и готов к проверке.");
                break;

            case 8:
                Console.WriteLine("\nRETEST");
                Console.WriteLine(
                    "Retest — повторная проверка ранее обнаруженного дефекта после его исправления.");
                break;

            case 9:
                Console.WriteLine("\nCLOSED");
                Console.WriteLine(
                    "Closed — дефект исправлен и успешно проверен тестировщиком.");
                break;

            case 10:
                Console.WriteLine("\nREOPENED");
                Console.WriteLine(
                    "Reopened — дефект снова открыт, если после исправления проблема осталась.");
                break;

            case 11:
                Console.WriteLine("\nSEVERITY");
                Console.WriteLine(
                    "Severity — степень влияния дефекта на работу программы.");
                break;

            case 12:
                Console.WriteLine("\nPRIORITY");
                Console.WriteLine(
                    "Priority — важность и срочность исправления дефекта.");
                break;

            case 13:
                Console.WriteLine("\nCRITICAL");
                Console.WriteLine(
                    "Critical — дефект с очень серьезными последствиями, " +
                    "например невозможностью запустить или использовать основную функцию.");
                break;

            case 14:
                Console.WriteLine("\nHIGH SEVERITY");
                Console.WriteLine(
                    "High Severity — серьезный дефект, который существенно " +
                    "ограничивает работу пользователя или важную функцию.");
                break;

            case 15:
                Console.WriteLine("\nMEDIUM SEVERITY");
                Console.WriteLine(
                    "Medium Severity — дефект с заметным, но не критическим влиянием на систему.");
                break;

            case 16:
                Console.WriteLine("\nLOW SEVERITY");
                Console.WriteLine(
                    "Low Severity — небольшой дефект, который практически не мешает работе пользователя.");
                break;

            case 17:
                Console.WriteLine("\nHIGH PRIORITY");
                Console.WriteLine(
                    "High Priority — дефект, исправление которого необходимо выполнить в первую очередь.");
                break;

            case 18:
                Console.WriteLine("\nLOW PRIORITY");
                Console.WriteLine(
                    "Low Priority — дефект, исправление которого можно выполнить позднее.");
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
            Console.WriteLine("QA DICTIONARY — LESSON 7");
            Console.WriteLine("====================================");

            Console.WriteLine("1. Bug / Defect");
            Console.WriteLine("2. Bug Report");
            Console.WriteLine("3. Bug Lifecycle");
            Console.WriteLine("4. New");
            Console.WriteLine("5. Assigned");
            Console.WriteLine("6. In Progress");
            Console.WriteLine("7. Fixed");
            Console.WriteLine("8. Retest");
            Console.WriteLine("9. Closed");
            Console.WriteLine("10. Reopened");
            Console.WriteLine("11. Severity");
            Console.WriteLine("12. Priority");
            Console.WriteLine("13. Critical");
            Console.WriteLine("14. High Severity");
            Console.WriteLine("15. Medium Severity");
            Console.WriteLine("16. Low Severity");
            Console.WriteLine("17. High Priority");
            Console.WriteLine("18. Low Priority");
            Console.WriteLine("0. Выход");

            Console.Write("\nВыберите термин: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice != 0)
                ShowTerm(choice);

        } while (choice != 0);
    }
}