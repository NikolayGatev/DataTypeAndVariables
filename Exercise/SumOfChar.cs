int numberOfLines = int.Parse(Console.ReadLine());
int sumCharSymbols = 0;
for (int i = 0; i < numberOfLines; i++)
{
    char newChar = char.Parse(Console.ReadLine());
    sumCharSymbols += newChar;
}
Console.WriteLine($"The sum equals: {sumCharSymbols}");