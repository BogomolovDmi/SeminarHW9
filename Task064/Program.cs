// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


void PrintNaturalNumbers(int m, int n)
{
    if (m == n) Console.Write($"{n} ");
    else
    {
        Console.Write($"{m} ");
        PrintNaturalNumbers(m + 1, n);

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
PrintNaturalNumbers(m, n);