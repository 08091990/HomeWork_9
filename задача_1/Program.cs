// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string MakeNumbers(int num)
{
    if(num==1)
    {
        return "1";
    }
    return num+ ", " + MakeNumbers(num-1);
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine())); 
}

int n = EnterData("Введите число");
string numbers = MakeNumbers(n);
Console.WriteLine(numbers); 