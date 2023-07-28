// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10, 100);
        }

    }
    return result;
}

int[,] ChangeLines(int[,] array)
{
    int[] temp = new int[array.GetLength(1)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp[i];

    }
    return array;
}

void PrintArray(int [,] array){
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{ array[i, j] } ");
    }
    System.Console.WriteLine();
}
}

int[,] array = GetArray(5, 6);
PrintArray(array);
array = ChangeLines(array);
System.Console.WriteLine();
PrintArray(array);