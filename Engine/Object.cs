public abstract class Object
{
    public string id;
    private int objectCount;

    protected bool _persistent = false;
    public bool IsPersistent() => _persistent;

    public Object()
    {
        id = (++objectCount).ToString();
    }

    public abstract void Create();
    public abstract void Destroy();
}