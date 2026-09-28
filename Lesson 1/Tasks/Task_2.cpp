#include <iostream>
using namespace std;

// Тематика: оформление заказа

void createOrder()
{
    int productCount;
    double total;

    cout << "\nКоличество товаров: ";
    cin >> productCount;

    cout << "Сумма заказа: ";
    cin >> total;

    if (productCount <= 0)
    {
        cout << "Количество товаров некорректно.\n";
        return;
    }

    if (total <= 0)
    {
        cout << "Сумма заказа некорректна.\n";
        return;
    }

    cout << "Заказ создан!\n";
}

int main()
{
    int choice;

    do
    {
        cout << "\n======= ONLINE SHOP =======\n";
        cout << "1. Создать заказ\n";
        cout << "0. Выход\n";

        cin >> choice;

        if (choice == 1)
        {
            createOrder();
        }

    } while (choice != 0);

    return 0;
}