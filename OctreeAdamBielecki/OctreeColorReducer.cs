using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace OctreeAdamBielecki
{
    public class OctreeColorReducer
    {
        public IColorReducer colorReducer { get; set; }
        public OctreeColorReducer(IColorReducer colorReducer)
        {
            //this.colorReducer = colorReducer;
        }

        public Bitmap ReduceBitmapAfterConstrution(Bitmap bitmap, int colorNumber)
        {
            Bitmap reducedBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            BitmapManager bitmapManager = new LockBitmap();
            bitmapManager.GetAccess(bitmap);
            BitmapManager reducedBitmapManager = new LockBitmap();
            reducedBitmapManager.GetAccess(reducedBitmap);
            IColorReducer colorReducer = new Octree();

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Debug.WriteLine($"{x}, {y}");
                    colorReducer.AddColor(bitmapManager.GetPixel(x, y));
                    Debug.WriteLine(colorReducer);
                }
            }

            colorReducer.Reduce(colorNumber);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    reducedBitmapManager.SetPixel(x, y,
                        colorReducer.FindColor(bitmapManager.GetPixel(x, y)));
                }
            }

            bitmapManager.Release();
            reducedBitmapManager.Release();

            return reducedBitmap;
        }

        public Bitmap ReduceBitmapAlongConstrution(Bitmap bitmap, int colorNumber)
        {
            Bitmap reducedBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            BitmapManager bitmapManager = new LockBitmap();
            bitmapManager.GetAccess(bitmap);
            BitmapManager reducedBitmapManager = new LockBitmap();
            reducedBitmapManager.GetAccess(reducedBitmap);
            IColorReducer colorReducer = new Octree();

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    colorReducer.AddColor(bitmapManager.GetPixel(x, y));
                    if (colorReducer.ColorNumber > colorNumber)
                    {
                        colorReducer.Reduce(colorNumber);
                        Debug.WriteLine(colorReducer);
                    }
                }
            }

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    reducedBitmapManager.SetPixel(x, y,
                        colorReducer.FindColor(bitmapManager.GetPixel(x, y)));
                }
            }

            bitmapManager.Release();
            reducedBitmapManager.Release();

            return reducedBitmap;
        }
    }
}
