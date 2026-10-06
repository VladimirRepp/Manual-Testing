#include <iostream>
using namespace std;

/*
Описание:
Игрок использует аптечку для восстановления здоровья.

Требования:
1. Максимальное здоровье игрока — 100.
2. Текущее здоровье должно быть от 0 до 100.
3. Аптечка восстанавливает 30 HP.
4. Если здоровье уже равно 100, использовать аптечку нельзя.
5. После использования здоровье не должно превышать 100.

Задание тестировщика:
1. Протестируйте программу.
2. Найдите ошибку.
3. Составьте Bug Report.
4. Укажите:
   - Summary
   - Description
   - Preconditions
   - Steps to Reproduce
   - Test Data
   - Expected Result
   - Actual Result
   - Reproducibility
   - Evidence

Задача студента:
- определить подходящие Test Data;
- обнаружить дефект;
- сравнить Expected Result и Actual Result;
- определить, воспроизводится ли ошибка;
- составить полный Bug Report;
- приложить Evidence.
*/

int main()
{
    int hp;

    cout << "=== Health Kit ===\n";
    cout << "Enter player HP: ";
    cin >> hp;

    if (hp < 0 || hp > 100)
    {
        cout << "Invalid HP.\n";
        return 0;
    }

    cout << "HP before: " << hp << "\n";

    hp += 30;

    cout << "Health kit used.\n";
    cout << "HP after: " << hp << "\n";

    return 0;
}