
//Aufgabe 1

Console.WriteLine("Kleinere Zahl");

Console.WriteLine("geben Sie die erste Zahl ein");
string zahl1_str = Console.ReadLine();
double zahl1 = Convert.ToDouble(zahl1_str);

Console.WriteLine("geben Sie die zweite Zahl ein");
string zahl2_str = Console.ReadLine();
double zahl2 = Convert.ToDouble(zahl2_str);

if (zahl1 == zahl2)
{
    Console.WriteLine("Die kleinere Zahl ist: Gleicher Wert");
}
else
{
    if (zahl1 < zahl2)
    {
        Console.WriteLine($"Die kleinere Zahl ist: {zahl1}");
    }
    else
    {
        Console.WriteLine($"Die kleinere Zahl ist: {zahl2}");

    }
}


//Aufgabe 2

Console.WriteLine("Herzinfarkt Rechner");
Console.WriteLine("Sind sie Übergewichtig?");
bool Fett= Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Sind Sie gestresst?");
bool stress= Convert.ToBoolean(Console.ReadLine());
if (Fett == true)
{
    if (stress == true) 
    {
        Console.WriteLine("Ihr Risiko für einen Herinfarkt liegt bei: 62%");
    }
    else
    {
        Console.WriteLine("Ihr Risiko für einen Herinfarkt liegt bei: 18%");
    }
}
else
{
    if (stress == true)
    {
        Console.WriteLine("Ihr Risiko für einen Herinfarkt liegt bei: 15%");
    }
    else
    {
        Console.WriteLine("Ihr Risiko für einen Herinfarkt liegt bei: 5%");
    }
}

//Aufgabe 3


Console.WriteLine("-Rechner-");
Console.WriteLine("");

// Zahl1
Console.WriteLine("Geben sie die zahl1 ein");
double zahl1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

//Zahl2
Console.WriteLine("Geben sie die zahl2 ein");
double zahl2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");


Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
Console.WriteLine("");
//Menü
Console.WriteLine("Menü");
Console.WriteLine("1.Addition");
Console.WriteLine("2.Subtraktion");
Console.WriteLine("3.Multiplikation");
Console.WriteLine("4.Division");
Console.WriteLine("5.Potenz");

//Operator
Console.WriteLine("Wählen sie ein operator");
string operat = Console.ReadLine();


//Mehrfachauswahl

switch (operat)
{
    case "1":
        Console.WriteLine($"Ihr Ergebnis ist: {zahl1 + zahl2}");
        break;
    case "2":
        Console.WriteLine($"Ihr Ergebnis ist: {zahl1 - zahl2}");
        break;
    case "3":
        Console.WriteLine($"Ihr Ergebnis ist: {zahl1 * zahl2}");
        break;
    case "4":
        Console.WriteLine($"Ihr Ergebnis ist: {zahl1 / zahl2}");
        break;
    case "5":
        Console.WriteLine($"Ihr Ergebnis ist: {Math.Pow(zahl1, zahl2)}");
        break;
}



