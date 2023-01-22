var newInput = Console.ReadLine();
string type = "";
while (newInput != "END")
{
    if (Int32.TryParse(newInput, out _))
    {
        type = "integer";
    }
    else if (double.TryParse(newInput, out _))
    {
        type = "floating point";
    }
    else if (bool.TryParse(newInput, out _))
    {
        type = "boolean";
    }
    else if (char.TryParse(newInput, out _))
    {
        type = "character";
    }
    else
    {
        type = "string";
    }
    Console.WriteLine($"{newInput} is {type} type");
    newInput = Console.ReadLine();
}