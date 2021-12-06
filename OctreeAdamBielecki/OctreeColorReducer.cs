using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace OctreeAdamBielecki
{
    public abstract class OctreeColorReducer
    {
        abstract protected Octree ConstructAndReduceOctree(BitmapManager bitmapManager, int colorNumber);
        public Bitmap ReduceBitmap(Bitmap bitmap, int colorNumber)
        {
            BitmapManager bitmapManager = new LockBitmap();
            bitmapManager.GetAccess(bitmap);

            Bitmap reducedBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            BitmapManager reducedBitmapManager = new LockBitmap();
            reducedBitmapManager.GetAccess(reducedBitmap);

            Octree octree = ConstructAndReduceOctree(bitmapManager, colorNumber);

            fillReducedBitmap(octree, bitmapManager, reducedBitmapManager); ;

            bitmapManager.Release();
            reducedBitmapManager.Release();
            return reducedBitmap;
        }

        private void fillReducedBitmap(Octree octree, BitmapManager bitmapManager, BitmapManager reducedBitmapManager)
        {
            for (int y = 0; y < bitmapManager.Height; y++)
            {
                for (int x = 0; x < bitmapManager.Width; x++)
                {
                    reducedBitmapManager.SetPixel(x, y,
                        octree.FindColor(bitmapManager.GetPixel(x, y)));
                }
            }
        }
    }
}
