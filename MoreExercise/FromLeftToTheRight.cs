using System.Numerics;

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    BigInteger numberLeft = 0;
    BigInteger numberRight = 0;
    string twoNumbers = Console.ReadLine();
    var result = twoNumbers.Split(' ');
    numberLeft = BigInteger.Parse(result[0]);
    numberRight = BigInteger.Parse(result[1]);
    int sumNumberLeft = 0;
    int sumNumberRight = 0;
    if (numberLeft > numberRight)
    {
        while (BigInteger.Abs(numberLeft) > 0)
        {
            sumNumberLeft += Math.Abs((int)(numberLeft % 10));
            numberLeft /= 10;
        }
        Console.WriteLine(sumNumberLeft);
    }
    else if (numberRight == 0 && numberRight == 0)
    {
        Console.WriteLine(0);
    }
    else
    {
        while (BigInteger.Abs(numberRight) > 0)
        {
            sumNumberRight += Math.Abs((int)(numberRight % 10));
            numberRight /= 10;
        }

        Console.WriteLine(sumNumberRight);

    }
}
