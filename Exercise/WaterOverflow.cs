const int volumeWaterTank = 255;
int countPour = int.Parse(Console.ReadLine());
int quantitiesOfWator = 0;
for (int i = 0; i < countPour; i++)
{
    int curentPour = int.Parse(Console.ReadLine());
    if (curentPour <= (volumeWaterTank - quantitiesOfWator))
    {
        quantitiesOfWator += curentPour;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}
Console.WriteLine(quantitiesOfWator);