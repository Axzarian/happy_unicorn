System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    System.Console.WriteLine("Первое число кратно второму");
}
else
{
    System.Console.WriteLine("Первое число некратно второму. Остаток: " + (num1 % num2));
}