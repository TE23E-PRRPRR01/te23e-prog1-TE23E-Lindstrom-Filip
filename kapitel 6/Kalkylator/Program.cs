
/******************************
**********M A I N *************
******************************/
while (true)
{

    VisaMeny();

    string val = Console.ReadLine();


    if (val == "1")
    {
        Adition();
    }

    else if (val == "2")
    {

    }

    else if (val == "3")
    {

    }
   
    else if (val == "4")
    {

    }

     else if (val == "5")
    {

    }
    
    else
    {
        Console.WriteLine("""
        Du angav felaktigt värde
        Försök igen!
        """);
    }
}




/******************************
**********M A I N *************
******************************/



static void VisaMeny()
{
    Console.WriteLine("""
Vad vill du göra
1.Addition
2.subraktion
3.multiplikation
4.Division
5.Avsluta programmet
""");
}