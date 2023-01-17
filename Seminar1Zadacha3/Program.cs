//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число");
String stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);
if (value % 2 == 0)
{
    Console.WriteLine($"Число {value} чётное");
}
else 
{
    Console.WriteLine($"Число {value} нечётное");
}
