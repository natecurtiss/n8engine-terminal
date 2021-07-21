﻿using N8Engine.Mathematics;

namespace N8Engine.Physics
{
    internal struct Rectangle
    { 
        public Vector Position { get; set; }
        public Vector Size { get; set; }
        public Vector Extents => Size / 2f;
        public Vector Left => Vector.Left * Extents.X + Position;
        public Vector Right => Vector.Right * Extents.X + Position;
        public Vector Top => Vector.Up * Extents.Y + Position;
        public Vector Bottom => Vector.Down * Extents.Y + Position;
        
        private Vector TopLeft => Vector.Up * Extents.Y + Vector.Left * Extents.X + Position;
        private Vector BottomRight => Vector.Down * Extents.Y + Vector.Right * Extents.X + Position;

        public Rectangle(Vector size, Vector position = default)
        {
            Size = size;
            Position = position;
        }
        
        public bool IsPositionInside(Vector otherPosition) => 
            otherPosition.X.IsWithinRange(Left.X, Right.X) && 
            otherPosition.Y.IsWithinRange(Bottom.Y, Top.Y);

        public bool IsOverlapping(Rectangle otherRectangle)
        {
            var oneRectangleIsToTheRightOfTheOtherRectangle = TopLeft.X >= otherRectangle.BottomRight.X || otherRectangle.TopLeft.X >= BottomRight.X;
            if (oneRectangleIsToTheRightOfTheOtherRectangle)
                return false;
            var oneRectangleIsOnTopOfTheOtherRectangle = BottomRight.Y >= otherRectangle.TopLeft.Y || otherRectangle.BottomRight.Y >= TopLeft.Y;
            if (oneRectangleIsOnTopOfTheOtherRectangle)
                return false;
            return true;
        }
    }
}