#include <iostream>
using namespace std;

// Тематика: игровой бонус

// Задание:
// Составить Decision Table для:
// VIP
// Уровень >= 20
// и определить минимальный набор тестов.

void checkBonus()
{
    int level;
    int vip;

    cout << "Уровень игрока: ";
    cin >> level;

    cout << "VIP?\n";
    cout << "1 - Да\n";
    cout << "0 - Нет\n";
    cin >> vip;

    if (level >= 20 || vip == 1)
    {
        cout << "Игрок получает бонус.\n";
    }
    else
    {
        cout << "Бонус не предоставляется.\n";
    }
}

int main()
{
    int choice;

    do
    {
        cout << "\n======= GAME BONUS =======\n";
        cout << "1. Проверить бонус\n";
        cout << "0. Выход\n";

        cin >> choice;

        if (choice == 1)
        {
            checkBonus();
        }

    } while (choice != 0);

    return 0;
}