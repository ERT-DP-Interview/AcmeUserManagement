namespace Acme.Models
{
    public class Square : Rectangle
    {
        public override void SetWidth(int w)
        {
            Width = w;

            Height = w;
        }

        public override void SetHeight(int h)
        {
            Height = h;

            Width = h;
        }
    }
}
