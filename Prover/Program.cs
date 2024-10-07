using System.Runtime.CompilerServices;

Console.Clear();

while (true)
{

    Console.WriteLine("Vad heter du?");
    string namn = Console.ReadLine();
   

    Console.WriteLine($"{namn}, Ange din årslön i Kronor!");

    int bruttolön = int.Parse(Console.ReadLine());

    int nettolön = 0;

    if (bruttolön < 10000 || bruttolön > 1000000)

    {
        Console.WriteLine($"{namn}, Bruttolön måste vara mellan 10000:- och 1000000:-");
    }


    else if (bruttolön < 10000 || bruttolön <= 145000)
    {
        Console.WriteLine("fattig");
        nettolön = bruttolön * (100 - 22) / 100;
    }

    else if (bruttolön > 145000 || bruttolön <= 515000)
    {
        Console.WriteLine("medelklass");
        nettolön = bruttolön * (100 - 33) / 100;
    }


    else if (bruttolön > 515000 || bruttolön < 1000000)
    {
        Console.WriteLine("Grattis du är rik!");
        nettolön = bruttolön * (100 - 53) / 100;
    }


    Console.WriteLine($"Din nettolön är {nettolön}KR. Uträkning baserad på bruttolön {bruttolön}KR och marginalskatten. ");



    Console.WriteLine("Vill du göra en ny beräkning? (J/N): ");
    string svar = Console.ReadLine();
    if (svar == "N")
    {
        // Om svaret är Nej så bryts loopen
        break;
    }


}


