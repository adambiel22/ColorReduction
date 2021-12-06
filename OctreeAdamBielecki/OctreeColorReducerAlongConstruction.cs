using System.Windows.Forms;

namespace OctreeAdamBielecki
{
    class OctreeColorReducerAlongConstruction : OctreeColorReducer
    {
        public OctreeColorReducerAlongConstruction(ProgressBar progressBar) : base(progressBar)
        { }

        protected override Octree ConstructAndReduceOctree(BitmapManager bitmapManager, int colorNumber)
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
                progressBar.PerformStep();
            }
            return colorReducer;
        }
    }
}
