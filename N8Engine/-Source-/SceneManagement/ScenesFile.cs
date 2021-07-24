﻿using System;
using System.IO;
using System.Linq;

namespace N8Engine.SceneManagement
{
    public struct ScenesFile
    {
        private readonly string _path;

        public Scene[] Scenes
        {
            get
            {
                var fileText = File.ReadAllText(_path);
                var eachSceneAsText = fileText.Split('{').ToList();
                for (var index = 0; index < eachSceneAsText.Count; index++) 
                    eachSceneAsText[index] = eachSceneAsText[index].Replace("}", string.Empty);
                eachSceneAsText.RemoveAll(sceneText => sceneText == string.Empty);
                
                var eachSceneAsTextWithDataSplitUp = new string[eachSceneAsText.Count][];
                for (var i = 0; i < eachSceneAsTextWithDataSplitUp.Length; i++) 
                    eachSceneAsTextWithDataSplitUp[i] = eachSceneAsText[i].Split(',');
                for (var scene = 0; scene < eachSceneAsTextWithDataSplitUp.Length; scene++)
                    for (var data = 0; data < eachSceneAsTextWithDataSplitUp[scene].Length; data++)
                    {
                        eachSceneAsTextWithDataSplitUp[scene][data] = eachSceneAsTextWithDataSplitUp[scene][data].Split('"')[1];
                        eachSceneAsTextWithDataSplitUp[scene][data] = eachSceneAsTextWithDataSplitUp[scene][data].Replace(@"""", string.Empty);
                    }

                var scenes = new Scene[eachSceneAsTextWithDataSplitUp.Length];
                for (var i = 0; i < eachSceneAsTextWithDataSplitUp.Length; i++)
                {
                    var type = Type.GetType(eachSceneAsTextWithDataSplitUp[i][0]);
                    var typeException = new InvalidOperationException($"Invalid scene class name in *.scenes file at index {i}!");
                    scenes[i] = Activator.CreateInstance(type ?? throw typeException) as Scene;

                    scenes[i].Name = eachSceneAsTextWithDataSplitUp[i][1];
                    
                    var indexException = new InvalidOperationException($"Invalid scene index value in *.scenes file at index {i}!");
                    if (!int.TryParse(eachSceneAsTextWithDataSplitUp[i][2], out var index))
                        throw indexException;
                    scenes[i].Index = index;
                }

                return scenes;
            }
        }
        
        public ScenesFile(string path) => _path = path;
    }
}