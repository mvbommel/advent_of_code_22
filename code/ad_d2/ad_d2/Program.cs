// See https://aka.ms/new-console-template for more information

string[] lines = File.ReadAllLines(@"G:\marc\advent_of_code\advent_of_code_22\txt\day2.txt");
List<string> oponent = new List<string>();
List<string> self = new List<string>();
foreach (string line in lines)
{
    string[] sets = line.Split(" ");
    oponent.Add(sets[0]);
    self.Add(sets[1]);
}
int count = oponent.Count();

int score = 0;
for (int i = 0; i < count; i++)
{
    switch (oponent[i])
    {
        case "A":
            if (self[i] == "X")
            {
                score += 3;
            }
            else if (self[i] == "Y")
            {
                score += 1 + 3;
            }
            else if (self[i] == "Z")
            {
                score += 2 + 6;
            }
            break;
        case "B":
            if (self[i] == "X")
            {
                score += 1;
            }
            else if (self[i] == "Y")
            {
                score += 2 + 3;
            }
            else if (self[i] == "Z")
            {
                score += 3 + 6;
            }
            break;
        case "C":
            if (self[i] == "X")
            {
                score += 2;
            }
            else if (self[i] == "Y")
            {
                score += 3+3;
            }
            else if (self[i] == "Z")
            {
                score += 1 + 6;
            }
            break;
    }
    Console.WriteLine(score);

}
Console.WriteLine(score);