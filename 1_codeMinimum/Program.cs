using Raylib_cs;
using static Raylib_cs.Raylib;

public static class Program
{
    static SceneMenu sceneMenu = new SceneMenu();
    static SceneGameplay sceneGameplay = new SceneGameplay();
    static Scene? sceneCourante;


    public static void Main()
    {
        InitWindow(800, 600, "Code minimum");
        SetTargetFPS(60);
        InitAudioDevice();
        SetExitKey(KeyboardKey.Q);
        SetExitKey(KeyboardKey.A);

        sceneCourante = sceneMenu;

        while (!WindowShouldClose())
        {
            if (IsKeyPressed(KeyboardKey.G))
            {
                sceneCourante = sceneGameplay;
            }
            sceneCourante.Update();
            
            BeginDrawing();
            ClearBackground(Color.RayWhite);

            //notre code
            //sceneMenu.Draw();
            sceneCourante.Draw();



            EndDrawing();
        }

        CloseAudioDevice();
        CloseWindow();
    }
}