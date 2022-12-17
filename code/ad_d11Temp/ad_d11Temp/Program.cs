// See https://aka.ms/new-console-template for more information
using System.Numerics;

string text = File.ReadAllText(@"..\..\..\..\..\..\txt\day11Temp.txt");

string[] monkeys = text.Split("\r\n\r\n");
int rounds = 0;
List<Monkey> monkeyList = new List<Monkey>();

foreach (string monkey in monkeys)
{
    string[] atributes = monkey.Split("\r\n");
    string[] tempId = atributes[0].Split(' ');
    int id = Int32.Parse(tempId[1].Remove(1));
    string[] atributeTwo = atributes[1].Split(": ");
    string[] tempItems = atributeTwo[1].Split(", ");
    List<long> itemList = new List<long>();
    foreach (string item in tempItems)
    {
        int i = Int32.Parse(item);
        itemList.Add(i);
    }
    Monkey m = new Monkey(id, itemList);
    monkeyList.Add(m);
}
while (rounds < 10000)
{
    foreach (Monkey m in monkeyList)
    {
        for (int i = 0; i < m.Items.Count; i++)
        {
            m.inspectCount++;
            switch (m.Id)
            {
                case 0:
                    m.Items[i] = (m.Items[i] * 19);
                    
                    if (m.Items[i] % 23 == 0)
                    {
                        m.Items[i] %= 96577;
                        monkeyList[2].Items.Add(m.Items[i]);
                    }
                    else
                    {
                        m.Items[i] %= 96577;
                        monkeyList[3].Items.Add(m.Items[i]);
                    }
                    break;
                case 1:
                    m.Items[i] = (m.Items[i] + 6);
                    if (m.Items[i] % 19 == 0)
                    {
                        m.Items[i] %= 96577;
                        monkeyList[2].Items.Add(m.Items[i]);
                    }
                    else
                    {
                        m.Items[i] %= 96577;
                        monkeyList[0].Items.Add(m.Items[i]);
                    }
                    break;
                case 2:
                    m.Items[i] = (m.Items[i] * m.Items[i]);
                    if (m.Items[i] % 13 == 0)
                    {
                        m.Items[i] %= 96577;
                        monkeyList[1].Items.Add(m.Items[i]);
                    }
                    else
                    {
                        m.Items[i] %= 96577;
                        monkeyList[3].Items.Add(m.Items[i]);
                    }
                    break;
                case 3:
                    m.Items[i] = (m.Items[i] + 3);
                    if (m.Items[i] % 17 == 0)
                    {
                        m.Items[i] %= 96577;
                        monkeyList[0].Items.Add(m.Items[i]);
                    }
                    else
                    {
                        m.Items[i] %= 96577;
                        monkeyList[1].Items.Add(m.Items[i]);
                    }
                    break;
            }
        }
        m.Items = new List<long>();
    }
    rounds++;
}
long largest = 0;
long second = 0;
foreach (Monkey m in monkeyList)
{
    Console.WriteLine(m.inspectCount);
    if (m.inspectCount > largest)
    {
        second = largest;
        largest = m.inspectCount;
    }
    else if (m.inspectCount > second)
    {
        second = m.inspectCount;
    }
}
Console.WriteLine(largest * second);

public class Monkey
{
    public int Id { get; set; }
    public List<long> Items { get; set; }
    public long inspectCount { get; set; }

    public Monkey(int id, List<long> items)
    {
        Id = id;
        Items = items;
        inspectCount = 0;
    }

}
