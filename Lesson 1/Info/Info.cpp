#include <iostream>

using namespace std;

void showTerm(int number)
{
    cout << "\n========================================\n";

    switch (number)
    {
        case 1:
            cout << "TEST CASE\n\n";
            cout << "Подробное описание одной проверки программы. "
                    "Содержит условия, шаги, данные и ожидаемый результат.\n";
            break;

        case 2:
            cout << "CHECKLIST\n\n";
            cout << "Список проверок, которые необходимо выполнить. "
                    "Обычно записывается кратко.\n";
            break;

        case 3:
            cout << "PRECONDITIONS\n\n";
            cout << "Предусловия — условия, которые должны быть выполнены "
                    "до начала теста.\n"
                    "Например: пользователь уже зарегистрирован.\n";
            break;

        case 4:
            cout << "TEST STEPS\n\n";
            cout << "Шаги теста — последовательность действий, которые "
                    "необходимо выполнить для проверки.\n";
            break;

        case 5:
            cout << "TEST DATA\n\n";
            cout << "Тестовые данные — значения, которые используются "
                    "во время проверки.\n"
                    "Например: логин, пароль, возраст или сумма заказа.\n";
            break;

        case 6:
            cout << "EXPECTED RESULT\n\n";
            cout << "Результат, который программа должна показать "
                    "при правильной работе.\n";
            break;

        case 7:
            cout << "ACTUAL RESULT\n\n";
            cout << "Результат, который программа фактически показала "
                    "при выполнении теста.\n";
            break;

        case 8:
            cout << "PASS\n\n";
            cout << "Проверка успешно пройдена. Фактический результат "
                    "соответствует ожидаемому.\n";
            break;

        case 9:
            cout << "FAIL\n\n";
            cout << "Проверка не пройдена. Фактический результат "
                    "отличается от ожидаемого.\n";
            break;

        case 10:
            cout << "TEST SUITE\n\n";
            cout << "Набор связанных Test Case, которые проверяют "
                    "одну функциональность или часть системы.\n";
            break;

        case 11:
            cout << "TEST SCENARIO\n\n";
            cout << "Общее описание того, что необходимо проверить. "
                    "Один сценарий может содержать несколько Test Case.\n";
            break;

        case 12:
            cout << "TEST ENVIRONMENT\n\n";
            cout << "Среда тестирования — устройство, операционная система, "
                    "версия программы и другие условия, в которых выполняется тест.\n";
            break;

        default:
            cout << "Такого термина нет.\n";
    }

    cout << "========================================\n";
}

void showMenu()
{
    cout << "\n========== TEST CASE ==========\n";
    cout << "1. Test Case\n";
    cout << "2. Checklist\n";
    cout << "3. Preconditions\n";
    cout << "4. Test Steps\n";
    cout << "5. Test Data\n";
    cout << "6. Expected Result\n";
    cout << "7. Actual Result\n";
    cout << "8. Pass\n";
    cout << "9. Fail\n";
    cout << "10. Test Suite\n";
    cout << "11. Test Scenario\n";
    cout << "12. Test Environment\n";
    cout << "0. Выход\n";
    cout << "===============================\n";
}

int main()
{
    int choice;

    do
    {
        showMenu();

        cout << "Выберите термин: ";
        cin >> choice;

        if (choice != 0)
        {
            showTerm(choice);
        }

    } while (choice != 0);

    return 0;
}