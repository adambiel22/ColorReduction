using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace OctreeAdamBielecki
{
    public class OctreeNode : IComparable<OctreeNode>
    {
        public OctreeNode[] NextNodes { get; private set; }
        public int ReferenceCounter { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Level { get; private set; }

        public OctreeNode(int level)
        {
            NextNodes = new OctreeNode[8];
            ReferenceCounter = 0;
            Level = level;
        }

        public bool IsLeaf()
        {
            return NextNodes.All((nextNode) => nextNode == null);
        }

        public bool IsParentOfLeaves()
        {
            return !IsLeaf() && NextNodes.All((nextNode) => nextNode == null || nextNode.IsLeaf());
        }

        public int CompareTo(OctreeNode other)
        {
            if (Red == 0 && Green == 128 && Blue == 128 && ReferenceCounter == 6)
            {
                Debug.WriteLine(this);
            }
            if (this.ReferenceCounter - other.ReferenceCounter != 0)
            {
                return this.ReferenceCounter - other.ReferenceCounter;
            }
            else if (this.Red - other.Red != 0)
            {
                return this.Red - other.Red;
            }
            else if (this.Green - other.Green != 0)
            {
                return this.Green - other.Green;
            }
            else
            {
                return this.Blue - other.Blue;
            }
        }
        public Color ToColor()
        {
            return Color.FromArgb(255, Red, Green, Blue);
        }
        public override string ToString()
        {
            return $"[{Level}]({Convert.ToString(Red, 10)}, " +
                $"{Convert.ToString(Green, 10)}, " +
                $"{Convert.ToString(Blue, 10)})*{ReferenceCounter}";
        }
        public int ChildrenNumber()
        {
            return NextNodes.Count((child) => child != null);
        }
    }
}
