// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int Alpha = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (Alpha > 0)
{
    sum = sum + Alpha % 10;
    Alpha /= 10;
}
Console.WriteLine(sum);

