Console.Write("Введите кооринату x1 первой вершины прямоугольника: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кооринату y1 первой вершины прямоугольника: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кооринату x2 второй вершины прямоугольника: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кооринату y2 второй вершины прямоугольника: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int a = Math.Abs(y2 - y1);
int b = Math.Abs(x2 - x1);

int P = 2 * (a + b);
int S = a * b;

System.Console.WriteLine($"Периметр данного прямоугольника равен:{P}");
System.Console.WriteLine($"Площадь данного прямоугольника равна:{S}");