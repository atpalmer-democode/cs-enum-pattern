using System;

namespace Enumerations
{
    public sealed class Color
    {
        public static readonly Color Blue = new Color("blue");
        public static readonly Color Red = new Color("red");
        public static readonly Color Green = new Color("green");

        private readonly string colorName;

        private Color(string colorName)
        {
            this.colorName = colorName;
        }

        public override string ToString()
        {
            return this.colorName;
        }

        public override int GetHashCode()
        {
            return this.colorName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return object.ReferenceEquals(this, obj);
        }
    }
}
