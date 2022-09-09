// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int ReadInputNumber(string number)
{
    Console.WriteLine(number);
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

int m = ReadInputNumber("Введите число m");
int n = ReadInputNumber("Введите число n");
Console.Write($"\n A(m,n) = {Akkerman(m, n)}");