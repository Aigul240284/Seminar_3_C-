// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int num = GetNumberFromUser("Введите целое положительное пятизначное число: ", "Ошибка ввода!");
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
int a1 = num % 100;
int a2 = num / 1000;
int b2 = a2 % 10;
int b1 = a1 / 10;
int c1 = num % 10;
int c2 = num / 10000;

if (num > 99999 || num < 10000 ) Console.Write("Ошибка ввода!");
else
{
    if (b1 == b2 && c1 == c2)
        Console.Write($"{num} -> да");
    else Console.Write($"{num} -> нет");
}


