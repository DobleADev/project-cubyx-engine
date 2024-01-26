using engine;

public class GameObject : Object, IDisposable
{
    public string Name = "New Object";
    //public string tag;
    private bool _active = true;
    public Transform transform;
    public List<Component> components = new List<Component>();

    public GameObject() 
    {
        InternalInstansiate();
    }

    public GameObject(string name) 
    {
        Name = name;
        InternalInstansiate();
    }

    private void InternalInstansiate()
    {
        transform = new Transform(this);
    }
    public void SetPersistent(bool persistent)
    {
        _persistent = persistent;
    }

    public T? GetComponent<T>() where T : Component
    {
        T? componentToLookFor = null;
        foreach (var component in components)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (component.GetType() == componentToLookFor.GetType()) return (T)component;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        return null;
    }

    public void Initialize()
    {
        foreach(Component component in components)
        {
            if (component.IsEnabled()) 
            {
                component.Initialize(this, transform, new GameEvent());
            }
        }
    }

    public void AddComponent(MonoBehaviour component)
    {
        components.Add(component);
    }

    public void AddComponent<T>() where T : Component, new()
    {
        components.Add(new T());
    }

    public void SetActive(bool setActive)
    {
        _active = setActive;
    }

    public override void Create()
    {
        //throw new NotImplementedException();
    }

    public override void Destroy()
    {
        if (IsPersistent() == true) return;
        Dispose();
    }

    public void Dispose()
    {
        foreach(Component component in components)
        {
            component.Destroy();
        }
        Console.WriteLine($"GameObject \"{Name}\" cleaned from memory.");
    }
}