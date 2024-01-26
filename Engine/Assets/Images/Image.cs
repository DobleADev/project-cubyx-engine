using System.Numerics;
using Raylib_cs;

public class Image : Asset
{
    public Raylib_cs.Image image {get; set;}
    public Image(string path, string name = "New Image") : base(path, name)
    {
        image = Raylib.LoadImage(path);
    }

    public void Load(Vector2 position, Vector2 scale)
    {
        //Raylib.ImageDrawRectangle(_image, (int)position.x, (int)position.y, _image.width, _image.height, Color.BLANK);
        // throw new NotImplementedException();
    }
}