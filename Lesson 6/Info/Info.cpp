#include <iostream>
#include <string>

using namespace std;

void showTerm(int number)
{
    switch (number)
    {
        case 1:
            cout << "\nBUG / DEFECT\n";
            cout << "Дефект — это несоответствие фактического поведения программы "
                    "требованиям или ожидаемому результату.\n";
            break;

        case 2:
            cout << "\nBUG REPORT\n";
            cout << "Bug Report — описание обнаруженного дефекта с необходимой "
                    "информацией для его воспроизведения и исправления.\n";
            break;

        case 3:
            cout << "\nBUG LIFECYCLE\n";
            cout << "Bug Lifecycle — последовательность состояний, через которые "
                    "проходит дефект от обнаружения до закрытия.\n";
            break;

        case 4:
            cout << "\nNEW\n";
            cout << "New — дефект обнаружен и зарегистрирован, но еще не обработан командой.\n";
            break;

        case 5:
            cout << "\nASSIGNED\n";
            cout << "Assigned — дефект назначен конкретному разработчику или команде.\n";
            break;

        case 6:
            cout << "\nIN PROGRESS\n";
            cout << "In Progress — разработчик занимается исправлением дефекта.\n";
            break;

        case 7:
            cout << "\nFIXED\n";
            cout << "Fixed — разработчик сообщает, что дефект исправлен и готов к проверке.\n";
            break;

        case 8:
            cout << "\nRETEST\n";
            cout << "Retest — повторная проверка ранее обнаруженного дефекта после его исправления.\n";
            break;

        case 9:
            cout << "\nCLOSED\n";
            cout << "Closed — дефект исправлен и успешно проверен тестировщиком.\n";
            break;

        case 10:
            cout << "\nREOPENED\n";
            cout << "Reopened — дефект снова открыт, если после исправления проблема осталась.\n";
            break;

        case 11:
            cout << "\nSEVERITY\n";
            cout << "Severity — степень влияния дефекта на работу программы.\n";
            break;

        case 12:
            cout << "\nPRIORITY\n";
            cout << "Priority — важность и срочность исправления дефекта.\n";
            break;

        case 13:
            cout << "\nCRITICAL\n";
            cout << "Critical — дефект с очень серьезными последствиями, "
                    "например невозможностью запустить или использовать основную функцию.\n";
            break;

        case 14:
            cout << "\nHIGH SEVERITY\n";
            cout << "High Severity — серьезный дефект, который существенно "
                    "ограничивает работу пользователя или важную функцию.\n";
            break;

        case 15:
            cout << "\nMEDIUM SEVERITY\n";
            cout << "Medium Severity — дефект с заметным, но не критическим влиянием на систему.\n";
            break;

        case 16:
            cout << "\nLOW SEVERITY\n";
            cout << "Low Severity — небольшой дефект, который практически не мешает работе пользователя.\n";
            break;

        case 17:
            cout << "\nHIGH PRIORITY\n";
            cout << "High Priority — дефект, исправление которого необходимо выполнить в первую очередь.\n";
            break;

        case 18:
            cout << "\nLOW PRIORITY\n";
            cout << "Low Priority — дефект, исправление которого можно выполнить позднее.\n";
            break;

        default:
            cout << "\nТермин с таким номером отсутствует.\n";
            break;
    }
}

int main()
{
    int choice;

    do
    {
        cout << "\n====================================\n";
        cout << "QA DICTIONARY — LESSON 7\n";
        cout << "====================================\n";

        cout << "1. Bug / Defect\n";
        cout << "2. Bug Report\n";
        cout << "3. Bug Lifecycle\n";
        cout << "4. New\n";
        cout << "5. Assigned\n";
        cout << "6. In Progress\n";
        cout << "7. Fixed\n";
        cout << "8. Retest\n";
        cout << "9. Closed\n";
        cout << "10. Reopened\n";
        cout << "11. Severity\n";
        cout << "12. Priority\n";
        cout << "13. Critical\n";
        cout << "14. High Severity\n";
        cout << "15. Medium Severity\n";
        cout << "16. Low Severity\n";
        cout << "17. High Priority\n";
        cout << "18. Low Priority\n";
        cout << "0. Выход\n";

        cout << "\nВыберите термин: ";
        cin >> choice;

        if (choice != 0)
            showTerm(choice);

    } while (choice != 0);

    return 0;
}