Console.Write ("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine());
Console.Write ("Введите третье число: ");
int Number3 = int.Parse(Console.ReadLine());
Console.Write ("Максимальное число равно ");
if (Number1 > Number2 & Number1 > Number3)
{
    Console.WriteLine(Number1);
}
if (Number2 > Number1 & Number2 > Number3)
{
    Console.WriteLine(Number2);
}
if (Number3 > Number1 & Number3 > Number2)
{
    Console.WriteLine(Number3);
}
