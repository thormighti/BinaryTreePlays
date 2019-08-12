using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryNode("peter");
            tree.Root.Left = new BinaryNode(34);
            tree.Root.Right = new BinaryNode(23);
            tree.Root.Left.Right = new BinaryNode(45);
            tree.Root.Left.Left = new BinaryNode("Vince");
            Console.WriteLine("Pre order binar tree");
            tree.PreOrder(tree.Root);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("In order Binary trees");
            tree.InOrder(tree.Root);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Post order Binary trees");
            tree.PostOrder(tree.Root);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Height order Binary trees");
            Console.WriteLine(tree.Height(tree.Root.Left.Left));
            Console.ReadKey();

        }
    }
}
