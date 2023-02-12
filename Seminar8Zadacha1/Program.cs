//Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}
void WriteArrayToConsole(double[,] doubleArray)
{
   for (int i = 0; i < doubleArray.GetLength(0); i++)
   {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"{doubleArray[i, j]}\t");
        }
        Console.WriteLine();
   } 
}
double[,] SortRows(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = matrix.GetLength(1) - 1; j > i; j--)
                if(matrix[rows, j] > matrix[rows, j - 1])
                {
                    double tmp = matrix[rows, j];
                    matrix[rows, j] = matrix[rows, j - 1];
                    matrix[rows, j - 1] = tmp;
                }
    return matrix;
}
int rows = 3;
int colums = 5;
double[,] getArray = GetArray(rows, colums, -10, 10);
System.Console.WriteLine("Изначальный массив: ");
WriteArrayToConsole(getArray);
System.Console.WriteLine("Сортированный массив: ");
WriteArrayToConsole(SortRows(getArray));