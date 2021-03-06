using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace OctreeAdamBielecki
{
    class PopularityColorReducer
    {
        private int[,,] colorPallete;
        private List<(int, Color)>[] reducedPalete;
        protected ProgressBar progressBar;
        public PopularityColorReducer(ProgressBar progressBar)
        {
            colorPallete = new int[256, 256, 256];
            reducedPalete = new List<(int, Color)>[8];
            this.progressBar = progressBar;
        }
        public Bitmap ReduceBitmap(Bitmap bitmap, int colorNumber)
        {
            BitmapManager bitmapManager = new LockBitmap();
            bitmapManager.GetAccess(bitmap);

            Bitmap reducedBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            BitmapManager reducedBitmapManager = new LockBitmap();
            reducedBitmapManager.GetAccess(reducedBitmap);

            progressBar.Maximum = 3 * bitmapManager.Height;
            progressBar.Value = 0;
            progressBar.Step = 1;
            //constructPalete
            for (int y = 0; y < bitmapManager.Height; y++)
            {
                for (int x = 0; x < bitmapManager.Width; x++)
                {
                    Color pixel = bitmapManager.GetPixel(x, y);
                    colorPallete[pixel.R, pixel.G, pixel.B]++;
                }
                progressBar.PerformStep();
            }

            Reduce(colorNumber);
            progressBar.Value = 2 * progressBar.Maximum / 3;

            fillReducedBitmap(bitmapManager, reducedBitmapManager);
            progressBar.Value = progressBar.Maximum;

            bitmapManager.Release();
            reducedBitmapManager.Release();
            return reducedBitmap;
        }

        private void fillReducedBitmap(BitmapManager bitmapManager, BitmapManager reducedBitmapManager)
        {
            for (int y = 0; y < bitmapManager.Height; y++)
            {
                for (int x = 0; x < bitmapManager.Width; x++)
                {
                    reducedBitmapManager.SetPixel(x, y,
                        findColor(bitmapManager.GetPixel(x, y)));
                }
                progressBar.PerformStep();
            }
        }

        private void Reduce(int k)
        {
            for (int i = 0; i < 8; i++)
            {
                List<(int, Color)> colorList = new List<(int, Color)>();
                for (int r = 128 * checkBit(i,2); r < 128 + 128 * checkBit(i, 2); r++)
                {
                    for (int g = 128 * checkBit(i, 1); g < 128 + 128 * checkBit(i, 1); g++)
                    {
                        for (int b = 128 * checkBit(i, 0); b < 128 + 128 * checkBit(i, 0); b++)
                        {
                            if (colorPallete[r, g, b] != 0)
                            {
                                colorList.Add((colorPallete[r, g, b],
                                    Color.FromArgb(255, r, g, b)));
                            }
                        }
                    }
                }
                colorList.Sort((e1, e2) => e2.Item1 - e1.Item1);
                if (i < 7)
                {
                    reducedPalete[i] = colorList.Take(k / 8).ToList();
                }
                if (i == 7)
                {
                    reducedPalete[i] = colorList.Take((int)(k - 7 * Math.Floor((double)k / 8))).ToList();
                }
            }
        }

        private Color findColor(Color color)
        {
            double distance = double.MaxValue;
            Color foundColor = Color.White;
            for (int i = 0; i < 8; i++) 
            {
                foreach (var paleteColor in reducedPalete[i])
                {
                    if (colorDistance(color, paleteColor.Item2) < distance)
                    {
                        distance = colorDistance(color, paleteColor.Item2);
                        foundColor = paleteColor.Item2;
                    }
                }
            }
            return foundColor;
        }

        private int checkBit(int number, int bit)
        {
            return ((1 << bit) & number) >> bit;
        }
        
        private double colorDistance(Color color1, Color color2)
        {
            return Math.Sqrt((color1.R - color2.R) * (color1.R - color2.R)
                + (color1.G - color2.G) * (color1.G - color2.G)
                + (color1.B - color2.B) * (color1.B - color2.B)) ;
        }
    }
}
