#include <iostream>
using namespace std;

// Программа для разбора со студентами

int balance = 10000;

void transfer()
{
    int amount;

    cout << "\nВведите сумму перевода: ";
    cin >> amount;

    if (amount < 1)
    {
        cout << "Сумма должна быть больше нуля.\n";
        return;
    }

    if (amount > 10000)
    {
        cout << "Максимальная сумма перевода — 10000.\n";
        return;
    }

    if (amount > balance)
    {
        cout << "Недостаточно денег.\n";
        return;
    }

    balance -= amount;

    cout << "Перевод выполнен.\n";
}

void showBalance()
{
    cout << "\nБаланс: " << balance << "\n";
}

int main()
{
    int choice;

    do
    {
        cout << "\n========= BANK =========\n";
        cout << "1. Перевести деньги\n";
        cout << "2. Баланс\n";
        cout << "0. Выход\n";

        cin >> choice;

        switch (choice)
        {
            case 1:
                transfer();
                break;

            case 2:
                showBalance();
                break;
        }

    } while (choice != 0);

    return 0;
}