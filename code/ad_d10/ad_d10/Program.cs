// See https://aka.ms/new-console-template for more information
List<string> lines = File.ReadAllLines(@"..\..\..\..\..\..\txt\day10.txt").ToList();

List<int> signalStrenghts = new List<int>();
int currentTick = 0;
int x = 1;
foreach (string line in lines)
{
    if (line.Contains("noop"))
    {
        currentTick++;
        if ( findSignalStrength(currentTick) != 0)
        {
            signalStrenghts.Add(findSignalStrength(currentTick));
        }
        
    }
    else if (line.Contains("addx"))
    {
        currentTick++;
        if (findSignalStrength(currentTick) != 0)
        {
            signalStrenghts.Add(findSignalStrength(currentTick));
        }
        currentTick++;
        if (findSignalStrength(currentTick) != 0)
        {
            signalStrenghts.Add(findSignalStrength(currentTick));
        }
        string[] addValues = line.Split(' ');
        x += Int32.Parse(addValues[1]);
        
    }
}

int total = 0;
foreach (int strength in signalStrenghts)
{
    total += strength;
}
Console.WriteLine(total);
int findSignalStrength(int currentTick)
{
    switch (currentTick)
    {
        case 20:
            return x * 20;
        case 60:
            return x * 60;
        case 100:
            return x * 100;
        case 140:
            return x * 140;
        case 180:
            return x * 180;
        case 220:
            return x * 220;
         default: return 0;
    }
        

}
