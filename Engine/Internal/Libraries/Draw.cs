using Raylib_cs;

public static class Draw
{
    private static Color defaultDrawColor = Color.BLACK;
    public static void SetColor(int size) { defaultTextSize = size; }
    public static int GetDefaultColor() { return defaultTextSize; }

    private static int defaultTextSize = 14;
    public static void SetTextSize(int size) { defaultTextSize = size; }
    public static int GetDefaultTextSize() { return defaultTextSize; }
    
    // Draw.Text methods
    public static void Text(int x, int y, string text) { Raylib.DrawText(text, x, y, defaultTextSize, defaultDrawColor); } // TEXT (x, y, text)
    public static void Text(float x, float y, string text)
    {
        int text_x = (int) MathF.Round(x);
        int text_y = (int) MathF.Round(y);
        Raylib.DrawText(text, text_x, text_y, defaultTextSize, defaultDrawColor);
    }
    public static void Text(int x, int y, string text, int size) { Raylib.DrawText(text, x, y, size, defaultDrawColor); } // TEXT (x, y, text, size)
    public static void Text(float x, float y, string text, int size)
    {
        int text_x = (int) MathF.Round(x);
        int text_y = (int) MathF.Round(y);
        Raylib.DrawText(text, text_x, text_y, size, defaultDrawColor);
    }
    public static void Text(int x, int y, string text, int size, Color textColor) { Raylib.DrawText(text, x, y, size, textColor); } // TEXT (x, y, text, size, color)
    public static void Text(float x, float y, string text, int size, Color textColor)
    {
        int text_x = (int) MathF.Round(x);
        int text_y = (int) MathF.Round(y);
        Raylib.DrawText(text, text_x, text_y, size, textColor);
    }
    public static void Text(int x, int y, string text, Color textColor) { Raylib.DrawText(text, x, y, defaultTextSize, textColor); } // TEXT (x, y, text, color)
    public static void Text(float x, float y, string text, Color textColor)
    {
        int text_x = (int) MathF.Round(x);
        int text_y = (int) MathF.Round(y);
        Raylib.DrawText(text, text_x, text_y, defaultTextSize, textColor);
    }

    // Draw.Rectangle methods
    public static void Rectangle(int x, int y, int width, int height) { Raylib.DrawRectangle(x, y, width, height, defaultDrawColor); } // Rectangle (x, y, width, height)
    public static void Rectangle(int x, int y, int width, int height, Color rectangleColor) { Raylib.DrawRectangle(x, y, width, height, rectangleColor); } // Rectangle (x, y, width, height, color)


}
