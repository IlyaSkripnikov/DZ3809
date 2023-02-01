/*Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.*/
int InputInt(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int k = 0;
int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int numbers in array)
    {
        Console.Write("{0} ", numbers);
        if (numbers % 2 == 0)
            {
                k++;
            }
    }
}
int sizeOfArray = InputInt("Введите размер массива");
int[] array = GenerateArray(sizeOfArray);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел {k}");