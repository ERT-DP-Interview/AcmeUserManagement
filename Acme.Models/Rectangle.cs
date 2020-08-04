using System.Xml.Linq;

namespace Acme.Models
{
    public class Rectangle
    {
        protected int Width;

        protected int Height;

        public int Left { get; set; }

        public int Top { get; set; }

        public virtual void SetWidth(int w)
        {
            Width = w;
        }

        public virtual void SetHeight(int h)
        {
            Height = h;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetHeight()
        {
            return Height;
        }

        public void IncreaseWidth(int amount)
        {
            Width += amount;
        }

        public void IncreaseHeight(int amount)
        {
            Height += amount;
        }
    }
}
