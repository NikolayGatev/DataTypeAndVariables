byte countSymbols = byte.Parse(Console.ReadLine());
string balanse = "";
string newString;
Boolean firstOpenBracket = false;
for (int i = 0; i < countSymbols; i++)
{
    newString = Console.ReadLine();
    if (firstOpenBracket == false)
    {
        if (newString == ")")
        {
            balanse = "UNBALANCED";
            break;
        }
        else if (newString == "(")
        {
            firstOpenBracket = true;
            balanse = "UNBALANCED";
        }
    }
    else if (firstOpenBracket == true && newString == "(")
    {
    break;
    }
    if (firstOpenBracket == true && newString == ")")
    {
        firstOpenBracket = false;
        balanse = "BALANCED";
    }
}
    Console.WriteLine(balanse);
