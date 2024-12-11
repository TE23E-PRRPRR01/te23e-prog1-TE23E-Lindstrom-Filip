Console.Clear();


// Exempel med djur
List<string> listamaträtter = ["Tjock bullar", "negerbollar", "kumkaka"];
while (true)
{
    Console.Write("Ange en maträtt att lägga till (eller 'exit' för att avsluta): ");
    string maträtt = Console.ReadLine();
    if (maträtt == "exit")
    {
        break;
    }
    listamaträtter.Add(maträtt);
}
// Skriv ut alla djur

Console.WriteLine("Alla maträtter:");

foreach (string rätter in listamaträtter)
{
    Console.WriteLine($" - {rätter}");
}
