using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OctreeAdamBielecki
{
    public interface IColorReducer
    {
        public int ColorNumber { get; }
        public void AddColor(Color color);
        public Color FindColor(Color color);
        public void Reduce(int k);
    }
}
