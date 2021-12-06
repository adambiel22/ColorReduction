using System;
using System.Linq;
using System.Drawing;

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
            return ReferenceCounter > 0;
        }

        public bool IsParentOfLeaves()
        {
            return !IsLeaf() && NextNodes.All((nextNode) => nextNode == null || nextNode.IsLeaf());
        }

        public int CompareTo(OctreeNode other)
        {
            if (other.ChildrenReferenceCounter() - this.ChildrenReferenceCounter() != 0)
            {
                return other.ChildrenReferenceCounter() - this.ChildrenReferenceCounter();
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

        public int ChildrenReferenceCounter()
        {
            return NextNodes.Aggregate(0, (total, next) =>
                next == null ? total : total + next.ReferenceCounter);
        }
        public Color ToColor()
        {
            return Color.FromArgb(255, Red, Green, Blue);
        }
        public override string ToString()
        {
            return $"[{Level}]({Convert.ToString(Red, 2)}, " +
                $"{Convert.ToString(Green, 2)}, " +
                $"{Convert.ToString(Blue, 2)})*{ReferenceCounter}";
        }
        public int ChildrenNumber()
        {
            return NextNodes.Count((child) => child != null);
        }
    }
}
