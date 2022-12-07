// See https://aka.ms/new-console-template for more information
List<string> lines = File.ReadAllLines(@"..\..\..\..\..\..\txt\day7.txt").ToList();

Folder root = new Folder();
root.name = "/";
Folder currentFolder = root;
for (int i = 1; i < lines.Count; i++)
{
    string[] parts = lines[i].Split(' ');

    if (parts[0].Equals("$"))
    {
        if (parts[1].Equals("cd"))
        {
            if (parts[2].Equals(".."))
            {
                currentFolder = currentFolder.parent;
            }
            else
            {
                foreach (Node n in currentFolder.contents)
                {
                    if (n.name.Equals(parts[2]))
                    {
                        currentFolder = (Folder)n;
                        break;
                    }
                }
            }
        }
    }
    else if (parts[0].Equals("dir"))
    {
        Folder folder = new Folder();
        folder.name = parts[1];
        folder.parent = currentFolder;
        currentFolder.contents.Add(folder);
    }
    else
    {
        DirFile file = new DirFile();
        file.parent = currentFolder;
        file.name = parts[1];
        file.size = Int32.Parse(parts[0]);
        currentFolder.contents.Add(file);
    }
}

List<Folder> folders = new List<Folder>();
List<Folder> toCheck = new List<Folder>(root.getSubFolders());
while (toCheck.Count > 0)
{
    Folder f = toCheck[0];
    toCheck.RemoveAt(0);
    toCheck.AddRange(f.getSubFolders());
    if(f.getSize() <= 100000)
    {
        folders.Add(f);
    }
}
long sum = 0;
foreach(Folder f in folders)
{
    sum += f.getSize();
}
   // Console.WriteLine(sum);

long totalSpace = 70000000;
long freeSpace = totalSpace - root.getSize();
long smallestFree = root.getSize();

toCheck = new List<Folder>(root.getSubFolders());
while(toCheck.Count > 0)
{
    Folder f = toCheck[0];
    toCheck.RemoveAt(0);
    toCheck.AddRange(f.getSubFolders());
    long size = f.getSize();
    if(freeSpace + size > 30000000 && size < smallestFree)
    {
        smallestFree= size;
    }
}
Console.WriteLine(smallestFree);


public abstract class Node
{
    public Folder parent { get; set; }
    public string name { get; set; }

    public abstract long getSize();

}
public class DirFile : Node
{
    public int size { get; set; }
    public override long getSize()
    {
        return size;
    }
}

public class Folder : Node
{
    public List<Node> contents = new List<Node>();

    public List<Folder> getSubFolders()
    {
        List<Folder> folders = new List<Folder>();
        foreach(Node n in contents)
        {
            if ( n is Folder){
                folders.Add((Folder)n);
            }
        }
        return folders;
    }

    public override long getSize()
    {
        long size = 0;
        foreach(Node n in contents){
            size += n.getSize();
        }
        return size;
    }
}
