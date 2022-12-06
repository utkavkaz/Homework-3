// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int num)
{
    int num1 = 0;
    int sum = 0;
    while (num > 0)
    {
        num1 = num % 10;
        sum = sum + num1;
        num = num / 10;
    }
    return sum;
}
try
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 0) Console.WriteLine("Введите целое положительное число");
    else Console.WriteLine("Сумма цифр в числе равна: " + Sum(num));
}
catch
{
    Console.WriteLine("Введите целое положительное число");
}