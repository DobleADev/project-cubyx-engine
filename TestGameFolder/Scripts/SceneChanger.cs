using Engine;
using Raylib_cs;

public class SceneChanger : MonoBehaviour
{
    protected override void Start()
    {
        Console.WriteLine("SCENE CHANGER START");
        Raylib.SetWindowTitle(SceneManager.GetCurrentScene().Name);
    }

    protected override void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE)) 
        {
            SceneManager.LoadScene(0);
            Change();
        }

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
        {
            SceneManager.LoadScene(1);
            Change();
        }
        
    }

    public void Change()
    {
        Console.WriteLine("Scene changed!");
        //Raylib.SetWindowTitle(SceneManager.GetCurrentScene().Name);
    }
}