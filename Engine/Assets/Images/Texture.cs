using System.Numerics;
using Raylib_cs;

public class Texture : Asset
{
    public Texture2D texture2D {get; set;}
    public Texture(string path, string name = "New Texture") : base(path, name)
    {
        texture2D = Raylib.LoadTexture(path);
    }

    public void Load(Vector2 position, Vector2 scale)
    {
        Raylib.DrawTexture(texture2D, (int)position.X, (int)position.Y, Color.WHITE);
        // LoadInternal(texture2D);
    }

    public void Load(Vector2 position)
    {
        Raylib.DrawTextureEx(texture2D, position, 0, 1f, Color.WHITE);
        // LoadInternal(texture2D);
    }

    public void Load(Vector2 position, float rotation, Vector2 scale, Color tint)
    {
        Raylib.DrawTextureEx(texture2D, position, rotation, scale.X, tint);
        // LoadInternal(texture2D);
    }

    // private void LoadInternal(Texture2D texture)
    // {
        
    // }
}