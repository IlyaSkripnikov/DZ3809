/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    string inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int numIn = InputInt("Введите число: ");
if (numIn / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    while (numIn > 1000)
    {
        numIn = numIn / 10;
        
    }
    Console.WriteLine($"Третья цифра: {numIn % 10}");
}
