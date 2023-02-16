System.Console.Write("Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int min = num1;
int max = num1;

if (num1 > num2)
{
    min = num2;
}
else
{
    max = num2;
}

//int minSqr = min * min;

if (Math.Pow(min,2)== max) 
{
    System.Console.WriteLine("Одно число является квадратом другого");
}
else
{
    System.Console.WriteLine("Не является квадратом");
}