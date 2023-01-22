double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = Math.Abs(a - b);
Console.WriteLine(c < 0.000001);