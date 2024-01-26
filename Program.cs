using Raylib_cs;

namespace Game
{
    public static class Program
    {
        // TEMP clear screen color
        public static Color CurrentBackgroundColor = Color.BLACK; 
        public static GameEvent GlobalGameEvents = new GameEvent();

        public static void Main()
        {
            Raylib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
            Raylib.InitWindow(800, 480, "Hello World");
            Raylib.SetWindowMinSize(800,480); // Set window minimum dimensions (for FLAG_WINDOW_RESIZABLE)
            Raylib.SetExitKey(KeyboardKey.KEY_NULL);

            // Init from here
            // {
                    EngineTest.Initialize();
            // }

            while (!Raylib.WindowShouldClose()) // Main gameloop
            {
                GlobalGameEvents.Update();
                GlobalGameEvents.LateUpdate();

                Raylib.BeginDrawing();

                // Posible change if camera system is made...
                Raylib.ClearBackground(CurrentBackgroundColor);

                GlobalGameEvents.Draw();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }

    
}