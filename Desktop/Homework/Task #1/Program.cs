/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number <=900)
{
    Console.WriteLine("Вторая цифра числа: " + (number / 10) % 10);
}
else 
{
    Console.WriteLine("Число не трёхзначное");
}