using System.Runtime.Intrinsics.Arm;

Console.Clear();


Console.Write("ange startvärde:");
int startvärde = int.Parse(Console.ReadLine());

Console.Write("ange slutvärde:");
int slutvärde = int.Parse(Console.ReadLine());

int sum1 = 0;
int sum2 = 0;

Console.Write($"jämna siffror:");
for (int i = startvärde; i < slutvärde +1; i++)
{
   if (i % 2 == 0)
   {
        Console.WriteLine($" {i}");
   }
}

Console.Write($"Udda siffror: ");
for (int i = startvärde; i < slutvärde +1; i++)
{
   if (i % 2 != 0)
   {
        Console.WriteLine($" {i}");
   }
}
