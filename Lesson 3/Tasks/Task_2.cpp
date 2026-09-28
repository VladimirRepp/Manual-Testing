#include <iostream>
using namespace std;

// Тематика: количество товаров в заказе

void checkQuantity()
{
    int quantity;

    cout << "Введите количество товаров: ";
    cin >> quantity;

    if (quantity >= 1 && quantity <= 20)
    {
        cout << "Количество допустимо.\n";
    }
    else
    {
        cout << "Количество недопустимо.\n";
    }
}

int main()
{
    int choice;

    do
    {
        cout << "\n========= SHOP =========\n";
        cout << "1. Проверить количество\n";
        cout << "0. Выход\n";

        cin >> choice;

        if (choice == 1)
        {
            checkQuantity();
        }

    } while (choice != 0);

    return 0;
}