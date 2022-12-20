// See https://aka.ms/new-console-template for more information
using System.Drawing;

List<string> lines = File.ReadAllLines(@"..\..\..\..\..\..\txt\day8.txt").ToList();

HashSet<Point> visible = new HashSet<Point>();
for (int row = 0; row < lines.Count; row++)
{
    string s2 = lines[row];
    int highest = 0;
    int reverseHighest = 0;
    for (int col =0; col < s2.Length; col++)
    {
        
        if (s2[col] > highest)
        {
            visible.Add( new Point(row, col));
            highest= s2[col];
        }
        int rCol = s2.Length - (col + 1);
        if (s2[rCol] > reverseHighest)
        {
            visible.Add(new Point(row, rCol));
            reverseHighest = s2[rCol];
        }
    }

}
string s = lines[0];
for (int col = 0; col < s.Length; col++)
{
    int highestDown = 0;
    int highestUp = 0;
    for (int row = 0; row < lines.Count; row++)
    {
        string s2 = lines[row];
        if (s2[col] > highestDown)
        {
            visible.Add(new Point(row, col));
            highestDown = s2[col];
        }
        int rowT = lines.Count - (row + 1);
        s2 = lines[rowT];
        if (s2[col] > highestUp)
        {
            visible.Add(new Point(rowT, col));
            highestUp = s2[col];
        }
    }

}


Console.WriteLine(visible.Count);
