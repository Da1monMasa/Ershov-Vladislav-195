

#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");

    double a, b, result;

    try
    {
        cout << "введите первое число: ";
        cin >> a;
        cout << "введите второе число: ";
        cin >> b;
        if (b == 0) {
            throw "деление на 0 не предусмотрено\n";
        }
        else throw a, b;
    }
    catch (const char* exception)
    {
        cerr << "Error: " << exception << endl;
    }
    catch (double dbeer)
    {
        cerr << "\nвведено неверное значение" << endl;
    }
    catch (exception& e)
    {
        cout << e.what();
    }
    catch (invalid_argument)
    {
        cerr << "ошибка операции 0" << endl;
    }
    cout << "размер типа данных int = " << sizeof(int) << " bytes" << endl;
    cout << "размер типа данных float = " << sizeof(float) << " bytes" << endl;
    cout << "размер типа данных char = " << sizeof(char) << " bytes" << endl;

    return 0;
}
