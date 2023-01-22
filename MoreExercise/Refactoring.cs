int rerun = int.Parse(Console.ReadLine());
for (int i = 2; i <= rerun; i++)
{
    bool check = true;
    for (int e = 2; e < i; e++)
    {
        if (i % e == 0)
        {
            check = false;
            break;
        }
    }
    if (check)
    Console.WriteLine("{0} -> true", i);
    else
        Console.WriteLine("{0} -> false", i);
}
