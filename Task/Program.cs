//Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int [,] GetArray (int row, int column, int min, int max)
// {
//     int [,] resualt = new int [row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             resualt[i, j] = new Random().Next(min,max + 1);
//         }
//     }
//     return resualt;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray (int [,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int t = 0; t < array.GetLength(1); t++)
//             {
//                if (array[i,t]>array[i,j])
//                {
//                 int temp= array[i,j];
//                 array[i,j] = array [i,t];
//                 array [i,t] = temp;
//                } 
//             }
//         }
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int [,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// PrintArray(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.


// int [,] GetArray (int row, int column, int min, int max)
// {
//     int [,] resualt = new int [row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             resualt[i, j] = new Random().Next(min,max + 1);
//         }
//     }
//     return resualt;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int GetRowNumber (int[,]array)
// {
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minsum = minsum + array[0,i];
//     }   
//     for (int i = 1; i < array.GetLength(0); i++)
//     {             
//          int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array [i,j];
//         }
//         if (minsum > sum)
//         {
//             minsum = sum;
//             row = i;
//         }
//     }
//     return row;
// }

// Console.WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] array = GetArray (rows,columns, 0, 10);
// PrintArray (array);
// Console.WriteLine($"Строка с наименьшей суммой -> {GetRowNumber(array)}");


//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.


// int [,] GetArray (int row, int column, int min, int max)
// {
//     int [,] resualt = new int [row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             resualt[i, j] = new Random().Next(min,max + 1);
//         }
//     }
//     return resualt;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetMultiplicationMatrix (int[,] arrayA, int[,] arrayB)
// {
//     int [,] arrayC = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                arrayC[i,j] += arrayA[i,k] * arrayB [k,j];
//             }
//         }
//     }
//     return arrayC;
// }
// Console.WriteLine("Введите количество строк 1 массива: ");
// int rowsA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 1 массива: ");
// int columnsA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк 2 массива: ");
// int rowsB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 2 массива: ");
// int columnsB = Convert.ToInt32(Console.ReadLine());
// if (columnsA != rowsB)
// {
//     Console.WriteLine("Такие матрицы умножать нельзя! ");
//     return;
// }
// int[,] A = GetArray (rowsA, columnsA, 0, 10); 
// int[,] B = GetArray (rowsB, columnsB, 0, 10);

// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);
// Console.WriteLine();
// PrintArray(GetMultiplicationMatrix(A,B));

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.


//  int [,,] GetArray (int [] size,  int min, int max)
// {
//     int [,,] resualt = new int [size[0], size[1], size[2]];
//     for (int i = 0; i < resualt.GetLength(0); i++)
//     {
//         for (int j = 0; j < resualt.GetLength(1); j++)
//         {
//            int k = 0;
//            while (k < resualt.GetLength(2))
//            {
//             int element = new Random().Next(min, max +1);
//             if(FindElement(resualt, element)) continue;
//             resualt[i, j, k] = element;
//             k++;
//            }
//         }
//     }
//     return resualt;
// }

// bool FindElement (int[,,]array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if(array[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            for (int k = 0; k < array.GetLength(2); k++)
//            {
//              Console.Write($"{array[i, j, k]} ){i}, {j}, {k} ");
//            }
//            Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите размер массива через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,]array = GetArray(new int[] {int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])}, 10, 99 );
// PrintArray (array);


// Задача 62. Заполните спирально массив 4 на 4.


// int [,] GetArray(int size)
// {
//     int[,] resualt = new int[size, size];
//     int i = 0;
//     int j = 0;
//     int rowE = size - 1;
//     int columnE = size - 1;
//     int rowS = 0;
//     int columnS = 0;
//     bool left = true;
//     bool top = true;
//     int count = 0;
//     while (count < size * size)
//     {
//        count++;
//        resualt[i,j] = count;
//        if (left && top)
//        {
//         if (j == columnE)
//         {
//             rowS ++;
//             top = true;
//             left = false;
//             i++;
//             continue;
//         }
//         else
//         {
//             j++;
//         }
//        } 
//        if (!left &&top)
//        {
//         if (i == rowE)
//         {
//             columnE--;
//             top = false;
//             left = false;
//             j--;
//             continue;
//         }
//         else
//         {
//             i++;
//             continue;
//         }
//        }
//        if (!left && !top)
//        {
//         if (j == columnS)
//         {
//             rowE--;
//             top = false;
//             left = true;
//             i--;
//             continue;
//         }
//         else
//         {
//            j--;
//            continue; 
//         }    
        
//        }  
//        if (left && !top)
//        {
//         if (i == rowS)
//         {
//          columnS++;
//         top = true;
//         left = true;
//         j++;
//         continue; 
            
//         }
//         else
//         {
//             i--;
//             continue;
//         }
//        }   
//     }
//     return resualt;
// }

//  void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
        
//            {
//              Console.Write($"{array[i, j]} ");
//            }
          
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введит размер матрицы: ");
// int s = Convert.ToInt32(Console.ReadLine());
// int[,]arr = GetArray(s);
// PrintArray (arr);