System.Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());

double y = 4 * (Math.Pow(x-3,6)) - 7 * (Math.Pow(x-3,3)) + 2;
System.Console.WriteLine($"y равен: {y}");
