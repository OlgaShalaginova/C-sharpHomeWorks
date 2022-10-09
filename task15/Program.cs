// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите номер дня недели: ");
int Number = int.Parse(Console.ReadLine());
if (Number == 6 || Number == 7) Console.WriteLine("да");
else if (Number >= 1 && Number <= 5) Console.WriteLine("нет");
else Console.WriteLine("Ошибка: Введите другой номер");