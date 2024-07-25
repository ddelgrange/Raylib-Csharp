public class GameState
{
    private Scene? currentScene;

    private static GameState? instance;

    public static GameState Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameState();
            }
            return instance;
        }
    }

    public void ChangeScene(string id)
    {
        /// currentScene = ???
        Console.WriteLine("Change scene vers " + id);
    }
}