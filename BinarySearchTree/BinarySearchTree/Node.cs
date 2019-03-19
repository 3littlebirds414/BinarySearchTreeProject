using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node parent;

        public Node (int initial)
        {
            
            value = initial;
            left = null;
            right = null;
        }

        public int initial
        {
            get
            {
                return initial;
            }
            set
            {
                initial = value;
            }
        }

        public Node Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public Node Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }

        public Node Parent
        {
            get
            {
                return parent;
            }
            set
            {
                parent = value;
            }
        }




    }
}
