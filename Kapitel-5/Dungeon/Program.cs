//Ett Dungeon-spel med massa rum, skaer, fiender, skatter ..
Console.Clear();
Console.WriteLine("Ett Dungeon-spel");

// Programvariabler (state variables)
string rum = "hallen";
List<string> inventarie = [];
int liv = 3;

//Spelloop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar i rummet och ser några gamla tavlor:");
        }
    
        else if (val == "2")
        {
        rum = "köket";
        Console.WriteLine(". . du går in i nästa rum . .");
        }  

    }

    else if (rum == "köket")
    {
        Console.WriteLine("Du är i köket");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till hallen");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en kniv på golvet.");
            Console.WriteLine("Vill du plocka upp kniven (J/N)");
            val = Console.ReadLine(). ToLower();
            if (val == "J")
            {
                inventarie.Add("Kniv");
                Console.WriteLine("Du plockade upp Kniv.");
            }
            else (val == "N")
            {
                Console.WriteLine("Du lämnar nyckeln på golvet!");
            }
        }

        else if (val == "2")
        {
        rum = "hallen";
        Console.WriteLine("Du går tillbaka till hallen");
        }  

        else if (val == "3")
        {
        rum = "rum 1";
        Console.WriteLine(". . du går in i nästa rum . .");
        }  
    }  
    
    else if (rum == "rum 2")
    {
        Console.WriteLine("Du är i rum 2");
    
        // Slumpa en händelse 
        int händelse = Random.Shared.Next (1, 5);
        if (händelse == 1)
        {
            Console.WriteLine("Du ser ett svärd på marken. Vill du plocka upp det? (J/N)");
            string val = Console.ReadLine().ToLower();
        
            if (!inventarie.Contains("svärd") && val == "j")
            {
                inventarie.Add("svärd");
                Console.WriteLine("Du har nu ett svärd");
            }
        }

        else if (händelse == 2)
        {
            Console.WriteLine("Ett spöke dyker upp");
            //..
        }
        else if (händelse == 3)
        {
            Console.WriteLine("Du trmapar på en min och tappar ett liv");
            liv--;

        }
     
        else if (händelse == 4)
        {
        
        }
    }

}
