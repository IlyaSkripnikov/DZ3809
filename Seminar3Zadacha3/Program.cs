/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int Prompt(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int N = Prompt("Введите число");
for (int i = 1; i <= N; i++)
{
    double a = Math.Pow(i, 3);
    System.Console.WriteLine($"Куб числа {i} равен {a} ");
}
