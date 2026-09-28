#include <iostream>
using namespace std;

// Тематика: уровень персонажа

// Что протестировать: 
// 0
// 1
// 2
// 25
// 49
// 50
// 51

void checkLevel()
{
    int level;

    cout << "Введите уровень: ";
    cin >> level;

    if (level >= 1 && level <= 50)
    {
        cout << "Уровень допустим.\n";
    }
    else
    {
        cout << "Недопустимый уровень.\n";
    }
}

int main()
{
    int choice;

    do
    {
        cout << "\n======= CHARACTER =======\n";
        cout << "1. Проверить уровень\n";
        cout << "0. Выход\n";

        cin >> choice;

        if (choice == 1)
        {
            checkLevel();
        }

    } while (choice != 0);

    return 0;
}