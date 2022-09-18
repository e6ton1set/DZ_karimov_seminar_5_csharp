// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int FindSumOdd (int size)
{
    size = Math.Abs(size);
    int[] array = new int [size];
    var Random = new Random();
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10000, 10001);
        if (array[i] % 2 != 0)
        {
            sum = sum + array[i];
            Console.WriteLine($"Элементу с идекcом {i} присвоено значение {array[i]}");
        }
    }
    return sum;
}

Console.WriteLine("Input size for your massive: ");
int size = Convert.ToInt32(Console.ReadLine());

int sum = FindSumOdd(size);
Console.WriteLine($"Сумма нечётных элементов в массиве размера {size = Math.Abs(size)} равна {sum}.");

