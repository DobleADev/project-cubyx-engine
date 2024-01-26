using System.Numerics;
using Raylib_cs;

public class Sprite : Asset
{
    public Texture2D sprite {get; set;}
    public Vector2 origin {get; set;}
    public Sprite(string path, string name = "New Sprite") : base(path, name)
    {
        sprite = Raylib.LoadTexture(path);
    }

    public void Load(Vector2 position, Vector2 scale)
    {
        Raylib.DrawTexture(sprite, (int)position.X, (int)position.Y, Color.WHITE);
        // LoadInternal(texture2D);
    }

    public void Load(Vector2 position)
    {
        Raylib.DrawTextureEx(sprite, position, 0, 1f, Color.WHITE);
        // LoadInternal(texture2D);
    }

    public void Load(Vector2 position, float rotation, Vector2 scale, Color tint)
    {
        Raylib.DrawTextureEx(sprite, position, rotation, scale.X, tint);
        // LoadInternal(texture2D);
    }

    // private void LoadInternal(Texture2D texture)
    // {
        
    // }
}