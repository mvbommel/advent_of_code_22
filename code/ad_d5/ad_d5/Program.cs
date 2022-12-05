// See https://aka.ms/new-console-template for more information
string text = File.ReadAllText(@"G:\marc\advent_of_code\advent_of_code_22\txt\day5.txt");

string[] parts = text.Split("\r\n\r\n");

string[] moveSets = parts[1].Split("\r\n");

List<Stack<char>> stacks = new List<Stack<char>>();

Stack<char> one = new Stack<char> (new char[]{ 'B', 'P', 'N', 'Q', 'H', 'D', 'R', 'T' });
stacks.Add(one);
Stack<char> two = new Stack<char> (new char[] { 'W', 'G', 'B', 'J', 'T', 'V'});
stacks.Add(two);
Stack<char> three = new Stack<char> (new char[] { 'N', 'R', 'H', 'D', 'S', 'V', 'M', 'Q' });
stacks.Add(three);
Stack<char> four = new Stack<char> (new char[] { 'P', 'Z', 'N', 'M', 'C'});
stacks.Add(four);
Stack<char> five = new Stack<char> (new char[] { 'D', 'Z', 'B'});
stacks.Add(five);
Stack<char> six = new Stack<char> (new char[] { 'V', 'C', 'W', 'Z'});
stacks.Add(six);
Stack<char> seven = new Stack<char> (new char[] { 'G', 'Z', 'N', 'C', 'V', 'Q', 'L', 'S' });
stacks.Add(seven);
Stack<char> eight = new Stack<char>(new char[] { 'L', 'G', 'J', 'M', 'D', 'N', 'V'});
stacks.Add(eight);
Stack<char> nine = new Stack<char> (new char[] { 'T', 'P', 'M', 'F', 'Z', 'C', 'G'});
stacks.Add(nine);

foreach ( string move in moveSets)
{  
    string cleaned = move.Replace("\r\n", "");
    string[] steps = cleaned.Split(new string[] { "move ", " from ", " to ", }, StringSplitOptions.None);

    int[] stepsNumeric = new int[steps.Length];
    for (int i = 1; i < steps.Length; i++)
    {
        stepsNumeric[i] = Int32.Parse(steps[i]);
    }
    Stack<char> temp = new Stack<char>();
    for (int i = 0; i < stepsNumeric[1]; i++)
    {
        temp.Push(stacks[stepsNumeric[2] - 1].Pop());
    }
    for (int i = 0; i < stepsNumeric[1]; i++)
    {
        stacks[stepsNumeric[3]-1].Push(temp.Pop());
    }
}
string ans = "";
foreach (Stack<char> stack in stacks)
{
    ans+= stack.Peek();
}

Console.WriteLine(ans);