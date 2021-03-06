using System;

namespace N8Engine.Mathematics
{
    public struct Vector : IEquatable<Vector>
    {
        public static bool operator ==(Vector first, Vector second) => first.Equals(second);
        public static bool operator !=(Vector first, Vector second) => !(first == second);
        public static Vector operator +(Vector first, Vector second) => new(first.X + second.X, first.Y + second.Y);
        public static Vector operator +(Vector first, IntVector second) => new(first.X + second.X, first.Y + second.Y);
        public static Vector operator +(IntVector first, Vector second) => new(first.X + second.X, first.Y + second.Y);
        public static Vector operator +(Vector vector) => vector;
        public static Vector operator -(Vector first, Vector second) => new(first.X - second.X, first.Y - second.Y);
        public static Vector operator -(Vector first, IntVector second) => new(first.X - second.X, first.Y - second.Y);
        public static Vector operator -(IntVector first, Vector second) => new(first.X - second.X, first.Y - second.Y);
        public static Vector operator -(Vector vector) => new(-vector.X, -vector.Y);
        public static Vector operator *(Vector vector, float multiplier) => new(vector.X * multiplier, vector.Y * multiplier);
        public static Vector operator *(float multiplier, Vector vector) => new(vector.X * multiplier, vector.Y * multiplier);
        public static Vector operator *(Vector first, Vector second) => new(first.X * second.X, first.Y * second.Y);
        public static Vector operator *(Vector first, IntVector second) => new(first.X * second.X, first.Y * second.Y);
        public static Vector operator *(IntVector first, Vector second) => new(first.X * second.X, first.Y * second.Y);
        public static Vector operator /(Vector vector, float divisor) => new(vector.X / divisor, vector.Y / divisor);
        public static Vector operator /(Vector first, Vector second) => new(first.X / second.X, first.Y / second.Y);
        public static Vector operator /(Vector first, IntVector second) => new(first.X / second.X, first.Y / second.Y);
        public static Vector operator /(IntVector first, Vector second) => new(first.X / second.X, first.Y / second.Y);
        public static implicit operator Vector(IntVector intVector) => new(intVector.X, intVector.Y);

        public static readonly Vector Zero = new();
        public static readonly Vector One = new(1f);
        public static readonly Vector Up = new(0f, 1f);
        public static readonly Vector Down = new(0f, -1f);
        public static readonly Vector Left = new(-1f, 0f);
        public static readonly Vector Right = new(1f, 0f);

        readonly float _x;
        readonly float _y;

        public float X
        {
            get => _x;
            set => this = new Vector(value, _y);
        }
        public float Y
        {
            get => _y;
            set => this = new Vector(_x, value);
        }

        public Vector(float both)
        {
            _x = both;
            _y = both;
        }

        public Vector(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public override bool Equals(object obj) => obj is Vector other && Equals(other);
        public override int GetHashCode() => HashCode.Combine(X, Y);
        public override string ToString() => $"({X.ToString()},{Y.ToString()})";
        public bool Equals(Vector other) => X.Equals(other.X) && Y.Equals(other.Y);
    }
}