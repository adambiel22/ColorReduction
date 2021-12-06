using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OctreeAdamBielecki
{
    public class Octree
    {
        public List<OctreeNode>[] NodesOfLevel { get; private set; }
        public int ColorNumber { get; set; }
        
        private OctreeNode root;
        public Octree()
        {
            NodesOfLevel = new List<OctreeNode>[8];
            for (int i = 0; i < 8; i++) 
            {
                NodesOfLevel[i] = new List<OctreeNode>();
            }
            ColorNumber = 0;
        }

        public Color FindColor(Color color)
        {
            OctreeNode currentNode = root;
            int level = 0;
            while (!currentNode.IsLeaf())
            {
                int childIndex = computeChildIndex(color, level);
                currentNode = currentNode.NextNodes[childIndex];
                level++;
            }
            return currentNode.ToColor();
        }

        public void AddColor(Color insertedColor)
        {
            if (root == null)
            {
                initializeRoot();
                NodesOfLevel[0].Add(root);
            }
            OctreeNode currentOctreeNode = root;
            for (int level = 0; level < 8 && !currentOctreeNode.IsLeaf(); level++) 
            {
                int childIndex = computeChildIndex(insertedColor, level);
                if (currentOctreeNode.NextNodes[childIndex] == null)
                {
                    currentOctreeNode.NextNodes[childIndex] = new OctreeNode(level + 1);
                    if (level != 7)
                    {
                        NodesOfLevel[level + 1].Add(currentOctreeNode.NextNodes[childIndex]);
                    } 
                    int mask = 0b11111111 >> (7 - level) << (7 - level);
                    currentOctreeNode.NextNodes[childIndex].Red = insertedColor.R & mask;
                    currentOctreeNode.NextNodes[childIndex].Green = insertedColor.G & mask;
                    currentOctreeNode.NextNodes[childIndex].Blue = insertedColor.B & mask;
                }
                currentOctreeNode = currentOctreeNode.NextNodes[childIndex];
            }
            currentOctreeNode.ReferenceCounter++;
            if (currentOctreeNode.ReferenceCounter == 1)
            {
                ColorNumber++;
            }
        }

        public void Reduce(int maxNumberOfColors)
        {
            if (maxNumberOfColors <= 0)
            {
                throw new ArgumentException("maxNumberOfColors must be >= 1");
            }
            int currentLevel = 7;
            NodesOfLevel[currentLevel].Sort();
            int currentMax = 0;
            while (currentLevel != 0 && ColorNumber > maxNumberOfColors)
            {
                while (currentMax == NodesOfLevel[currentLevel].Count)
                {
                    currentLevel--;
                    NodesOfLevel[currentLevel].Sort();
                    currentMax = 0;
                }
                OctreeNode maxNode = NodesOfLevel[currentLevel][currentMax];
                currentMax++;
                if (!maxNode.IsLeaf())
                {
                    ReduceNode(maxNode);
                }
            }

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                stringBuilder.Append($"Level {i}: ");
                foreach(OctreeNode octreeNode in NodesOfLevel[i])
                {
                    stringBuilder.Append($"{octreeNode} ");
                }
                stringBuilder.Append("\n");
                if (i == 7)
                {
                    stringBuilder.Append($"Level {8}: ");
                    foreach (OctreeNode octreeNode in NodesOfLevel[7])
                    {
                        foreach (OctreeNode leaf in octreeNode.NextNodes)
                        {
                            if (leaf != null)
                            {
                                stringBuilder.Append($"{leaf} ");
                            }
                        }
                    }
                }
            }
            return stringBuilder.ToString();
        }

        private void ReduceNode(OctreeNode reducedNode)
        {
            if (!reducedNode.IsParentOfLeaves())
            {
                throw new ArgumentException("reducedNode's children must be leaves");
            }
            int childrenCounter = 0;
            reducedNode.Red = 0;
            reducedNode.Green = 0;
            reducedNode.Blue = 0;
            for (int i = 0; i < 8; i++) 
            {
                if(reducedNode.NextNodes[i] != null)
                {
                    childrenCounter++;
                    reducedNode.Red += reducedNode.NextNodes[i].Red * reducedNode.NextNodes[i].ReferenceCounter;
                    reducedNode.Green += reducedNode.NextNodes[i].Green * reducedNode.NextNodes[i].ReferenceCounter; 
                    reducedNode.Blue += reducedNode.NextNodes[i].Blue * reducedNode.NextNodes[i].ReferenceCounter;
                    reducedNode.ReferenceCounter += reducedNode.NextNodes[i].ReferenceCounter;
                    if (reducedNode.Level != 7)
                    {
                        NodesOfLevel[reducedNode.Level + 1].Remove(reducedNode.NextNodes[i]);
                    }
                    reducedNode.NextNodes[i] = null;
                    ColorNumber--;
                }
            }
            ColorNumber++;
            reducedNode.Red /= reducedNode.ReferenceCounter;
            reducedNode.Green /= reducedNode.ReferenceCounter;
            reducedNode.Blue /= reducedNode.ReferenceCounter;
        }

        private void initializeRoot()
        {
            root = new OctreeNode(0);
        }

        private int computeChildIndex(Color color, int level)
        {
            int index = 0;
            int mask = 0b10000000 >> level;
            if ((color.R & mask) != 0) index |= 0b100;
            if ((color.G & mask) != 0) index |= 0b010;
            if ((color.B & mask) != 0) index |= 0b001;
            return index;
        }
    }
}
