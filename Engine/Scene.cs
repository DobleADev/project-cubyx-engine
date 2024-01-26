

using System.Numerics;

public class Scene : IDisposable
{
    public string Name {get; set;}
    private int _buildIndex;
    public int BuildIndex
    {
        get { return _buildIndex; }
        set {_buildIndex = value; }
    }
    public List<GameObject> GameObjects = new List<GameObject>();
    private bool _loaded = false;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Scene(){}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public Scene(string name)
    {
        Name = name;
    }

    public void Load()
    {
        if (_loaded == true)
        {
            Console.WriteLine($"The scene {Name} is already loaded! - rollback");
            return;
        }
        Console.WriteLine($"Opening scene {Name}...");
        // GameObjects = gameObjects;
        foreach(GameObject gameObject in GameObjects)
        {
            gameObject.Initialize();
        }
        _loaded = true;
    }
    
    public void CreateGameObject(GameObject gameObject)
    {
        if (_loaded) gameObject.Initialize();
        GameObjects.Add(gameObject);
    }

    public void CreateGameObject(GameObject gameObject, Vector2 position)
    {
        gameObject.transform.position = position;
        if (_loaded) gameObject.Initialize();
        GameObjects.Add(gameObject);
    }

    public void DeleteGameObject(GameObject gameObject)
    {
        GameObjects.Remove(gameObject);
    }

    public void Dispose()
    {
        foreach(GameObject gameObject in GameObjects)
        {
            gameObject.Destroy();
        }
        //throw new NotImplementedException();
        Console.WriteLine($"Scene \"{Name}\" cleaned from memory.");
    }
}