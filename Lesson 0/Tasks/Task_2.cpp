#include <iostream>
using namespace std;

// Тематика: система бронирования билетов

int tickets = 5;

void showTickets()
{
    cout << "\nСвободных билетов: " << tickets << "\n";
}

void buyTicket()
{
    int count;

    cout << "\nСколько билетов купить: ";
    cin >> count;

    if (count <= tickets)
    {
        tickets -= count;
        cout << "Билеты успешно куплены.\n";
    }
    else
    {
        cout << "Недостаточно билетов.\n";
    }
}

void returnTicket()
{
    int count;

    cout << "\nСколько билетов вернуть: ";
    cin >> count;

    tickets += count;

    cout << "Билеты возвращены.\n";
}

int main()
{
    int choice;

    do
    {
        cout << "\n========== CINEMA ==========\n";
        cout << "1. Свободные билеты\n";
        cout << "2. Купить билеты\n";
        cout << "3. Вернуть билеты\n";
        cout << "0. Выход\n";
        cout << "============================\n";

        cin >> choice;

        switch (choice)
        {
            case 1:
                showTickets();
                break;

            case 2:
                buyTicket();
                break;

            case 3:
                returnTicket();
                break;

            case 0:
                break;

            default:
                cout << "Неизвестная команда.\n";
        }

    } while (choice != 0);

    return 0;
}