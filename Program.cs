int totalSteps = 30;

for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"Loading... Step {i} of {totalSteps}");
    if (i % 3 == 0)
    {
        Console.WriteLine("Checkpoint reached!");
    }
}

Console.WriteLine("\nDungeon is ready. Enter now");