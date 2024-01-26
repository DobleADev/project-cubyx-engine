using System.Numerics;
using engine;

public class Transform : Component
{
    public Transform(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }
    GameObject gameObject;
    public Vector2 position = Vector2.Zero;
    public float rotation = 0;
    public Vector2 scale = Vector2.One;

    public Vector2 localPosition = Vector2.Zero;
    public float localRotation = 0;
    public Vector2 localScale = Vector2.One;
}

