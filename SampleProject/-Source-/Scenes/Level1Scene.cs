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
                .PlaceChunk(Window.BottomLeftCorner + Vector.Left * 24f, new IntegerVector(10, 3), TilePivot.BottomLeft);
            door.Transform.Position += new Vector(252f, -39f);
        }
    }
}