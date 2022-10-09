//  Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine());
if (Number > 999 || Number < 100) Console.Write("Ошибка: Введите другое число");
else
{
int x = Number / 10 % 10;
Console.Write("Вторая цифра числа равна " + x);
}