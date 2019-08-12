using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        BinaryNode root;
        public BinaryTree()
        {
            root = null;
        }
        public BinaryNode Root { get; set; }
       public  void PreOrder(BinaryNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
        /// creating wrapppers for preorder
       //public void PreOrder ()
       // {
       //     PreOrder(root);
       // }
       public void InOrder(BinaryNode node)
        {
            if (node == null)
            {
                return;
            }
            InOrder(node.Left);
            Console.WriteLine(node.Data + " ");
            InOrder(node.Right);
        }
        // post order LRD
        public void PostOrder(BinaryNode node)
        {
            if(node == null)
            {
                return;
            }
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine(node.Data + " ");
        }
        public int Height(BinaryNode rootNode)
        {
            if (rootNode == null)
            {
                return -1;
            }

            int lHeight = Height(rootNode.Left);
            int rHeight = Height(rootNode.Right);

            if (lHeight > rHeight)
            {
                return (lHeight + 1);
            }
            else
            {
                return (rHeight + 1);
            }

        }
    }
}
