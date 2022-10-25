/*Дополнительно.
Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11
*/

bool Simple = true;
Console.WriteLine("Введите число, до которого нужно узнать все простые числа : ");
int num = Convert.ToInt32(Console.ReadLine());
for (int count = 2; count <= num; count++)
{
    for (int i = 2; i <= (count / 2) ; i++)
    {
        if (count % i != 0) Simple = true;
        else { Simple = false; break; }
    }
    if (Simple == true) Console.WriteLine(count);
}