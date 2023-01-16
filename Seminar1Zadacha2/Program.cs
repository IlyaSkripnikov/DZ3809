//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int max = 0;
Console.WriteLine("Введите целое число");
String stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);
Console.WriteLine("Введите второе целое число");
String stringValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(stringValue1);
Console.WriteLine("Введите третье целое число");
String stringValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(stringValue2);
if (value > max)
    {
    max = value;
    }
if (value1 > max)
    {
    max = value1;
    }
if (value2 > max)
    {
    max = value2;
    }
Console.WriteLine($"max = {+ max}");
