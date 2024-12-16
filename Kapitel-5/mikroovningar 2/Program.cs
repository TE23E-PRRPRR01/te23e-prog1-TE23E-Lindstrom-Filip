Console.Clear();

List<string> listaActionSpel = [];

listaActionSpel.Add("avengers");
listaActionSpel.Add("starwars");

foreach (var namn in listaActionSpel)
{
    Console.WriteLine($"- {namn}");
}

List<string> listaäventyrsSpel = [];

listaäventyrsSpel.Add("COD");
listaäventyrsSpel.Add("CS");

foreach (var namn in listaäventyrsSpel)
{
    Console.WriteLine($"- {namn}");
}


Console.WriteLine("Nu ska du fylla på listan med två äventyrs spel");

for (int i = 0; i < 2;)
{
    i++;
    Console.Write($"Spel {i} :");
    listaäventyrsSpel.Add(Console.ReadLine());
}

Console.WriteLine("Nu ska du fylla på listan med två action spel");

for (int i = 0; i < 2;)
{
    i++;
    Console.Write($"Spel {i} :");
    listaActionSpel.Add(Console.ReadLine());
}

Console.WriteLine("Nus er listan ut såhär");

foreach (var namn in listaActionSpel)
{
    Console.WriteLine($"- {namn}");
}


Console.WriteLine("Nu ser listan ut såhär");

foreach (var namn in listaäventyrsSpel)
{
    Console.WriteLine($"- {namn}");
}
