byte countSymbols = byte.Parse(Console.ReadLine());
string balanse = "";
string newString;
char curentSymbol;
Boolean firstOpenBracket = false;
for (int i = 0; i < countSymbols; i++)
{
    newString = Console.ReadLine();
    if (char.TryParse(newString, out _))
    {
        curentSymbol = char.Parse(newString);
        if (firstOpenBracket == false)
        {
            if (curentSymbol == 41)
            {                
                balanse = "UNBALANCED";
                break;
            }
            else if (curentSymbol == 40)
            {
                firstOpenBracket = true;
                balanse = "UNBALANCED";
            }
        }
        if (firstOpenBracket == true && curentSymbol == 41)
        {
            firstOpenBracket = false;
            balanse = "BALANCED";
        }
    }
}
Console.WriteLine(balanse);
