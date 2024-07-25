using Raylib_cs;
using static Raylib_cs.Raylib;
public class SceneGameplay : Scene
{
    public SceneGameplay()
    {
        nbScenes++;
    }
    public override void Draw()
    {
        DrawText("Bonjour Je suis le GAmeplay", 5, 5, 35, Color.Black);
        base.Draw();
    }

    public override void Update()
    {
        if (IsKeyPressed(KeyboardKey.M))
        {
            GameState.Instance.ChangeScene("menu");
        }
        base.Update();
    }
}