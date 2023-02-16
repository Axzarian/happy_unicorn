Console.Write("Введите кооринату x1 первой вершины треуголььника: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кооринату y1 первой вершины треугольника: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кооринату x2 второй вершины треугольника: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кооринату y2 второй вершины трекгольника: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кооринату x3 третьей вершины треугольника: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кооринату y3 третьей вершины треугольника: ");
int y3 = Convert.ToInt32(Console.ReadLine());

double a = Math.Round(Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)),2);
double b = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)),2);
double c = Math.Round(Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)),2);

double p = Math.Round((a + b + c) / 2,2);

double S = Math.Sqrt (p * (p - a) * (p - b) * (p - c));

System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(p);

System.Console.WriteLine($"Площадь данного треугольника равна: {Math.Round(S,2)}");


