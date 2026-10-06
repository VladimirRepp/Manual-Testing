#include <iostream>

using namespace std;

void showTerm(int number)
{
    switch (number)
    {
        case 1:
            cout << "\nBUG / DEFECT\n";
            cout << "Bug или Defect — несоответствие фактического поведения "
                    "программы требованиям или ожидаемому результату.\n";
            break;

        case 2:
            cout << "\nBUG REPORT\n";
            cout << "Bug Report — документ, в котором тестировщик подробно "
                    "описывает обнаруженный дефект.\n";
            break;

        case 3:
            cout << "\nSUMMARY\n";
            cout << "Summary — краткое описание проблемы в одной строке. "
                    "По Summary должно быть понятно, что произошло.\n";
            break;

        case 4:
            cout << "\nDESCRIPTION\n";
            cout << "Description — подробное описание обнаруженной проблемы "
                    "и дополнительная информация о ней.\n";
            break;

        case 5:
            cout << "\nENVIRONMENT\n";
            cout << "Environment — окружение, в котором обнаружен дефект: "
                    "устройство, операционная система, версия программы и другие условия.\n";
            break;

        case 6:
            cout << "\nPRECONDITIONS\n";
            cout << "Preconditions — условия, которые должны быть выполнены "
                    "до начала воспроизведения дефекта.\n";
            break;

        case 7:
            cout << "\nSTEPS TO REPRODUCE\n";
            cout << "Steps to Reproduce — последовательность действий, "
                    "необходимая для воспроизведения дефекта.\n";
            break;

        case 8:
            cout << "\nTEST DATA\n";
            cout << "Test Data — данные, которые используются во время проверки: "
                    "логин, пароль, число, промокод и другие значения.\n";
            break;

        case 9:
            cout << "\nEXPECTED RESULT\n";
            cout << "Expected Result — результат, который должен произойти "
                    "согласно требованиям программы.\n";
            break;

        case 10:
            cout << "\nACTUAL RESULT\n";
            cout << "Actual Result — результат, который фактически произошел "
                    "при выполнении теста.\n";
            break;

        case 11:
            cout << "\nEVIDENCE\n";
            cout << "Evidence — доказательство существования дефекта: "
                    "скриншот, видео, лог или другой материал.\n";
            break;

        case 12:
            cout << "\nREPRODUCIBILITY\n";
            cout << "Reproducibility — возможность повторно воспроизвести "
                    "обнаруженный дефект.\n";
            break;

        case 13:
            cout << "\nATTACHMENT\n";
            cout << "Attachment — файл, приложенный к Bug Report: "
                    "скриншот, видео, лог или другой необходимый материал.\n";
            break;

        case 14:
            cout << "\nWORKAROUND\n";
            cout << "Workaround — временный способ обойти проблему, "
                    "не исправляя сам дефект.\n";
            break;

        case 15:
            cout << "\nCLEAR STEPS\n";
            cout << "Clear Steps — шаги воспроизведения должны быть конкретными, "
                    "понятными и последовательными.\n";
            break;

        case 16:
            cout << "\nDUPLICATE BUG\n";
            cout << "Duplicate Bug — дефект, который уже был зарегистрирован "
                    "в другом Bug Report.\n";
            break;

        case 17:
            cout << "\nNOT A BUG\n";
            cout << "Not a Bug — результат проверки, который не является дефектом, "
                    "потому что фактическое поведение соответствует требованиям.\n";
            break;

        case 18:
            cout << "\nGOOD BUG REPORT\n";
            cout << "Хороший Bug Report позволяет разработчику понять проблему "
                    "и воспроизвести ее без дополнительных догадок.\n";
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
        cout << "QA DICTIONARY — LESSON 6\n";
        cout << "====================================\n";

        cout << "1. Bug / Defect\n";
        cout << "2. Bug Report\n";
        cout << "3. Summary\n";
        cout << "4. Description\n";
        cout << "5. Environment\n";
        cout << "6. Preconditions\n";
        cout << "7. Steps to Reproduce\n";
        cout << "8. Test Data\n";
        cout << "9. Expected Result\n";
        cout << "10. Actual Result\n";
        cout << "11. Evidence\n";
        cout << "12. Reproducibility\n";
        cout << "13. Attachment\n";
        cout << "14. Workaround\n";
        cout << "15. Clear Steps\n";
        cout << "16. Duplicate Bug\n";
        cout << "17. Not a Bug\n";
        cout << "18. Good Bug Report\n";
        cout << "0. Выход\n";

        cout << "\nВыберите термин: ";
        cin >> choice;

        if (choice != 0)
            showTerm(choice);

    } while (choice != 0);

    return 0;
}