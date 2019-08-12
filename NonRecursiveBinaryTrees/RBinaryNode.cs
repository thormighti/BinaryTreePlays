using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveBinaryTrees
{
    class RBinaryNode
    {
        RBinaryNode left, right;
        public RBinaryNode(int data)
        {
            this.data = data;
            left = right = null;
        }
        private int data;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public RBinaryNode Left { get; set; }
        public RBinaryNode Right { get; set; }
    }
}
