// See https://aka.ms/new-console-template for more information
string[] backpacks = File.ReadAllLines(@"G:\marc\advent_of_code\advent_of_code_22\txt\day3.txt");

List<char> items = new List<char>();

for(int i = 0; i<backpacks.Count(); i+= 3)
{
    foreach (char c in backpacks[i])
    {
        if (backpacks[i+1].Contains(c) && backpacks[i + 2].Contains(c))
        {
            items.Add(c);
            break;
        }
    }
}

int total = 0;
foreach (char c in items)
{
    switch (c)
    {
        case 'a':
            total++;
            break;
        case 'b':
            total += 2;
            break;
        case 'c':
            total += 3;
            break;
        case 'd':
            total += 4;
            break;
        case 'e':
            total += 5;
            break;
        case 'f':
            total += 6;
            break;
        case 'g':
            total += 7;
            break;
        case 'h':
            total += 8;
            break;
        case 'i':
            total += 9;
            break;
        case 'j':
            total += 10;
            break;
        case 'k':
            total += 11;
            break;
        case 'l':
            total += 12;
            break;
        case 'm':
            total += 13;
            break;
        case 'n':
            total += 14;
            break;
        case 'o':
            total += 15;
            break;
        case 'p':
            total += 16;
            break;
        case 'q':
            total += 17;
            break;
        case 'r':
            total += 18;
            break;
        case 's':
            total += 19;
            break;
        case 't':
            total += 20;
            break;
        case 'u':
            total += 21;
            break;
        case 'v':
            total += 22;
            break;
        case 'w':
            total += 23;
            break;
        case 'x':
            total += 24;
            break;
        case 'y':
            total += 25;
            break;
        case 'z':
            total += 26;
            break;
        case 'A':
            total += 27;
            break;
        case 'B':
            total += 28;
            break;
        case 'C':
            total += 29;
            break;
        case 'D':
            total += 30;
            break;
        case 'E':
            total += 31;
            break;
        case 'F':
            total += 32;
            break;
        case 'G':
            total += 33;
            break;
        case 'H':
            total += 34;
            break;
        case 'I':
            total += 35;
            break;
        case 'J':
            total += 36;
            break;
        case 'K':
            total += 37;
            break;
        case 'L':
            total += 38;
            break;
        case 'M':
            total += 39;
            break;
        case 'N':
            total += 40;
            break;
        case 'O':
            total += 41;
            break;
        case 'P':
            total += 42;
            break;
        case 'Q':
            total += 43;
            break;
        case 'R':
            total += 44;
            break;
        case 'S':
            total += 45;
            break;
        case 'T':
            total += 46;
            break;
        case 'U':
            total += 47;
            break;
        case 'V':
            total += 48;
            break;
        case 'W':
            total += 49;
            break;
        case 'X':
            total += 50;
            break;
        case 'Y':
            total += 51;
            break;
        case 'Z':
            total += 52;
            break;
    }
}
Console.WriteLine(total);