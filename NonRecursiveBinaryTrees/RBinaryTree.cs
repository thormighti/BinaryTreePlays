using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveBinaryTrees
{
    class RBinaryTree
    {
        RBinaryNode root;

        public RBinaryNode Root { get; set; }
        public void RPreOrder(RBinaryNode rootNode)
        {
            
            if(rootNode == null)
            {
                return;
            }
            Stack<RBinaryNode> S = new Stack<RBinaryNode>();
            S.Push(rootNode);
            while(S.Count != 0)
            {
               rootNode = S.Pop();
                Console.WriteLine(rootNode.Data + "" );
               

                if(rootNode.Right != null)
                {
                    S.Push(rootNode.Right);
                }
                if(rootNode.Left != null)
                {
                    S.Push(rootNode.Left);
                }
                
            }
           
        }
        //In Order
        public void RInOrder(RBinaryNode rootNode)
        {
           // RBinaryNode temp = node;
            if(rootNode == null)
            {
                return;
            }
            Stack<RBinaryNode> S = new Stack<RBinaryNode>();
            
            while(true)
            {
                while (rootNode != null)
                {
                    S.Push(rootNode);
                    rootNode = rootNode.Left;
                }
                if(S.Count == 0) { return; }
                rootNode= S.Pop();
             
                Console.WriteLine(rootNode.Data + " ");

                rootNode = rootNode.Right;
            }
        }
        public void PostOrder(RBinaryNode rootNode)
        {
            if (rootNode == null)
            {
                return;
            }
            Stack<RBinaryNode> S = new Stack<RBinaryNode>();
            while (true)
            {
                while(rootNode != null)
                {
                    S.Push(rootNode);
                    S.Push(rootNode);
                    rootNode = rootNode.Left;
                }
                if(S.Count == 0) { return; }
                rootNode = S.Pop();
                if (S.Count != 0 && S.Peek() == rootNode)
                {
                    rootNode = rootNode.Right;
                }
          
                else
                {
                    Console.WriteLine(rootNode.Data);
                    rootNode = null;
                }
            }
        }
        public void LevelOrder(RBinaryNode rootNode)
        {
            if (rootNode == null)
            {
                return;
            }
            Queue<RBinaryNode> Q = new Queue<RBinaryNode>();
            Q.Enqueue(rootNode);
            while(Q.Count != 0)
            {
                rootNode = Q.Dequeue();
                Console.WriteLine(rootNode.Data);
                if(rootNode.Left != null)
                {
                    Q.Enqueue(rootNode.Left);
                }
                if(rootNode.Right != null)
                {
                    Q.Enqueue(rootNode.Right);
                }
            }
        }
        //Finding the maximum element in the binary tree. usingg level order
        public int MaxElement(RBinaryNode rootNode)
        {
            int max = int.MinValue;
            if (rootNode == null)
            {
                return 0;
            }
            Queue<RBinaryNode> Q = new Queue<RBinaryNode>();
            Q.Enqueue(rootNode);
            while (Q.Count != 0)
            {
                rootNode = Q.Dequeue();
                if(max < rootNode.Data)
                {
                    max = rootNode.Data;
                }
                if (rootNode.Left != null)
                {
                    Q.Enqueue(rootNode.Left);
                }
                if (rootNode.Right != null)
                {
                    Q.Enqueue(rootNode.Right);
                }
                
            }
            return max;
        }
        public int SumOfBinaryTress(RBinaryNode rootNode)
        {
            int sum = 0;
            if (rootNode == null)
            {
                return -1;
            }
            Queue<RBinaryNode> Q = new Queue<RBinaryNode>();
            Q.Enqueue(rootNode);
            while(Q.Count != 0)
            {
                rootNode = Q.Dequeue();
                sum += rootNode.Data;
            
            if (rootNode.Left != null)
            {
                Q.Enqueue(rootNode.Left);
            }
            if (rootNode.Right != null)
            {
                Q.Enqueue(rootNode.Right);
            }
        }
            return sum;
        }
        public void ReverseLevelOrder(RBinaryNode rootNode)
        {
            if (rootNode == null)
            {
                return;
            }
            Stack<RBinaryNode> S = new Stack<RBinaryNode>();
            Queue<RBinaryNode> Q = new Queue<RBinaryNode>();
            Q.Enqueue(rootNode);
            while (Q.Count != 0)
            {
                rootNode = Q.Dequeue();
               
                if (rootNode.Left != null)
                {
                    Q.Enqueue(rootNode.Left);
                }
                if (rootNode.Right != null)
                {
                    Q.Enqueue(rootNode.Right);
                }
                S.Push(rootNode);
            }
            while(S.Count != 0)
            {
                S.Pop();
                Console.WriteLine(rootNode.Data);
            }
        }
        // height of a tree
       public int Height(RBinaryNode rootNode)
        {
            int level = 0;
          

            Queue<RBinaryNode> Q = new Queue<RBinaryNode>();

            Q.Enqueue(rootNode);
            Q.Enqueue(null);
            while (Q.Count != 0)
            {
                rootNode = Q.Dequeue();
                if(rootNode == null)
                {
                    if (Q.Count != 0)
                    {
                        Q.Enqueue(null);
                        level++;
                    }
                
                }
                else
                {
                    if(rootNode.Left != null)
                    {
                        Q.Enqueue(rootNode.Left);
                    }
                    if(rootNode.Right != null)
                    {
                        Q.Enqueue(rootNode.Right);
                    }
                }
            }
            return level;
        }
        public int numberOfLeaves(RBinaryNode rootNode)
        {
            if(rootNode == null)
            {
                return -1;
            }
            int leaveCount = 0;
            Queue<RBinaryNode> Q = new Queue<RBinaryNode>();
            Q.Enqueue(rootNode);
            while(Q.Count != 0)
            {
                rootNode = Q.Dequeue();
                if((rootNode.Left != null) && (rootNode.Right != null))
                {
                    leaveCount++;
                }
                else
                {
                    if (rootNode.Left != null)
                    {
                        Q.Enqueue(rootNode.Left);
                    }
                    if (rootNode.Right != null)
                    {
                        Q.Enqueue(rootNode.Right);
                    }
                }
            }
            return leaveCount;
        }
    }
}
