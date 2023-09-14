// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

int NaturalNumFromMToN(int num1, int num2)
{
	if (num1 == num2) return num1;

	else if (num1 < num2) return num1 + NaturalNumFromMToN(num1 + 1, num2);

	else return num2 + NaturalNumFromMToN(num1, num2 + 1);
}

Console.Write("Введите натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
	Console.WriteLine("Ошибка ввода.");
	return;
}

Console.WriteLine(NaturalNumFromMToN(m, n));