// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int InputInt(string msg)
{
    System.Console.Write($"{msg}");
    return int.Parse(Console.ReadLine());
}
int[] GenerateArray(int len)
{
  int[] array = new int[len];
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Введите число {i + 1}: ");
    array[i] = int.Parse(Console.ReadLine());
  }
  return array;
}
int PositiveNum(int[] number)
{
  int Positive = 0;
  for (int i = 0; i < number.Length; i++)
  {
    if (number[i] > 0)
    {
      Positive++;
    }
  }
  return Positive;
}
void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}\t");
  }
  System.Console.WriteLine();
}
int num = InputInt("Какое кол-во чисел ввести: ");
int[] array = GenerateArray(num);
PrintArray(array);
int positiveCount = PositiveNum(array);
Console.WriteLine($"Кол-во чисел больше 0: {positiveCount}");
