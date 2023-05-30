// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int m, int n)
{
    if(m>n)
    {
        return 0;
    }
    return m + SumNumbers(m+1, n);
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine())); 
}

int m = EnterData("Введите первое число: ");
int n = EnterData("Введите последнее число: ");
int numbers = SumNumbers(m, n);
Console.WriteLine(numbers); 

