System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("a равно:" + a);
System.Console.WriteLine("b равно:" + b);
System.Console.WriteLine("c равно:" + c);

int temp = a;
a = c;
c = b;
b = temp;
System.Console.WriteLine("=============");
System.Console.WriteLine("a равно:" + a);
System.Console.WriteLine("b равно:" + b);
System.Console.WriteLine("c равно:" + c);