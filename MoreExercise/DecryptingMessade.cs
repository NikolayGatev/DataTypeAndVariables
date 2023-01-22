int key = int.Parse(Console.ReadLine());
int rows = int.Parse(Console.ReadLine());
string message = "";
char symbol;
for (int i = 0; i < rows; i++)
{
    symbol = char.Parse(Console.ReadLine());
    message = message + (char)(symbol + key);
}
Console.WriteLine(message);