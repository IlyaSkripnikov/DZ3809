/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/
int [] mas = new int[8];
Console.Write("[");
for (int i = 0; i < mas.Length; i++)
 {
    mas [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");
int Method (int a)
{
    return mas[a];
}