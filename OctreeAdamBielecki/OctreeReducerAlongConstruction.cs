﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctreeAdamBielecki
{
    class OctreeReducerAlongConstruction : OctreeColorReducer
    {
        public override Octree ConstructAndReduceOctree(BitmapManager bitmapManager, int colorNumber)
        {
            Octree colorReducer = new Octree();
            for (int y = 0; y < bitmapManager.Height; y++)
            {
                for (int x = 0; x < bitmapManager.Width; x++)
                {
                    colorReducer.AddColor(bitmapManager.GetPixel(x, y));
                    if (colorReducer.ColorNumber > colorNumber)
                    {
                        colorReducer.Reduce(colorNumber);
                    }
                }
            }
            return colorReducer;
        }
    }
}
