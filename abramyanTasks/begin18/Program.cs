/*Даны три точки A,B,C на числовой прямой. Точка С расположена между точками
A и B. Найти произведение длин отрезков AC и BC.
Не знаю как задать диапозон для точки C. Виже четыре варианта, два соответствующих
задаче и два не выполняющих ее требований. Так же необходимо указать что значения
точек на прямо не могут быть одинаковыми.
Думаю смогу сделать с кучей if.
*/




System.Console.Write("Введите координату 1-ой точки (A): ");
int A = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите координату 2-ой точки (B): ");
int B = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите координату 3-ой точки (C).\nОна должна быть между точками A и B: ");
int C = int.Parse(Console.ReadLine()!);

if (C > A && C > B)
{
    System.Console.WriteLine("Точка C не между A и B");
    System.Console.WriteLine("Введите новое значение C: ");
}

if (C < A && C < B)
{
    System.Console.WriteLine("Точка C не между A и B");
    System.Console.WriteLine("Введите новое значение C: ");
}

int Sac = Math.Abs(A - C);
int Sbc = Math.Abs(B - C);

System.Console.WriteLine("Длина отрезка AC равна: " + Sac);
System.Console.WriteLine("Длина отрезка BC равна: " + Sbc);

int multResult = Sac * Sbc;
System.Console.WriteLine("Произведение отрезков равно: " + multResult);