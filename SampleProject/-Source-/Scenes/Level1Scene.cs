﻿using N8Engine;
using N8Engine.Mathematics;
using N8Engine.SceneManagement;
using N8Engine.Tilemaps;

namespace SampleProject
{
    public sealed class Level1Scene : Scene
    {
        protected override void OnSceneLoaded()
        {
            GameObject.Create<Player>("player").Transform.Position = new Vector(-250f, 30f);
            AutoTilemap<EmptyWall, RightWall, EmptyWall, BottomWall, RightWall, EmptyWall, BottomRightWall, EmptyWall, EmptyWall>
                .Place(new Vector(-340f, 50f), new Vector(8, 3), new Vector(24f, 12f), TilePivot.BottomLeft);
        }
    }
}