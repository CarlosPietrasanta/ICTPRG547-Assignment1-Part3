using System;
using System.Xml.Linq;

namespace Assignment1.DataStructures.BinaryTree
{
    public class BinaryTree
    {
        public BinaryTreeNode Root { get; set; }

        public bool Add(int value)
        {
            BinaryTreeNode before = null;
            BinaryTreeNode after = Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if (value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    // Same value already exists
                    return false;
                }
            }

            BinaryTreeNode newNode = new BinaryTreeNode();
            newNode.Data = value;

            // If the tree is empty
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                if (value < before.Data)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }
            }
            return true;
        }

        public BinaryTreeNode Find(int value)
        {
            return Find(value, Root);
        }

        private BinaryTreeNode Find(int value, BinaryTreeNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Data)
                {
                    return parent;
                }
                if (value < parent.Data)
                {
                    return Find(value, parent.LeftNode);
                }
                else
                {
                    return Find(value, parent.RightNode);
                }
            }
            return null;
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }

        private BinaryTreeNode Remove(BinaryTreeNode parent, int value)
        {
            if (parent == null)
            {
                return parent;
            }
            if (value < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, value);
            }
            else if (value > parent.Data)
            {
                parent.RightNode = Remove(parent.RightNode, value);
            }
            else
            {
                if (parent.LeftNode == null)
                {
                    return parent.RightNode;
                }
                else if (parent.RightNode == null)
                {
                    return parent.LeftNode;
                }

                parent.Data = MinValue(parent.RightNode);
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(BinaryTreeNode node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public void TraversePreOrder(BinaryTreeNode parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(BinaryTreeNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(BinaryTreeNode parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }

        public static void QuickTest()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            // BinaryTreeNode node = binaryTree.Find(5);
            //int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);

            Console.WriteLine("\nInOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);

            Console.WriteLine("\nPostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
