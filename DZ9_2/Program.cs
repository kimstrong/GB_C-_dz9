// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




Console.Clear();
Console.WriteLine($"Введите 2 числа для нахождения суммы натуральных элементов в их промежутке: ");
Console.WriteLine($"Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number = number1;

if (number1 > number2) 
{
  number1 = number2; 
  number2 = number;
}

PrintSumm(number1, number2, number=0);

void PrintSumm(int number1, int number2, int summ)
{
  summ = summ + number2;
  if (number2 <= number1)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSumm(number1, number2 - 1, summ);
}


