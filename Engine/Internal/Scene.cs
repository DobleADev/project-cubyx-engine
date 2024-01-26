using System.Numerics;
using Engine;
using Newtonsoft.Json;

public class Scene : Asset, IDisposable
{
    private int _buildIndex;
    [JsonIgnore]
    public int BuildIndex
    {
        get { return _buildIndex; }
        set {_buildIndex = value; }
    }
    public List<GameObject> GameObjects = new List<GameObject>();
    private bool _loaded = false;

    public Scene()
    {
    }
    public Scene(string name, string folderPath, List<GameObject> GameObjects) : base(name, folderPath)
    {
    }

    public Scene(string name, string folderPath) : base(name, folderPath)
    {
    }

    public Scene(string folderPath) : base(folderPath)
    {
    }

    public void SaveChanges()
    {
        SceneManager.CreateScene(this);
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
    
    public void AddGameObject(GameObject gameObject)
    {
        if (_loaded) gameObject.Initialize();
        GameObjects.Add(gameObject);
    }

    public void AddGameObject(GameObject gameObject, Vector3 position)
    {
        gameObject.transform.position = position;
        if (_loaded) gameObject.Initialize();
        GameObjects.Add(gameObject);
    }

    public void RemoveGameObject(GameObject gameObject)
    {
        GameObjects.Remove(gameObject);
    }

    public void Dispose()
    {
        foreach(GameObject gameObject in GameObjects)
        {
            gameObject.Destroy();
        }
        //Console.WriteLine($"Scene \"{Name}\" cleaned from memory.");
    }
}