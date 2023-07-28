// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.



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

void EnterOfElements(int[,] array)
{
    int temp1 = 0;
    int count=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp1 = array[i, j];
                for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int m = 0; m < array.GetLength(1); m++)
                {
                    if (temp1 == array[k,m])
                    {
                    count++;
                    }

                }
            }

            Console.WriteLine($"Элемент {i}, {j} = {array[i,j]} входит в массив {count} раз");
            count = 0;
        }
    }
}

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }

    int[,] array = GetArray(5, 6);
    PrintArray(array);
    Console.WriteLine();
    EnterOfElements(array);
 