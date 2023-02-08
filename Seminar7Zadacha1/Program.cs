//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.
int InputInt(string msg)
{
    System.Console.Write($"{msg}");
    return int.Parse(Console.ReadLine());
}
double[,] CreateMatrix()
{
    double[,] matrix = new double[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble()*10;
        }
    }
    return matrix;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
double[,] matrix = CreateMatrix();
PrintArray(matrix);
