int n = int.Parse(Console.ReadLine());
double maxVolume = double.MinValue;
string nameBigestKeg = "";
string nameCurentKeg = "";
double radius = 0;
int height = 0;
double curentVolume = 0;

for (int i = 0; i < n; i++)
{
    nameCurentKeg = Console.ReadLine();
    radius = double.Parse(Console.ReadLine());
    height = int.Parse(Console.ReadLine());
    curentVolume = Math.Pow((double)radius, 2 ) * (double)height * Math.PI;
    if (maxVolume <= curentVolume)
    {
        maxVolume = curentVolume;
        nameBigestKeg = nameCurentKeg;
    }
}
Console.WriteLine(nameBigestKeg);