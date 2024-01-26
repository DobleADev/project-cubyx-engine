public class Asset
{
    public string Name {get; set;}
    public string Path {get; set;}

    public Asset(string name = "New Asset", string path = "")
    {
        Name = name;
        Path = path;
    }
}