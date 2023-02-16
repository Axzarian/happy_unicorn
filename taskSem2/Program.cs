int num = new Random().Next(10,100); //
System.Console.WriteLine(num);


int a1 = num / 10;
int a2 = num % 10;

if(a1>a2)
{
    System.Console.WriteLine(a1);
}
else
{
    System.Console.WriteLine(a2);
}