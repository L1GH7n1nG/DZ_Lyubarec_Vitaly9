// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintNumberFromNTo1(int num)
{
	if (num < 1) return;
	else
	{
		if (num > 1)
		{
			Console.Write($"{num}, ");
			PrintNumberFromNTo1(num - 1);
		}
		else Console.Write($"{num} ");
	}
}


Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
	Console.WriteLine("Ошибка ввода.");
	return;
}
PrintNumberFromNTo1(n);