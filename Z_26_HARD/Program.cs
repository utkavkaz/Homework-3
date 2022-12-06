// Задача 26 - HARD необязательная 
// Напишите программу, которая принимает на вход целое 
// или дробное число и выдаёт количество цифр в числе.

// 452 -> 3
// 82 -> 2
// 9,012 ->4

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num > 0)
{
    int count = 0;
    while (num % 10 > 0)
    {
        num = num * 10;
        count++;
    }

    int count1 = -1;
    while (num >= 1)
    {
        num = num / 10;
        count1++;
    }
    Console.WriteLine(count1);
}
else Console.WriteLine("Вводите положительное число!");