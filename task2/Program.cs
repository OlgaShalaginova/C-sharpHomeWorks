Console.WriteLine("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine());
if (Number1 > Number2)
{
    Console.WriteLine("Максимальное равно " + Number1);
}
if (Number2 > Number1)
{
    Console.WriteLine("Максимальное равно " + Number2);
}
if (Number1 == Number2)
{
    Console.WriteLine ("Числа равны");
}

