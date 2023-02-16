int num = new Random().Next(100,999);
//int num = 918; 
System.Console.WriteLine(num);

int a1 = num / 100;
int a2 = num % 10;

System.Console.WriteLine(a1 * 10 + a2);