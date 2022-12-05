// See https://aka.ms/new-console-template for more information


string text = File.ReadAllText(@"G:\marc\advent_of_code\advent_of_code_22\txt\day1.txt");

string[] elves = text.Split("\r\n\r\n");
List<int> list = new List<int>();

foreach (string elve in elves)
{
    string[] calories = elve.Split("\r\n");
    int total = 0;
    foreach(string cal in calories)
    {
        total += Int32.Parse(cal);
    }
    list.Add(total);
}

int biggestNr = 0;
int second = 0;
int third = 0;

for (int i = 0; i < list.Count(); i++)
{
    if (list[i] >= biggestNr)
    {
        third = second;
        second = biggestNr;
        biggestNr = list[i];
    }
    else if(list[i] >= second){
        third = second;
        second = list[i];
    }
    else if (list[i] >= third)
    {
        third = list[i];
    }
}
Console.WriteLine(biggestNr + second + third);

