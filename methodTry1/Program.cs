
int Mult(int num1, int num2, int num3)
{
    int result = (num1 * num1) + (num2 * num2) + (num3 * num3);
    return result;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int sum = Mult(a, b, c);
System.Console.WriteLine(sum);
