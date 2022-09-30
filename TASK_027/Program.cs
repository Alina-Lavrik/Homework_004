/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */ 

Console.WriteLine("Введите число N:  ");
int N = int.Parse(Console.ReadLine()!);

 int Sum = 0;
 while (N > 0)
{
   Sum = Sum + N % 10;
   N /= 10;                   // N = N / 10;
}
Console.WriteLine($"Сумма цифр в числе равна {Sum}");



