System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(num);

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("Число кратно 7 и 23.");
}
else
{
    System.Console.WriteLine("Число некратно");
}