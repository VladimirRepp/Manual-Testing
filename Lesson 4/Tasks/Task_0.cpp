#include <iostream>
using namespace std;

// Программа для разбора со студентами

void checkDelivery()
{
    int vip;
    double order;

    cout << "\nЯвляется ли клиент VIP?\n";
    cout << "1 - Да\n";
    cout << "0 - Нет\n";
    cout << "Ваш ответ: ";
    cin >> vip;

    cout << "Введите сумму заказа: ";
    cin >> order;

    if (vip == 1 || order >= 5000)
    {
        cout << "Доставка бесплатная.\n";
    }
    else
    {
        cout << "Доставка платная.\n";
    }
}

int main()
{
    int choice;

    do
    {
        cout << "\n======= ONLINE SHOP =======\n";
        cout << "1. Проверить доставку\n";
        cout << "0. Выход\n";

        cin >> choice;

        if (choice == 1)
        {
            checkDelivery();
        }

    } while (choice != 0);

    return 0;
}