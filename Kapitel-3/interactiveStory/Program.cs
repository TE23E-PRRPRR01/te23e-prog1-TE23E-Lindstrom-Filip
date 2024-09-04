Console.WriteLine("Hello, World!");

Console.Write("Arsenal är bäst? (Yes/No) ");
String answer = Console.ReadLine();

// Kolla om svart är ja eller nej
if (answer == "Yes")
{ // Y
    Console.Write("Vinner vi ligan? (Yes/No)");
    answer = Console.ReadLine();
    if (answer == "Yes")
    {
        Console.WriteLine("Du har helt rätt");
    }
    else
    {
        Console.WriteLine("Man city plasticfan!");
    }
}  
else 
{ // NO
    Console.Write("Tottenham supporter? (Yes/No)");
    answer = Console.ReadLine() .ToLower(); // .ToUpper()
    if (answer == "Yes")
    {
        Console.WriteLine("Tänk om dina livsval!");
    }
    else
    {
        Console.WriteLine("oh tack Gud?");
    }

}


