
using System.Text.Json.Serialization;
using Game;

namespace engine
{
    public class Component : Object, IDisposable, IGameEvents
    {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public GameObject gameObject {get; set;}
        public Transform transform {get; set;}
        protected GameEvent localGameEvents {get; set;}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [JsonIgnore]
        public bool Enabled
        {
            get
            {
                return _internalEnabled;
            }

            set
            {
                _internalEnabled = value;
                if (value == true) 
                {
                    OnEnable();
                }
                else
                {
                    OnDisable();
                }
            }
        }

        protected bool _internalEnabled = true;
        public bool IsEnabled() => _internalEnabled;

        public void DontDestroyOnLoad()
        {
            gameObject.SetPersistent(true);
        }

        public void Initialize(GameObject gameObject, Transform transform, GameEvent localGameEvents)
        {
            this.gameObject = gameObject;
            this.transform = transform;
            this.localGameEvents = localGameEvents;
            Create();
        }

        protected virtual void OnEnable(){}
        protected virtual void OnDisable(){}
        protected virtual void Start(){}
        protected virtual void Update(){}
        protected virtual void OnDestroy(){}
        protected virtual void LateUpdate(){}
        protected virtual void Draw(){}

        public override void Create()
        {
            Program.GlobalGameEvents.OnUpdate += localGameEvents.Update;
            Program.GlobalGameEvents.OnLateUpdate += localGameEvents.LateUpdate;
            Program.GlobalGameEvents.OnDraw += localGameEvents.Draw;

            Start();
            InternalEnable();
        }

        public override void Destroy()
        {
            // if (this.IsPersistent() == true) return;
            InternalDisable();
            Dispose();
            OnDestroy();

            Program.GlobalGameEvents.OnUpdate -= localGameEvents.Update;
            Program.GlobalGameEvents.OnLateUpdate -= localGameEvents.LateUpdate;
            Program.GlobalGameEvents.OnDraw -= localGameEvents.Draw;
        }

        public void InternalEnable()
        {
            localGameEvents.OnUpdate += Update;
            localGameEvents.OnLateUpdate += LateUpdate;
            localGameEvents.OnDraw += Draw;
            OnEnable();
        }

        public void InternalDisable()
        {
            localGameEvents.OnUpdate -= Update;
            localGameEvents.OnLateUpdate -= LateUpdate;
            localGameEvents.OnDraw -= Draw;
            OnDisable();
        }

        public virtual void Dispose()
        {
            Console.WriteLine($"Component cleaned from memory.");
        }
    }
}

interface IGameEvents
{
    void InternalEnable();
    void InternalDisable();
    // public void InternalStart();
    // public void InternalUpdate();
    // public void InternalOnDestroy();
    // public void InternalLateUpdate();
    // public void InternalDraw();
}