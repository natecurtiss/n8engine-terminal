﻿using N8Engine.Mathematics;
using N8Engine.Rendering;
using N8Engine.Tilemaps;

namespace SampleProject
{
    public sealed class Level1Scene : LevelSceneBase
    {
        protected override void OnLevelLoaded(Door door, DoorKey key)
        {
            AutoTilemap<TopAndSidesPalette>.Generator
                .Place(Window.BottomLeftCorner + Vector.Left * 24f, new Vector(10, 3), TilePivot.BottomLeft)
                .Place(Window.BottomLeftCorner + Vector.Left * 24f + Vector.Right * 330f, new Vector(10, 3), TilePivot.BottomLeft);
            door.Transform.Position += new Vector(252f, 39f);
        }
    }
}