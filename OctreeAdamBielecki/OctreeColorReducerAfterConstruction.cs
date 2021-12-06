using System.Windows.Forms;

namespace OctreeAdamBielecki
{
    class OctreeColorReducerAfterConstruction : OctreeColorReducer
    {
        public OctreeColorReducerAfterConstruction(ProgressBar progressBar) : base(progressBar)
        { }

        protected override Octree ConstructAndReduceOctree(BitmapManager bitmapManager, int colorNumber)
        {
            Octree colorReducer = new Octree();
            for (int y = 0; y < bitmapManager.Height; y++)
            {
                for (int x = 0; x < bitmapManager.Width; x++)
                {
                    colorReducer.AddColor(bitmapManager.GetPixel(x, y));
                }
                progressBar.PerformStep();
            }
            colorReducer.Reduce(colorNumber);
            return colorReducer;
        }
    }
}
