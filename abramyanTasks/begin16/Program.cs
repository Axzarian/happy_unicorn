System.Console.Write("Введите координату первой точки: ");
int x1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите координату второй точки: ");
int x2 = int.Parse(Console.ReadLine());

int S = Math.Abs(x1 - x2);
System.Console.WriteLine("Расстояние между точками: " + S);