using Raylib_cs;

public class Rotate : MonoBehaviour
{
    protected override void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_R))
        {
            transform.rotation += 200f * Raylib.GetFrameTime();
        }
    }
}