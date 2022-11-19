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