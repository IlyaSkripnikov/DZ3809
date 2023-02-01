/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/
int[] GenerateArray(int len = 10)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}
int Sum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
       count = count + array[i];
    }
    return count;
}
void PrintArray(int[] array)
{
    foreach (int numbers in array)
    {
        Console.Write($"{numbers}\t");
    }
    Console.WriteLine();
}
int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine($"Сумма элементов: {Sum(array)}");