#include <iostream>
using namespace std;

// Тематика: создание персонажа

void createCharacter()
{
    string name;
    int level;

    cout << "\nВведите имя персонажа: ";
    cin >> name;

    cout << "Введите уровень: ";
    cin >> level;

    if (name.length() < 3)
    {
        cout << "Имя слишком короткое.\n";
        return;
    }

    if (level < 1 || level > 50)
    {
        cout << "Недопустимый уровень.\n";
        return;
    }

    cout << "Персонаж создан!\n";
}

int main()
{
    int choice;

    do
    {
        cout << "\n======= CHARACTER =======\n";
        cout << "1. Создать персонажа\n";
        cout << "0. Выход\n";

        cin >> choice;

        if (choice == 1)
        {
            createCharacter();
        }

    } while (choice != 0);

    return 0;
}