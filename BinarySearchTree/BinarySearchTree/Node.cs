using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public Node left;
        public Node right;
        public Node parent;
        public int numberInNode;

        //constructor


        public Node (int numberInNode)
        {

            this.numberInNode = numberInNode; 
            left = null;
            right = null;
        }

        public int NumberInNode
        {
            get
            {
                return numberInNode;
            }
            set
            {
                numberInNode = value;
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
