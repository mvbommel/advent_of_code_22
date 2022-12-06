// See https://aka.ms/new-console-template for more information
string[] pairs = File.ReadAllLines(@"..\..\..\..\..\..\txt\day4.txt");

int total = 0;

foreach (string pair in pairs)
{
    string[] areas = pair.Split(',');
    int[][] both = new int[areas.Length][];
    for (int i = 0; i < areas.Length; i++)
    {
        string[] textEnds = areas[i].Split("-");
        int[] ends = new int[2];
        int count = 0;
        foreach (string te in textEnds)
        {
            ends[count] = Int32.Parse(te);
            count++;
        }
        both[i] = ends;
    }

    if (both[0][0] <= both[1][0] && both[0][1] >= both[1][1])
    {
        total++;
    }
    else if (both[1][0] <= both[0][0] && both[1][1] >= both[0][1])
    {
        total++;
    }
    else if (both[0][0] <= both[1][0] && both[0][1] <= both[1][1] && both[0][1] >= both[1][0])
    {
        total++;
    }
    else if (both[1][0] <= both[0][0] && both[1][1] <= both[0][1] && both[1][1] >= both[0][0])
    {
        total++;
    }
}
Console.WriteLine(total);



