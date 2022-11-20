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

void PositiveMassive(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    array[i,j] *= array[i,j];
                }
            }   
        
        }
}

PositiveMassive(myArray);
Show2dArray(myArray);
//Задача3: Задать двумерный массив, найти сумму элементов,находящихся на главной диагонали c индексами (0,0),
// (1,1) и тд (i==j)
