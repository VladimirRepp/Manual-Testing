#include <iostream>
using namespace std;

// Задание для разбора со студентами

int balance = 2000;
int gamePrice = 1500;

void showBalance()
{
    cout << "\nВаш баланс: " << balance << " руб.\n";
}

void buyGame()
{
    cout << "\nИгра стоит " << gamePrice << " руб.\n";

    if (balance >= gamePrice)
    {
        balance -= gamePrice;
        cout << "Покупка выполнена!\n";
    }
    else
    {
        cout << "Недостаточно средств.\n";
    }
}

void addMoney()
{
    int money;

    cout << "\nВведите сумму пополнения: ";
    cin >> money;

    balance += money;

    cout << "Баланс пополнен.\n";
}

void showGame()
{
    cout << "\nНазвание игры: Cyber Racer\n";
    cout << "Цена: " << gamePrice << " руб.\n";
}

int main()
{
    int choice;

    do
    {
        cout << "\n========== GAME STORE ==========\n";
        cout << "1. Показать баланс\n";
        cout << "2. Купить игру\n";
        cout << "3. Пополнить баланс\n";
        cout << "4. Информация об игре\n";
        cout << "0. Выход\n";
        cout << "================================\n";

        cout << "Выберите действие: ";
        cin >> choice;

        switch (choice)
        {
            case 1:
                showBalance();
                break;

            case 2:
                buyGame();
                break;

            case 3:
                addMoney();
                break;

            case 4:
                showGame();
                break;

            case 0:
                cout << "Выход.\n";
                break;

            default:
                cout << "Неизвестная команда.\n";
        }

    } while (choice != 0);

    return 0;
}