#include <iostream>
using namespace std;

// Тематика: здоровье персонажа

int health = 100;

void damage()
{
    int value;

    cout << "\nВведите урон: ";
    cin >> value;

    if (value <= 0)
    {
        cout << "Урон должен быть положительным.\n";
        return;
    }

    health -= value;

    if (health < 0)
    {
        health = 0;
    }

    cout << "Урон нанесен.\n";
}

void heal()
{
    int value;

    cout << "\nВведите лечение: ";
    cin >> value;

    if (value <= 0)
    {
        cout << "Лечение должно быть положительным.\n";
        return;
    }

    health += value;

    if (health > 100)
    {
        health = 100;
    }

    cout << "Персонаж вылечен.\n";
}

int main()
{
    int choice;

    do
    {
        cout << "\n========= PLAYER =========\n";
        cout << "1. Получить урон\n";
        cout << "2. Вылечиться\n";
        cout << "3. Показать здоровье\n";
        cout << "0. Выход\n";

        cin >> choice;

        switch (choice)
        {
            case 1:
                damage();
                break;

            case 2:
                heal();
                break;

            case 3:
                cout << "HP: " << health << "\n";
                break;
        }

    } while (choice != 0);

    return 0;
}