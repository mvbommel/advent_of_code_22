// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Drawing;

List<string> lines = File.ReadAllLines(@"..\..\..\..\..\..\txt\day8.txt").ToList();

int height = lines.Count;
int width = lines[0].Length;


List<long> ScenicScores = new List<long>();
for(int y = 0; y < height; y++)
{
    for( int x =0; x < width; x++)
    {
        long countL = 0;
        long countR = 0;
        long countT = 0;
        long countB = 0;

        for (int i = x-1; i >=0; i--)
        {
            if (lines[y][i] < lines[y][x])
            {
                countL++;
            }
            else
            {
                countL++;
                break;
            }
        }

        for (int i = x + 1; i < width; i++)
        {
            if (lines[y][i] < lines[y][x])
            {
                countR++;
            }
            else
            {
                countR++;
                break;
            }
        }

        for (int i = y - 1; i >= 0; i--)
        {
            if (lines[i][x] < lines[y][x])
            {
                countT++;
            }
            else
            {
                countT++;
                break;
            }
        }

        for (int i = y + 1; i < height; i++)
        {
            if (lines[i][x] < lines[y][x])
            {
                countB++;
            }
            else
            {
                countB++;
                break;
            }
        }

        ScenicScores.Add(countL*countR*countT*countB);
    }
}
foreach(long score in ScenicScores)
{
    Console.WriteLine(score);
}

long topScore = ScenicScores.Max(score => score);
Console.WriteLine("top "+ topScore);