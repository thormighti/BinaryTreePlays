using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryNode
    {
        object data;
        BinaryNode left, right;
        public BinaryNode(object data)
        {
            this.data = data;
            left = right = null;
        }
        public object Data { get { return this.data; } set { data = value; } }
        public BinaryNode Left { get { return this.left; } set { this.left = value; } }
        public BinaryNode Right { get { return this.right; } set { this.right = value; } }
    }
}
