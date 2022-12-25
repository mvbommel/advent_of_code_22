// See https://aka.ms/new-console-template for more information

List<Tile> GetAdjecentTiles(Tile current, List<Tile> tiles)
{
    List<Tile> adjecent = new List<Tile>();

    foreach (Tile tile in tiles)
    {
        if (tile.x == current.x && (tile.y == current.y - 1 || tile.y == current.y + 1))
        {
            if (current.value - 1 <= tile.value && !tile.visited)
            {
                tile.count = current.count + 1;
                adjecent.Add(tile);
            }
        }
        else if (tile.y == current.y && (tile.x == current.x - 1 || tile.x == current.x + 1))
        {
            if (current.value -1 <= tile.value && !tile.visited)
            {
                tile.count = current.count + 1;
                adjecent.Add(tile);
            }
        }
    }
    return adjecent;
}


List<string> lines = File.ReadAllLines(@"..\..\..\..\..\..\txt\day12.txt").ToList();
List<Tile> tiles = new List<Tile>();
for (int i = 0; i < lines.Count; i++)
{
   
    for (int j = 0; j < lines[0].Length; j++)
    {
        Tile tile = new Tile();
        tile.y = i;
        tile.x = j;
        tile.character = lines[i][j];
        tile.value = lines[i][j] - '0';
        tile.visited = false;
        tiles.Add(tile);
    }
}

List<Tile> activeTiles = new List<Tile>();
foreach (Tile tile in tiles)
{
    if (tile.character == 'S')
    {
        tile.value = 'a' - '0';
    }
    else if (tile.character == 'E')
    {
        tile.value = 'z' - '0';
        tile.count = 0;
        activeTiles.Add(tile);
    }
}
Console.WriteLine(activeTiles.Count);
while (activeTiles.Count > 0)
{
    Tile current = activeTiles.First();
    current.visited = true;
    if (current.character == 'S' || current.character == 'a')
    {
        Console.WriteLine("arrived at finish");
        Console.WriteLine(current.count);
        return;
    }

    List<Tile> adjecent = GetAdjecentTiles(current, tiles);
    Console.WriteLine(adjecent.Count);
    foreach (Tile tile in adjecent)
    {
        if(activeTiles.Any(x => x.x == tile.x && x.y == tile.y))
        {
            continue;
        }
        activeTiles.Add(tile);

    }
    activeTiles.Remove(current);
}
Console.WriteLine("no end found");



class Tile
{
    public int x { get; set; }
    public int y { get; set; }
    public char character { get; set; }
    public int value { get; set; }
    public bool visited { get; set; }
    public int count { get; set; }

}