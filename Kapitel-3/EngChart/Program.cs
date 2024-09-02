// Program som simulerar kända Engineering Flowchart
Console.Clear();
Console.WriteLine("välkommen til ingengörens flödesschema");

// Visa en ASCI art
Console.WriteLine($"""

What do we think of shit?
TOTTENHAM
What do we think of Tottenham
Shit
Thank you
that`s alrigth
We hate TOTTENHAM
We hate TOTTENHAM
We hate TOTTENHAM
We hate TOTTENHAM
""");

Console.Write("Does it move? (Y/N) ");
String answer = Console.ReadLine();

// Kolla om svart är ja eller nej
if (answer == "Y")
{ // Y
    Console.Write("Should It? (Y/N)");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("No Problem");
    }
    else
    {
        Console.WriteLine("Please use duct tape!");
    }
}  
else 
{ // NO
    Console.Write("Should It? (Y/N)");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("Please use WD_40!");
    }
    else
    {
        Console.WriteLine("No Problem");
    }

}


