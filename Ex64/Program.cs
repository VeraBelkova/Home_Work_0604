// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int N =int.Parse(Console.ReadLine());

int count = N;

int PrintNumber()
{
  if(count<1)
  {
    return count;
  }
 
  Console.Write(count+" ");

  count = count - 1;

  return (PrintNumber());
}

PrintNumber();