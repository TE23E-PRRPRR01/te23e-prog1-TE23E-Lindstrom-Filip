// morsekod översättare
Console.Clear();

Console.WriteLine("En liten morsekod app");

// två listor

List<string> alfabetet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I",
                            "J", "K", "L", "M", "N", "O", "P", "Q", "R",
                            "S", "T", "U", "V", "W", "X", "Y", "Z", "Å",
                            "Ä", "Ö", "1", "2", "3", "4", "5", "6", "7",
                            "8", "9",];

List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                          "....", "..", ".---", "-.-", ".-..", "--", "-.",
                          "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                          "...-", ".--", "-..-", "-.--", "--..", ".--.-",
                          ".-.-", "---.", "/", ".---- ", "..--- ", "...--",
                          "....- ", "..... ", "-.... ", "--... ", " ----------------------..", ];


//läs in meddelande
Console.Write("Ange meddelande: ");
string meddelande = Console.ReadLine();

//Gå igenom meddelandet bokstav för bokstav (loop)
foreach (char bokstav in meddelande)
{
    // uppslag i alfabetet efter index 
    int index = alfabetet.IndexOf(bokstav.ToString());

    //hittar morsetecken (A-Ö)?
    if (index >= 0)
    {
        Console.Write($"{bokstav} finns på index {index}  ");

        //plocka ut morsetecknet för detta index
        string morsetecken = morsekod[index];
        Console.Write($"{bokstav} är {morsetecken}");
        Console.Write($"{morsetecken} ");

        //spela upp morse som ljud-beep
        // tex D = "-.." 
        // dvs loopa igenom morsetecknet
        foreach (char tecken in morsetecken)
        {
            if (tecken == '.')
            {
                // 100Hz, 200ms
                Console.Beep(1000, 200);
            }
            else // 
            {
                Console.Beep(1000, 600);
            }

        }

    }
    else
    {
        Console.WriteLine("?");
    }

}






