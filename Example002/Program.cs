//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int GetArrayRandomNumbers(int size)
{
    size = Math.Abs(size);
    int[] array = new int[size];
    var random = new Random();
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);

        if (array[i] % 2 == 0)
        {
            sum = sum + 1;
            Console.WriteLine($"{array[i]}");
        }
    }
    return sum;
}

int size = 0;
Console.WriteLine("Введите размер массива: ");
size = Convert.ToInt32(Console.ReadLine());

int sum = GetArrayRandomNumbers(size);
Console.Write($"Количество случайных чётных трёхзначных чисел в массиве размера {size = Math.Abs(size)} равно {sum}");
