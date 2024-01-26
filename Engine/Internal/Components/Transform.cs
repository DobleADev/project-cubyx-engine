using System.Numerics;
using engine;

public class Transform : Component
{
    public Transform(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }
    GameObject gameObject;
    public Vector3 position = Vector3.Zero;
    public Vector3 rotation = Vector3.Zero;
    public Vector3 scale = Vector3.One;

    public Vector3 localPosition = Vector3.Zero;
    public Vector3 localRotation = Vector3.Zero;
    public Vector3 localScale = Vector3.One;
}

