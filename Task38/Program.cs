// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] arr = new double[4];

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = (new Random().Next(100, 10000))*0.01;
    Console.Write($"{arr[i]}, ");
}

Console.WriteLine("\b\b]");

double min = arr[0];
double max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min) min = arr[i];
    if (arr[i] > max) max = arr[i];
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max-min}.");
