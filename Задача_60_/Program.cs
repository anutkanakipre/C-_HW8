// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите глубину массива: ");
int deeps = Convert.ToInt32(Console.ReadLine());

int[,,] Fill2DArray(int rows, int columns, int deeps)
{
    int[,,] array = new int[rows, columns, deeps];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                while (array[i, j, z] == 0)
                {
                    int newnumber = new Random().Next(10, 99);
                    if (SearchArray(array, newnumber) == 0) array[i, j, z] = newnumber;
                }
            }
        }
    }
    return array;
}
void Print2DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[i, j, z]}{(i, j, z)} ");
            }
            Console.WriteLine();
        }
    }
}
int SearchArray(int[,,] array, int findme)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                if (findme == array[i, j, z])
                    return 1;
            }
        }
    }
    return 0;
}

int[,,] array = Fill2DArray(rows, columns, deeps);
Print2DArray(array);
Console.WriteLine();