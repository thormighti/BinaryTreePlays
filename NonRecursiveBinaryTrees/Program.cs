using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveBinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            RBinaryTree tree = new RBinaryTree();
            tree.Root = new RBinaryNode(44);
            tree.Root.Left = new RBinaryNode(34);
            tree.Root.Right = new RBinaryNode(23);
            tree.Root.Left.Right = new RBinaryNode(45);
            tree.Root.Left.Left = new RBinaryNode(30);
            Console.WriteLine("Pre order binar tree");
            tree.RPreOrder(tree.Root);
            Console.WriteLine();
            Console.WriteLine(  );

            Console.WriteLine("In order binary tree");
            tree.RInOrder(tree.Root);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Post order binary tree");
            tree.PostOrder(tree.Root);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Level order Binary trees");
            tree.LevelOrder(tree.Root);

            Console.WriteLine($"the maximum is {tree.MaxElement(tree.Root)} and the sum is {tree.SumOfBinaryTress(tree.Root.Left)}"); // i see.tree.Root.Left only calculate the value of the node and kids  

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Height order Binary trees");
            Console.WriteLine( tree.Height(tree.Root));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" leave number of Binary trees");
            Console.WriteLine(tree.numberOfLeaves(tree.Root));
            Console.ReadKey();
        }
    }
}
