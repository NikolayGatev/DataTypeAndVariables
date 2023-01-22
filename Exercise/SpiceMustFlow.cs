int startingYield = int.Parse(Console.ReadLine());
int countDays = 0;
int totalAmount = 0;
for (int i = startingYield; startingYield >= 100; startingYield -= 10)
{
    countDays++;
    totalAmount += startingYield - 26;
}
Console.WriteLine(countDays);
if (totalAmount > 0)
    Console.WriteLine(totalAmount - 26);
else
    Console.WriteLine(0);