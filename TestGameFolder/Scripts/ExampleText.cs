using System.Numerics;
using Engine;
using Raylib_cs;

public class ExampleText : MonoBehaviour
{
    public string text {get; set;} = "ExampleText";
    public Color color {get; set;} = Color.BLACK;
    public float moveSpeed {get; set;} = 200f;

    protected override void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_F2)) RestartGame();
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_F1)) Application.Quit = true;
        
        Vector2 moveInput;
        moveInput.X = (int)Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) - (int)Raylib.IsKeyDown(KeyboardKey.KEY_LEFT);
        moveInput.Y = (int)Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) - (int)Raylib.IsKeyDown(KeyboardKey.KEY_UP);

        transform.position += new Vector3(moveSpeed * moveInput.X, moveSpeed * moveInput.Y, 0) * Raylib.GetFrameTime();
    }
    
    protected override void Draw() 
    {
        Raylib.DrawText(text, (int)transform.position.X, (int)transform.position.Y, 24, color);
    }

    public void RestartGame()
    {
        // SceneManager.LoadScene(new Scene());
        SceneManager.LoadScene(SceneManager.GetCurrentScene().Name);
    }
}
