// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int num1, int num2)
{
	if (num1 == 0)
	{
		return num2 + 1;
	}
	else if (num1 > 0 && num2 == 0)
	{
		return AckermanFunction(num1 - 1, 1);
	}
	else
	{
		return AckermanFunction(num1 - 1, AckermanFunction(num1, num2 - 1));
	}
}

Console.Write("Введите натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
	Console.Write("Ошибка ввода.");
	return;
}

Console.WriteLine(AckermanFunction(m, n));
