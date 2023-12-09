

int[,] GetArray(int s, int c)
{
    int[,] array = new int[s, c];
    Random rand = new Random();
    for (int i = 0; i < s; i++)
    {
        for (int j = 0; j < c; j++)
        {
            array[i, j] = rand.Next(1, 10);

        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// // void Find(int[,] arr)
// // {
// //     Console.Write("Введите строку: ");

// //     Console.Write("Введите столбец: ");
// //     int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

// //     if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// //     {
// //         Console.WriteLine("Элемент не существует  ");
// //     }
// //     else
// //     {
// //         Console.WriteLine($"Значение элемента массива = {arr[pos1, pos2]}");
// //     }
// // }

// // Задача 2: Задайте двумерный массив. Напишите
// // программу, которая поменяет местами первую и
// // последнюю строку массива.


// // void Change(int[,] arr)
// // {
// //     for (int i = 0; i < arr.GetLength(0); i++)
// //     {
// //         int tamp = arr[arr.GetLength(0) - 1, i];
// //         arr[arr.GetLength(0) - 1, i] = arr[0, i];
// //         arr[0, i] = tamp;
// //     }
// //     for (int i = 0; i < arr.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < arr.GetLength(1); j++)
// //         {
// //             Console.Write(arr[i, j] + " ");
// //         }
// //         Console.WriteLine();
// //     }

// // } 




int[,] array = GetArray(3, 3);
PrintArray(array);
// // Find(array);
// // Change(array);





// // Задача 3: Задайте прямоугольный двумерный массив.
// // Напишите программу, которая будет находить строку с
// // наименьшей суммой элементов.


int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}


