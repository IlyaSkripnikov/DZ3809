/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
int Prompt(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int A = Prompt("Введите первое число");
int B = Prompt("Введите второе число");
int step = A;
for (int i = 1; i <= B; i++)
{
    step = step * A;
}
System.Console.WriteLine($"{A} в степени {B} равно: {step} ");
