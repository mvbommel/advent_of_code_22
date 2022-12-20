// See https://aka.ms/new-console-template for more information
List<string> lines = File.ReadAllLines(@"..\..\..\..\..\..\txt\day10.txt").ToList();

List<int> signalStrenghts = new List<int>();
int currentTick = 0;
int x = 1;
string rOne = "";
string rTwo = "";
string rThree = "";
string rFour = "";
string rFive = "";
string rSix = "";

foreach (string line in lines)
{
    if (line.Contains("noop"))
    {
        currentTick++;
        draw();
        if ( findSignalStrength() != 0)
        {
            signalStrenghts.Add(findSignalStrength());
        }
        
    }
    else if (line.Contains("addx"))
    {
        currentTick++;
        draw();
        if (findSignalStrength() != 0)
        {
            signalStrenghts.Add(findSignalStrength());
        }
        currentTick++;
        draw();
        if (findSignalStrength() != 0)
        {
            signalStrenghts.Add(findSignalStrength());
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
Console.WriteLine(rOne);
Console.WriteLine(rTwo);
Console.WriteLine(rThree);
Console.WriteLine(rFour);
Console.WriteLine(rFive);
Console.WriteLine(rSix);

int findSignalStrength()
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

void draw()
{
    Console.WriteLine("currenttick " + currentTick + " x " + x);
    switch(currentTick)
    {
        case var expression when currentTick <= 40:
            if(currentTick == x || currentTick == x+1 || currentTick == x + 2)
            {
                rOne += 'X';
            }
            else
            {
                rOne +=' ';
            }
            break;
        case var expression when currentTick > 40 && currentTick <= 80:
            if (currentTick - 40 == x || currentTick -40 == x + 1 || currentTick -40 == x + 2)
            {
                rTwo += 'X';
            }
            else
            {
                rTwo += ' ';
            }
            break;
        case var expression when currentTick > 80 && currentTick <= 120:
            if (currentTick -80  == x || currentTick -80 == x + 1 || currentTick -80 == x + 2)
            {
                rThree += 'X';
            }
            else
            {
                rThree += ' ';
            }
            break;
        case var expression when currentTick > 120 && currentTick <= 160:
            if (currentTick -120 == x || currentTick -120 == x + 1 || currentTick - 120 == x + 2)
            {
                rFour += 'X';
            }
            else
            {
                rFour += ' ';
            }
            break;
        case var expression when currentTick > 160 && currentTick <= 200:
            if (currentTick - 160 == x || currentTick - 160 == x + 1 || currentTick -160 == x + 2)
            {
                rFive += 'X';
            }
            else
            {
                rFive += ' ';
            }
            break;
        case var expression when currentTick > 200 && currentTick <= 240:
            if (currentTick - 200 == x || currentTick -200 == x + 1 || currentTick - 200 == x + 2)
            {
                rSix += 'X';
            }
            else
            {
                rSix += ' ';
            }
            break;
    }
}