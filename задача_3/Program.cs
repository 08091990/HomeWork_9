// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return A(m - 1, 1);
    }
    return A(m - 1, A(m, n - 1));
}

int SumNumbers(int n, int m)
{
    if (n == 0) return m + 1;
                if (n != 0 && m == 0) return A(n - 1, 1);
                if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
                return A(n,m);
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine())); 
}

int n = EnterData("Введите первое число: ");
int m = EnterData("Введите последнее число: ");
int result = A(n, m);
int numbers = SumNumbers(n, m);
Console.WriteLine(numbers); 
