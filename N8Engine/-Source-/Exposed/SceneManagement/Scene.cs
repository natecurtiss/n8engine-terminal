﻿using System.Collections;
using System.Collections.Generic;

namespace N8Engine.SceneManagement
{
    public abstract class Scene
    {
        // readonly List<GameObject> _gameObjects = new();

        public abstract string Name { get; }
        public int Index { get; internal set; }
        
        // public IEnumerator<GameObject> GetEnumerator() => _gameObjects.GetEnumerator();
        // IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        // 
        // public void Add(GameObject gameObject) => _gameObjects.Add(gameObject);
        // public void Remove(GameObject gameObject) => _gameObjects.Remove(gameObject);

        // internal void Load() => OnSceneLoaded();

        // internal void Unload()
        // {
        //     foreach (var gameObject in _gameObjects.ToArray()) 
        //         gameObject.Destroy();
        // }
        // 
        // protected abstract void OnSceneLoaded();
    }
}