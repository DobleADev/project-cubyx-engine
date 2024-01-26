public class GameEvent
{
    public event Action? OnUpdate;
    public event Action? OnLateUpdate;
    public event Action? OnDraw;

    public void Update() => OnUpdate?.Invoke();
    public void LateUpdate() => OnLateUpdate?.Invoke();
    public void Draw() => OnDraw?.Invoke();
}
