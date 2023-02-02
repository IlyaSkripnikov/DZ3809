//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.//
double[] GenerateArray(int len = 5)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble()*10;
    }
    return array;
}
double Difference (double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    double count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        
    }
    count = max - min;
    return count;
}
void PrintArray(double[] array)
{
     foreach (double numbers in array)
    {
        Console.Write($"{numbers}\t");
    }
    Console.WriteLine();
}
double[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine($"Разница элементов: {Difference(array)}");

