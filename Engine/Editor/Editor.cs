public static class Application
{
    public static bool Quit = false;

    public static string DataPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + "\\Assets\\";

}
