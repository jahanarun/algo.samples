
using System;
using System.Linq;

namespace algo.samples
{
    public static partial class Algo
    {
        public static Node[] Inorder(Node N, Node head)
        {
            if (N == null)
            {
                return Array.Empty<Node>();
            }

            var leftInorderedNodes = Inorder(N.Left, N);
            var rightInorderedNodes = Inorder(N.Right, head);

            if (N.Right == null)
            {
                N.Random = head;
            }
            else
            {
                N.Random = rightInorderedNodes[0];
            }

            return leftInorderedNodes.Concat(new[] { N }).Concat(rightInorderedNodes).ToArray();
        }
    }

    public class Node
    {
        public Node Right { get; internal set; }
        public Node Left { get; internal set; }
        public Node Random { get; internal set; }
    }

    // invoke

    // Node startNode; // Assume this is the starting node of the tree
    // inorder(startNode, null);

}