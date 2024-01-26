public class Asset
{
    public string Name {get; set;}
    public string Path {get; set;}

    public Asset(string path, string name = "New Asset")
    {
        Name = name;
        Path = path;
    }
}