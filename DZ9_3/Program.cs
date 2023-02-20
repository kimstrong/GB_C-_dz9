// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine($"Введите 2 числа для вычисления функции Аккермана: ");
Console.WriteLine($"Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Ack(number1, number2);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int number1, int number2)
{
  if (number1 == 0) return number2 + 1;
  else if (number2 == 0) return Ack(number1 - 1, 1);
  else return Ack(number1 - 1, Ack(number1, number2 - 1));
}

