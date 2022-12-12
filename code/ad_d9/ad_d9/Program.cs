// See https://aka.ms/new-console-template for more information
using System.Drawing;

List<string> lines = File.ReadAllLines(@"..\..\..\..\..\..\txt\day9.txt").ToList();
Point head = new Point(0, 0);
Point tail = new Point(0, 0);
List<Point> tailPosittions = new List<Point>();
tailPosittions.Add(tail);

foreach( string line in lines)
{
    string[] parts = line.Split(' ');
    switch (parts[0])
    {
        case "U":
            head.Y += Int32.Parse(parts[1]);
            int difference = head.Y - tail.Y;
            if (head.X == tail.X) 
            { 
                if (difference > 1)
                {
                   while(difference - 1 > 0)
                    {
                        tail.Y++;
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference--;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            else if (head.X > tail.X)
            {
                if (difference > 1)
                {
                    while (difference - 1 > 0)
                    {
                        tail.Y++;
                        if(head.X != tail.X)
                        {
                            tail.X++;
                        }
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference--;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            else if (head.X < tail.X)
            {
                if (difference > 1)
                {
                    while (difference - 1 > 0)
                    {
                        tail.Y++;
                        if (head.X != tail.X)
                        {
                            tail.X--;
                        }
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference--;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            break;
        case "D":
            head.Y -= Int32.Parse(parts[1]);
            difference = head.Y - tail.Y;
            if (head.X == tail.X)
            {
                if (difference < -1)
                {
                    while (difference +1 < 0)
                    {
                        tail.Y--;
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference++;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            else if ( head.X < tail.X)
            {
                if (difference < -1)
                {
                    while (difference + 1  < 0)
                    {
                        tail.Y -= 1;
                        if (head.X != tail.X)
                        {
                            tail.X -= 1;
                        }  
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference++;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            else if ( head.X > tail.X)
            {
                if (difference < -1)
                {
                    while (difference + 1 < 0)
                    {
                        tail.Y -= 1;
                        if (head.X != tail.X)
                        {
                            tail.X += 1;
                        }
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference++;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            break;
        case "L":
            head.X -= Int32.Parse(parts[1]);
            difference = head.X - tail.X;
            if(head.Y == tail.Y)
            {
                if (difference < -1) 
                {

                    while (difference +1 < 0)
                    {
                        tail.X--;
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference++;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            else if( head.Y < tail.Y)
            {
                if (difference < -1)
                {
                    while (difference + 1 < 0)
                    {
                        if(head.Y != tail.Y)
                        {
                            tail.Y--;
                        }
                        
                        tail.X--;
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference++;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            else if( head.Y > tail.Y)
            {
                if (difference < -1)
                {
                    while (difference + 1 < 0)
                    {
                        if (head.Y != tail.Y)
                        {
                            tail.Y++;
                        }

                        tail.X--;
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference++;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            break;
        case "R":
            head.X += Int32.Parse(parts[1]);
            difference = head.X - tail.X;
            if (head.Y == tail.Y)
            {
                if (difference > 1)
                {

                    while (difference -1 > 0)
                    {
                        tail.X++;
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference--;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            else if( head.Y > tail.Y)
            {
                if (difference > 1)
                {
                    while (difference -1 > 0)
                    {
                        if(head.Y != tail.Y)
                        {
                            tail.Y++;
                        }
                        tail.X++;
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference--;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            else if ( head.Y < tail.Y)
            {
                if (difference > 1)
                {
                    while (difference - 1 > 0)
                    {
                        if (head.Y != tail.Y)
                        {
                            tail.Y--;
                        }
                        tail.X++;
                        Console.WriteLine(tail);
                        tailPosittions.Add(tail);
                        difference--;
                    }
                }
                else
                {
                    tailPosittions.Add(tail);
                }
            }
            break;
    }
}

List<Point> distinctPoints = tailPosittions.Distinct().ToList();
Console.WriteLine(distinctPoints.Count);