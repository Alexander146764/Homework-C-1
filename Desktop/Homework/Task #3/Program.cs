/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 1 && number <= 7)
{
    if(number >=6)
    {
        Console.WriteLine("ДА, этот день выходной");
    }
    else
    {
        Console.WriteLine("Нет, этот день рабочий");
    }
}
else 
{
	Console.WriteLine("Число не соответствует задаче");
}
