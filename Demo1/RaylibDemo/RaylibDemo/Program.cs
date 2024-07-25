using Raylib_cs;
using static Raylib_cs.Raylib;

public class RaylibGame
{
    public static int Main()
    {
        InitWindow(800, 600, "Demo Raylib 1");

        while(!WindowShouldClose())
        {
            BeginDrawing();
            ClearBackground(Color.White);
            EndDrawing();
        }

        CloseWindow();

        return 0;
    }
}