System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"a равно: {a}");
System.Console.WriteLine($"b равно: {b}");

int temp = a;
a = b;
b = temp;

System.Console.WriteLine($"Теперь а равно: {a}");
System.Console.WriteLine($"Теперь b равно: {b}");
