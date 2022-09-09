// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void SumBetween(int m, int n, int sum = 0)
{
    if (m > n)
    {
        Console.WriteLine($" \nСумма между m и n: {sum}");
        return;
    }
    sum = sum + (m++);
    SumBetween(m, n, sum);
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
int temp = m;

if (n == m)
{
    Console.WriteLine("0");
    return;
}
if (m > n)
{
    m = n;
    n = temp;
}
SumBetween(m, n);