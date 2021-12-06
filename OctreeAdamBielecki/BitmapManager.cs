using System.Drawing;

namespace OctreeAdamBielecki
{
    public abstract class BitmapManager
    {
        public abstract void SetPixel(int x, int y, Color color);
        public abstract Color GetPixel(int x, int y);
        public abstract void GetAccess(Bitmap managedBitmap);
        public abstract void Release();
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
