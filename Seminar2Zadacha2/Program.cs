/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
if (b.Length > 2)
{
    Console.WriteLine("Третья цифра: " + b[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
