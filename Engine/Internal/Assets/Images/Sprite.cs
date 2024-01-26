using System.Numerics;
using Raylib_cs;

public class Sprite : Asset
{
    public Texture2D sprite {get; set;}
    public Vector2 origin {get; set;}
    public Sprite(string name, string path) : base(name, path)
    {
        sprite = Raylib.LoadTexture(path);
    }

    public void Load(Vector3 position, Vector3 scale)
    {
        Raylib.DrawTexture(sprite, (int)position.X, (int)position.Y, Color.WHITE);
        // LoadInternal(texture2D);
    }

    public void Load(Vector3 position)
    {
        Raylib.DrawTextureEx(sprite, new Vector2(position.X, position.Y), 0, 1f, Color.WHITE);
        // LoadInternal(texture2D);
    }

    public void Load(Vector3 position, Vector3 rotation, Vector3 scale, Color tint)
    {
        Raylib.DrawTextureEx(sprite, new Vector2(position.X, position.Y), rotation.X, scale.X, tint);
        // LoadInternal(texture2D);
    }

    // private void LoadInternal(Texture2D texture)
    // {
        
    // }
}