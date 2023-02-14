System.Console.Write("Введите координату 1-ой точки (A): ");
int A = int.Parse(Console.ReadLine());

System.Console.Write("Введите координату 2-ой точки (B): ");
int B = int.Parse(Console.ReadLine());

System.Console.Write("Введите координату 3-ой точки (C): ");
int C = int.Parse(Console.ReadLine());

int Sac = Math.Abs(A - C);
int Sbc = Math.Abs(B - C);

System.Console.WriteLine("Отрезок AC равен: " + Sac);
System.Console.WriteLine("Отрезок BC равен: " + Sbc);

int sumAcBc = Sac + Sbc;

System.Console.WriteLine("Сумма отрезков AC и BC равна:" + sumAcBc);