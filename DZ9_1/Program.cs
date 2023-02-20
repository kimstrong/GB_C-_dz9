// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine($"Введите число для вывода всех натуральных чисел до 1: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count=2;
Recursion(numberN,count);
Console.Write(1);
void Recursion(int numberN, int count)
{
    if (count > numberN) return ;
    Recursion(numberN, count + 1);
     Console.Write(count + ", ");
}
