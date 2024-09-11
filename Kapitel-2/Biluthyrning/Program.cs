Console.Clear();

Console.Write("Ange antal dagar ni vill hyra");

double dagar = double.Parse (Console.ReadLine());  

Console.Write("Ange antal mil ni komer köra");

double mil = double.Parse (Console.ReadLine());

Double Kostnad = (mil * 5) + (dagar * 50 + 500);

Console.WriteLine(Kostnad);