/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/



void Palindrom(string num)
{
    for (int i = 0; i < num.Length / 2; i++)
    {
        if (num[i] == num[num.Length - i - 1])

            Console.WriteLine("Это число является полиндромом");

        else

            Console.WriteLine("Это число не является полиндромом");
    }
}

Console.WriteLine("Введите пятизначное число: ");

Palindrom(Console.ReadLine()!);
