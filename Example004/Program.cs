// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.5 22.4 2 78] -> 76

double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(-100, 101);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double max = arrayRealNumbers[0];
double min = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (max < arrayRealNumbers[i])
    {
      max = arrayRealNumbers[i];
    }
        if (min > arrayRealNumbers[i])
    {
      min = arrayRealNumbers[i];
    }
  }

  double result = max - min;

  Console.WriteLine($"\nразница между между максимальным ({max}) и минимальным({min}) элементами: {result}");