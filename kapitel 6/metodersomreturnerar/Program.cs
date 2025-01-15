Console.Clear();

/* ********************************* **
** *********** M A I N ************ **
** ********************************* */
//använd metoder här
int svar = Addera(3, 5);
Console.WriteLine($"Svaret är {svar}");
Console.WriteLine(Addera(3, 5));
Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

string answer = VändText("JAOW");
Console.WriteLine(VändText("JAOW"));

int talsvar = multiplicera(5, 7);
Console.WriteLine(multiplicera(5, 7));

int talsvar2 = division(100, 5);
Console.WriteLine(division(100, 5));

int talsvar3 = AntalISträng(char());
Console.WriteLine();

Console.WriteLine("Ange ett tal: ");
int talny = LäsInHeltal();

Console.WriteLine("Ange ett tal: ");
int talny2 = LäsInHeltal();

/* ********************************* **
** ******** M E T O D E R ********** **
** ********************************* */
//skapa metoder här!

/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2) //signatur (vad variabeln heter)
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}
<<<<<<<<<<<<<<<<
static int LäsInHeltal();
{
    int tal = 0;
    string TextSomBlirTal = Console.ReadLine();
    int.TryParse(TextSomBlirTal, out tal);
    while (true)
    {
        //kolla om texten är ett tal 
        bool lyckades = int.TryParse(TextSomBlirTal, out tal);

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("FEL, var vänlig skriv ett tal!");
        }

    }
    return tal;
}

static int multiplicera(int tal1, int tal2)
{

    int summa = tal1 * tal2;
    return summa;

}

static int division(int tal1, int tal2)
{

    int kvot = tal1 / tal2;
    return kvot;
}

static int AntalISträng(char tecken, string text)
{
    int antal = 0;

    for (int i = 0; i < Text.Length; i++)
    {
        if (text[i] == tecken)
        {
            antal++;
        }
    }
}