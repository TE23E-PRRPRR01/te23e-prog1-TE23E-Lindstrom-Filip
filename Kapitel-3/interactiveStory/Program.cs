
Console.WriteLine("Hello, World!");

Console.Write("Arsenal är bäst? (Y/N) ");
String answer = Console.ReadLine();

// Kolla om svart är ja eller nej
if (answer == "Y")
{ // Y
    Console.Write("Vinner vi ligan? (Y/N)");
    answer = Console.ReadLine();
    if (answer == "Y")
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
    Console.Write("Tottenham supporter? (Y/N)");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("Tänk om dina livsval!");
    }
    else
    {
        Console.WriteLine("oh tack Gud?");
    }

}


