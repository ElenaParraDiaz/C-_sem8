/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*class Program
{
    static void SortRows(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            int[] rowArray = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                rowArray[j] = matrix[i, j];
            }
            Array.Sort(rowArray, (x, y) => y.CompareTo(x));
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rowArray[j];
            }
        }
    }
    static void Main()
    {
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of cols: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
        int[,] matrix = new int[rows, cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(-10, 10);
            }
        }
        Console.WriteLine("Source array:");
        PrintMatrix(matrix);
        SortRows(matrix);
        Console.WriteLine("New array:");
        PrintMatrix(matrix);
        Console.WriteLine();
    }
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*int[,] CreateArray(int row, int colom)
{
    int[,] array=new int [row, colom];
    for( int i=0; i<row; i++)
        for (int j=0; j < colom; j++)
            array[i,j] = new Random().Next(-5,10);
    return array;
}
void ShowArray (int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " " );
        Console.WriteLine();
    }
}
void ShowNewArray (int[] newarray) 
{
    for(int i=0; i < newarray.Length; i++)
    {
        Console.Write(newarray[i] + "," );
    }
}
int[] RowsSum(int[,] array, int row, int colum) 
{
    int[] newarray  = new int [row];
    for (int i=0; i<row; i++)
    {
        int sumrow = 0; 
        for (int j=0; j < colum; j++)
        {
        sumrow += array[i,j];
        newarray[i] = sumrow;
        }
    }
    return newarray;
}
int FindIndex (int[] newarray) 
{
    int min = newarray[0];
    int index = 0;
    for (int i = 1; i < newarray.Length; i++)
    {
        if (newarray[i] < min)
        {
            min = newarray[i];
            index = i;
        }
    }
    return (index +1);
}
Console.Write("Input a rows of array" + " ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a colums of array" + " ");
int colum = Convert.ToInt32(Console.ReadLine());
int[,] myarray = CreateArray(row, colum);
ShowArray(myarray);
int [] newarray = RowsSum(myarray, row, colum);
Console.WriteLine("Amount in row");
ShowNewArray(newarray);
Console.WriteLine();
Console.Write($"The number of the row in the array with the minimum sum of elements {FindIndex(newarray)}");
*/
/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*int[,] CreateArray (int row, int colum)
{
    int [,] array = new int[row, colum];
    for (int i=0; i<row; i++)
        for (int j=0; j<colum; j++)
            array[i,j] = new Random().Next(0,10);
    return array;
}
void ShowArray (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
bool Check (int colum1, int row2)
{
    if ( colum1==row2) 
        return true;
    else return false;
}
int[,] MultiArray(int[,] firstarray , int [,] secondarray, int row1, int colum1, int row2, int colum2)
{
    int [,] resultarray = new int[row1, colum2];
        for (int i=0; i<row1; i++)
            for (int j=0; j<colum2; j++)
            {
                int sum = 0;
                for (int k=0; k<colum1; k++)
                    sum += firstarray[i,k]*secondarray[k,j];
            resultarray[i,j] = sum;
            }
    return resultarray; 
}

Console.Write("Input a rows of first array ->" + " ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a colums of first array ->" + " ");
int colum1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a rows of second array ->" + " ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a colums of second array ->" + " ");
int colum2 = Convert.ToInt32(Console.ReadLine());
int[,] firstarray = CreateArray(row1, colum1);
int[,] secondarray = CreateArray(row2, colum2);
ShowArray(firstarray);
Console.WriteLine();
ShowArray(secondarray);
bool temp = Check(colum1,row2);
if (temp==true)
{
    int[,] resultarray = MultiArray(firstarray, secondarray, row1, colum1, row2, colum2);
    Console.WriteLine("Result");
    ShowArray(resultarray);
}
else Console.WriteLine("Error");
*/
/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*int[, ,] CreateArray(int row, int colum, int h)
{
    int[, ,] array = new int[row,colum,h];
    int temp  = 16;
    for (int i=0, m=0; i<row; i++, m++)
        for (int j=0; j<colum; j++)
            for (int k=0; k<h; k++)
            {
                array[i,j,k] = temp;
                temp = array[i,j,k]+3;
            }
    return array;
}
void ShowArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            Console.WriteLine();
        }
}

Console.Write("Input a rows of array ->" + " ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a colums of array ->" + " ");
int colum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a h of array ->" + " ");
int h = Convert.ToInt32(Console.ReadLine()); 
int[,,] myarray = CreateArray(row,colum,h); 
ShowArray(myarray);
*/
/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] CreateArray(int row =4, int colum=4)
{
    int[,] array = new int[row, colum];
    int value = 1;              
    int minRow = 0;
    int maxRow = 3;
    int minCol = 0;
    int maxCol = 3;
    while (value <= 16)
    {
        for (int i = minCol; i <= maxCol; i++) 
        {
            array[minRow, i] = value;
            value++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = value;
            value++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--) 
        {
            array[maxRow, i] = value;
            value++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            array[i, minCol] = value;
            value++;
        }
        minCol++;
    }
    return array;
}
void ShowArray (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            if (array[i,j]<10) Console.Write($"0{array[i,j]} ");
            else Console.Write(array[i,j] + " ");
        }
        
        Console.WriteLine();
    }
}
int [,] myarray = CreateArray(4,4);
ShowArray(myarray);