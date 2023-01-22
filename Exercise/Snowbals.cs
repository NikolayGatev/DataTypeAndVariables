using System.Numerics;

int countBalls = int.Parse(Console.ReadLine());
int theBestSnowballsSnow = 0;
int theBestSnowballTime = 0;
int theBestSnowQuality = 0;
BigInteger snowBallValue = 0;
BigInteger biggestSnowballValue = 0;
for (int i = 0; i < countBalls; i++)
{
    int snowballsSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowQuality = int.Parse(Console.ReadLine());
    snowBallValue = BigInteger.Pow((snowballsSnow / snowballTime), snowQuality);
    if (snowBallValue >= biggestSnowballValue)
    {
        theBestSnowballsSnow = snowballsSnow;
        theBestSnowballTime = snowballTime;
        theBestSnowQuality = snowQuality;
        biggestSnowballValue = BigInteger.Pow((snowballsSnow / snowballTime), snowQuality); 
    }
}
Console.WriteLine($"{theBestSnowballsSnow} : {theBestSnowballTime} = {biggestSnowballValue} ({theBestSnowQuality})");

