
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int res = 0;
for (int num2 = 1; num > 0; num2++)
{
    res = res + num % 10;
    num = num / 10;
}

Console.WriteLine($"Сумма цифр в числе составит {res}");
