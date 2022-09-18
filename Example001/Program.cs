﻿// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] array = { -3, 5, 6, 7, -5};

int[] GetMulti(int[] array)
{
    int size = array.Length;
    int sizeNew = size / 2;

    if (size % 2 == 0)
    {
        int[] result = new int[sizeNew];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[size - 1 - i];
        }
        return result;
    }
    else
    {
        int[] result = new int[sizeNew + 1];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[size - 1 - i];
        }
        result[sizeNew] = array[size / 2];
        return result;
    }

}
int[] newArray = GetMulti(array);
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write($"{newArray[i]} ");
}
