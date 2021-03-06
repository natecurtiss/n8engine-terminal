using System;

namespace N8Engine
{
    sealed class GameObjectEvents : IModule
    {
        public event Action<Time> OnEarlyUpdate;
        public event Action<Time> OnUpdate;
        public event Action<Time> OnPhysics;
        public event Action<Time> OnLateUpdate;
        public event Action OnRender;
        
        Type IModule.Type => GetType();
        
        void IModule.Initialize() { }
        void IModule.Update(Time time)
        {
            OnEarlyUpdate?.Invoke(time);
            OnUpdate?.Invoke(time);
            OnPhysics?.Invoke(time);
            OnLateUpdate?.Invoke(time);
            OnRender?.Invoke();
        }
    }
}