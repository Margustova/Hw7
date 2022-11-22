// Семинар 7 двумерные массивы 
// Задайте двумерный массив размером m x n, заполненный случайными целыми числами
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];// выделяем память под массив

    for (int i=0; i< rows; i++) //сперва  проходимся по строкам
        for (int j =0; j < columns; j++) // теперь по столбцам
            array[i,j] = new Random().Next(minValue, maxValue + 1); // создаем массив
        
    return array;   
}
void Show2dArray(int[,] array) //вызов двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++) //GetLength - параметр конкретного габарита
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine(); // чтобы было красивое отображение массива
    }
    Console.WriteLine(); // что бы 2 массива не сливались
}

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minValue: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of maxValue: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
//Задача 1 : Задайте двумерный массив размера m на n. Каждый элемент в массиве находится по формуле Aij = i+j. 
//Выведите полученный элемент на экран.
// метод будет генерировать новый массив, и возвращать на выходе тоже
//на вход будет брать габариты массива

// int[,] CreateNew2dArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];// выделяем память под массив

//     for (int i=0; i< rows; i++) //сперва  проходимся по строкам
//         for (int j =0; j < columns; j++) // теперь по столбцам
//             array[i,j] = i+j;  // создаем массив , где каждый элемент создается по формуле
        
//     return array;
   
// }   
// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateNew2dArray(m, n);
// Show2dArray(myArray);

//Задача2: Задайте двумерный массив. найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты.
// метод преобразующий, возвращать ничего не будем. на вход будем брать сам массив

// void PositiveMassive(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i % 2 == 0 && j % 2 == 0)
//                 {
//                     array[i,j] *= array[i,j];
//                 }
//             }   
        
//         }
        
// }


// PositiveMassive(myArray);
// Show2dArray(myArray);
//Задача3: Задать двумерный массив, найти сумму элементов,находящихся на главной диагонали c индексами (0,0),
// (1,1) и тд (i==j)
// int SummDiagonal2dArray(int[,]array)
// {
//     int sum =0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     // for(int i =0; i < array.Getlength(0) && i < array.Getlength(1); i++ ) -более быстрое и легкое решение
//     //      sum = array[i, i]; 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                 sum = array[i,j]+sum;
//             }
//         }
//     }
//     return sum;
// }
// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minValue: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of maxValue: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// Console.WriteLine(SummDiagonal2dArray(myArray));

//Homework 7
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
// double[,] CreateRandomdouble2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];// выделяем память под массив

//     for (int i=0; i< rows; i++) //сперва  проходимся по строкам
//         for (int j =0; j < columns; j++) // теперь по столбцам
//             array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(); // создаем массив
        
//     return array;   
// }
// void Show2dArray(double[,] array) //вызов двумерного массива
// {
   //for(int i = 0; i < array.GetLength(0); i++) //GetLength - параметр конкретного габарита
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine(); // чтобы было красивое отображение массива
//     }
//     Console.WriteLine(); // что бы 2 массива не сливались
// }
// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minValue: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of maxValue: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandomdouble2dArray(m, n, min, max);
// Show2dArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет

void Double2dArray(int[,]array, int i1, int j1) //запрашиваем массив и индексы у пользователя
{
    if (i1 <=array.GetLength(0) && j1<=array.GetLength(1))
    {
        Console.WriteLine($"Result is {array[i1,j1]} ");
    }
    else Console.WriteLine($"This is mistake");               
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minValue: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.Write("Input a first index: ");
int firstIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second index: ");
int secondIndex = Convert.ToInt32(Console.ReadLine());
Double2dArray(myArray, firstIndex, secondIndex);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// double AverageSumColumns(int columns, int rows)
// {    
//     int aversum = 0;
//     int[] array = new int[columns];

//     for(int j =0; j < columns; j++)
//     {
//         aversum += array[j] / columns;
//         for(int i = 0; i < rows; i++)
//         {
//             while (i < rows)
//         }
      
//     }
//     return aversum;
// }
// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minValue: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of maxValue: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// Console.WriteLine(AverageSumColumns(n));