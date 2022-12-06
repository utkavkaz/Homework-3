// Задача 30: - HARD необязательная 
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц, 
// если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.



int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

int res1 = 0, res2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 0) res1 += 1;
    else res2 += 1;
}

Console.WriteLine();
Console.WriteLine(res1);
Console.WriteLine(res2);
if (res1 > res2) Console.WriteLine("False");
else if (res2 > res1) Console.WriteLine("TRUE");