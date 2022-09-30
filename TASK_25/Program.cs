/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16   */

// Вариант 1
// Console.WriteLine("Введите число A:  ");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число B:  ");
// int num2 = int.Parse(Console.ReadLine());

// {
//     double result = Math.Pow(num1, num2);
//     Console.Write($"{result} ");
// }

//Вариант 2
Console.WriteLine("Введите число A:  ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B:  ");
int num2 = int.Parse(Console.ReadLine());

ToDegree(num1, num2);

void ToDegree(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine($"{result} ");
}