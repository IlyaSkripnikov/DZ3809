//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
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
int MinimumSumRow(double[,] matrix)
{
    int row = 0;
    double minSum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            row = 1;
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки = {Math.Round(sum, 2)}");
    }
    return row + 1;
}
int rows = 3;
int colums = 5;
double[,] getArray = GetArray(rows, colums, -10, 10);
System.Console.WriteLine("Изначальный массив: ");
WriteArrayToConsole(getArray);
System.Console.WriteLine($"Строка с минимальной суммой - {MinimumSumRow(getArray)} ");