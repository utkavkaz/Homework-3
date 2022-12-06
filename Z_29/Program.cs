// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры 
// и выводит массив на экран.

void FillArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Array[i] = num;
    }
}

void PrintArray(int[] Array)
{
    Console.Write("Вывод массива на экран: ");
    for (int i = 0; i < Array.Length; i++) Console.Write($"{Array[i]} ");
}

try
{
    int[] myArray = new int[8];

    FillArray(myArray);
    Console.WriteLine();
    PrintArray(myArray);
}
catch
{
    Console.WriteLine("Вводите только целые числа");
}



//int[] myArray = new int[8];

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"Введите элемент массива под индексом {i}: ");
//     int num  = Convert.ToInt32(Console.ReadLine());
//     myArray[i] = num;
// }
// Console.WriteLine("Вывод массива на экран:");
// for (int i = 0; i < myArray.Length; i++) Console.WriteLine(myArray[i]);