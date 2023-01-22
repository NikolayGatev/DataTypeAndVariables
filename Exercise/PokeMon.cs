int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int newN = n;
int countPoke = 0;
while (newN >= m)
{
    countPoke++;
    newN -= m;
    if ((decimal)newN == ((decimal)n * 0.5m) && y != 0)
        {
            newN /= y;
        }
}
Console.WriteLine(newN);
Console.WriteLine(countPoke);