﻿using N8Engine;
using N8Engine.Mathematics;
using N8Engine.Physics;
using N8Engine.Rendering;
using N8Engine.SceneManagement;
using N8Engine.Tilemaps;
using N8Engine.Inputs;

namespace SampleProject
{
    public sealed class Level1 : Scene
    {
        protected override void OnSceneLoaded()
        {
            var tilemap = new AutoTilemap<FullPalette>();
            tilemap.Place(Vector.Zero, new IntegerVector(10, 4), Pivot.Center);

            GameObject.Create<Player>("player").Transform.Position = Vector.Up * 50f;
            // GameObject.Create<Door>("door").Transform.Position += new Vector(252f, -39f);
            // GameObject.Create<DoorKey>("key");
            // GameObject.Create<Line>("line").MakeColor("White")
            //     .Copy(Vector.Up * 10f)
            //     .Copy(Vector.Down * 10f)
            //     .Copy(Vector.Up * 20f)
            //     .Copy(Vector.Down * 20f)
            //     .Copy(Vector.Up * 30f)
            //     .Copy(Vector.Down * 30f)
            //     .Copy(Vector.Up * 40f)
            //     .Copy(Vector.Down * 40f)
            //     .Copy(Vector.Up * 50f)
            //     .Copy(Vector.Down * 50f)
            //     ;
            PhysicsSettings.ShouldShowAllColliders = true;
        }
    }
}