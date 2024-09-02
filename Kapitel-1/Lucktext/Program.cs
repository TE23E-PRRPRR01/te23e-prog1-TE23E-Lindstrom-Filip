using System.Reflection.Metadata;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding =System.Text.Encoding.Unicode;
Console.Clear();
Console.WriteLine("Välkommen till vår lucktext!");
Console.WriteLine("Ange förnamn:");
string förnamn = Console.ReadLine();
Console.WriteLine("Ange bästa fotbolls lag:");
string bästaFotbollsLag = Console.ReadLine();


if(bästaFotbollsLag == "Barcelona")
{
    Console.WriteLine("HELT FEL VAL!!!");
}


if (bästaFotbollsLag == "Arsenal")
{
    Console.WriteLine("HELT RÄTT VAL!!!");
}

Console.WriteLine("Ange bästa fotbolls spelare:");
string bästaFotbollsSpelare = Console.ReadLine();


if (bästaFotbollsSpelare == "Saka")
{
    Console.WriteLine("Vår STARBOY");
}


Console.WriteLine("Ange Hur många mål gjorde " + bästaFotbollsSpelare);
string HurMångaMålGjordebästaFotbollsSpelare = Console.ReadLine();

if (HurMångaMålGjordebästaFotbollsSpelare == "15")
{
   Console.WriteLine("ball knowledge"); 
}