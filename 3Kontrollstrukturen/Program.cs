

Console.WriteLine("Die kleinere Zahl\n");
Console.WriteLine("Geben Sie die erste Zahl ein:");
    
double zahl1 = double.Parse(Console.ReadLine());
Console.WriteLine("Geben Sie die zweite Zahl ein:");
double zahl2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("------------------");

if (zahl1 < zahl2)
{
    Console.WriteLine($"Die kleinere Zahl ist: {zahl1}");

}
else
{
    //nein
    if (zahl2 < zahl1) 
    {
        Console.WriteLine($"Die kleinere Zahl ist: {zahl2}");
    }
    else
    {
        Console.WriteLine("Gleicher Wert");
    }

}
