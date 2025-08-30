using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Math
{
    public readonly struct Vector2Int(int x, int y) : IEquatable<Vector2Int>
    {
        public int X { get; } = x;
        public int Y { get; } = y;

        public static Vector2Int Up = new(0, 1);
        public static Vector2Int Down = new(0, -1);
        public static Vector2Int Left = new(-1, 0);
        public static Vector2Int Right = new(1, 0);

        public override string ToString() => $"{X},{Y}";

        public override int GetHashCode() => HashCode.Combine(X, Y);
        public override bool Equals(object? obj) => obj is Vector2Int other && Equals(other);
        public bool Equals(Vector2Int other) => X == other.X && Y == other.Y;

        public static Vector2Int operator /(Vector2Int a, int b) => new Vector2Int(a.X / b, a.Y / b);
        public static Vector2Int operator -(Vector2Int v) => new Vector2Int(-v.X, -v.Y);
        public static Vector2Int operator +(Vector2Int a, Vector2Int b) => new Vector2Int(a.X + b.X, a.Y + b.Y);
        public static Vector2Int operator -(Vector2Int a, Vector2Int b) => new Vector2Int(a.X - b.X, a.Y - b.Y);
        public static Vector2Int operator *(Vector2Int a, Vector2Int b) => new Vector2Int(a.X * b.X, a.Y * b.Y);
        public static Vector2Int operator *(int a, Vector2Int b) => new Vector2Int(a * b.X, a * b.Y);
        public static Vector2Int operator *(Vector2Int a, int b) => new Vector2Int(a.X * b, a.Y * b);

        public static bool operator ==(Vector2Int left, Vector2Int right) => left.Equals(right);
        public static bool operator !=(Vector2Int left, Vector2Int right) => !left.Equals(right);

        public static Vector2Int Parse(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                throw new FormatException("Input cannot be null or empty.");

            var parts = s.Split(',');
            if (parts.Length != 2)
                throw new FormatException($"Failed at parsing '{s}'. Must be in format 'X,Y'.");

            if (!int.TryParse(parts[0], out var x) || !int.TryParse(parts[1], out var y))
                throw new FormatException($"Failed at parsing '{s}'. Must be in format 'X,Y' with valid integers.");

            return new Vector2Int(x, y);
        }
    }
}
