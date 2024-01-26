using Raylib_cs;

public class SpriteRenderer : MonoBehaviour
{
    public Sprite sprite;
    public Color color = Color.WHITE;

    protected override void Draw()
    {
        //Raylib.DrawTexture(ref Sprite, Color);
        sprite.Load(transform.position, transform.rotation, transform.scale, color);
    }
}