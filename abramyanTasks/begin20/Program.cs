Console.Write("Введите кооринату x1 первой вершины прямоугольника: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кооринату y1 первой вершины прямоугольника: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кооринату x2 второй вершины прямоугольника: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кооринату y2 второй вершины прямоугольника: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));

System.Console.WriteLine($"Расстояние между данными точками равно:{Math.Round(S,2)}");