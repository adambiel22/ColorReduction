using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace OctreeAdamBielecki
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Octree octree = new Octree();
            //octree.AddColor(Color.FromArgb(255, 237, 28, 36));
            //Debug.WriteLine(octree);
            //octree.AddColor(Color.FromArgb(255, 255, 127, 39));
            //Debug.WriteLine(octree);
            //octree.AddColor(Color.FromArgb(255, 255, 174, 201));
            //octree.Reduce(3);
            //octree.AddColor(Color.FromArgb(255, 185, 122, 87));
            //octree.Reduce(3);
            //Debug.WriteLine(octree);

            //Debug.WriteLine(octree);

            //Debug.WriteLine(octree.FindColor(Color.FromArgb(255, 237, 28, 36)));
            //Debug.WriteLine(octree.FindColor(Color.FromArgb(255, 255, 127, 39)));
            //Debug.WriteLine(octree.FindColor(Color.FromArgb(255, 185, 122, 87)));
            //Debug.WriteLine(octree.FindColor(Color.FromArgb(255, 255, 174, 201)));

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
