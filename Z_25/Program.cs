// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Result(int num1, int num2)
{
    int i = 1;
    int res = 1;

    while (res <= num2)
    {
        i = i * num1;
        res++;
    }
    return i;
}
try
{
    Console.Write("Введите число А: ");
    int x = Convert.ToInt32(System.Console.ReadLine());

    Console.Write("Введите число B: ");
    int y = Convert.ToInt32(System.Console.ReadLine());

    if (y < 1) Console.WriteLine("Введите натуральное число B");
    else Console.WriteLine($"Число {x} в степени {y} равно: " + (Result(x, y)));
}
catch
{
    Console.Write("Вводите только целые числа");
}