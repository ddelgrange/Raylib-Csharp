using Raylib_cs;
using static Raylib_cs.Raylib;
public class SceneMenu : Scene
{
    public SceneMenu()
    {
        nbScenes++;
    }
    public override void Draw()
    {
        DrawText("Bonjour Je suis le menu", 5, 5, 35, Color.Black);
        base.Draw();
    }

    public override void Update()
    {
        if (IsKeyPressed(KeyboardKey.Space))
        {
            GameState.Instance.ChangeScene("Gameplay");
        }
        base.Update();
    }
}