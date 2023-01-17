// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите целое число");
String stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);
Console.WriteLine("Введите второе целое число");
String stringValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(stringValue1);
if (value > value1)
    {
    Console.WriteLine($"Максимальное число {value}");
    Console.WriteLine($"Минимальное число {value1}");
    }
else 
    {
    Console.WriteLine($"Минимальное число {value}");
    Console.WriteLine($"Максимальное число {value1}");
    }