using Raylib_cs;

namespace Game
{
    public static class Program
    {
        public static Color CurrentBackgroundColor = Color.BLACK;
        public static GameEvent GlobalGameEvents = new GameEvent();

        public static void Main()
        {
            Raylib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
            Raylib.InitWindow(800, 480, "Hello World");
            Raylib.SetWindowMinSize(800,480); // Set window minimum dimensions (for FLAG_WINDOW_RESIZABLE)
            Raylib.SetExitKey(KeyboardKey.KEY_NULL);

            GodTest.InitializeGame();

            //GameEvents.Start();
            while (!Raylib.WindowShouldClose())
            {
                GlobalGameEvents.Update();
                //Raylib.SetWindowTitle(SceneManager.GetCurrentScene().Name);
                GlobalGameEvents.LateUpdate();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(CurrentBackgroundColor);

                GlobalGameEvents.Draw();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }

    
}