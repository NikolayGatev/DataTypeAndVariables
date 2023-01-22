int number = int.Parse(Console.ReadLine());
int sumDigits = 0;
int digit = 0;
while (number > 0)
{
    digit = number % 10;
    sumDigits += digit;
    number /= 10;
}
Console.WriteLine(sumDigits);