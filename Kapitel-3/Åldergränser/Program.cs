// 
Console.Clear();
Console.WriteLine("Ålder vid första mord");


Console.Write("Ange Ålder");

string ÅlderText = Console.ReadLine();

int Ålder = int.Parse(ÅlderText);


if (Ålder <= 5)
{
    Console.WriteLine("Imponerande, Hur fan lyckas man?");
}

else if (Ålder <= 9)
   {
     Console.WriteLine("Bra jobbat, stabil ålder");
   }

else if(Ålder <= 14)
   {
    Console.WriteLine("Lite sent men det funkar");
   }
else if (Ålder >= 18)
{
    Console.WriteLine("Varför gjorde du det då är för HELVETE straffmyndig");
}


