// See https://aka.ms/new-console-template for more information
string text = File.ReadAllText(@"..\..\..\..\..\..\txt\day6.txt");
char[] characters = text.ToCharArray();

List<char> marker = new List<char>();
int startIndex = 14;
foreach( char c in characters)
{
    if(marker.Count < 14)
    {
        marker.Add(c);
    }
    else
    {
        if (marker.Count() != marker.Distinct().Count())
        {
            marker.RemoveAt(0);
            startIndex++;
            marker.Add(c);
        }
        else
        {
            break;
        }
        
    }
}
Console.WriteLine(startIndex);
