using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        //Member Variables
        public Node root;

        //Constructor
        public Tree()
        {

        }

        public Tree(int value)
        {
            root = new Node(value);
        }
        // member methods
        public void AddRoot(int value)
        {
            root = new Node(value);
        }

        public void Insert(int input)
        {
            //adding a new replacement node
            Node replacementNode = new Node(input);
            //if there are no nodes, this is the root
            if (root == null)
            {
                AddRoot(input);
            }
            //if there is a node but the position on the Right is emmpty
            else if (root.Right == null)
            {
                //if the replacement node  is BIGGER than the root
                if (replacementNode.NumberInNode >= root.NumberInNode)
                {
                    //than the position on the right is filled with the replacement node
                    root.Right = replacementNode;
                    //keeping the parent as the root
                    replacementNode.Parent = root;
                }
            }
            else if (replacementNode.NumberInNode >= root.NumberInNode)
            {
                //calling the ADD function and feeding in root.Right and replacement Node
                Add(root.Right, replacementNode);
            }
            //if there is a node but the position on the Left is empty
            else if (root.Left == null)
            {
                //if there is no nide on the left AND the replacement is smaller than the root
                if (replacementNode.NumberInNode < root.NumberInNode)
                {
                    //inserting the replacement to the left
                    root.Left = replacementNode;
                    //keeping the Parent as the root
                    replacementNode.Parent = root;
                }
            }
            //if there is a node on the left but the replacement is smaller than the root
            else if (replacementNode.NumberInNode < root.NumberInNode)
            {
                //calling the ADD function and feeding in root.Left and replacement Node
                Add(root.Left, replacementNode);
            }
        }
        //ADD FUNCTION
        public void Add(Node node, Node replacementNode)
        {
            if (replacementNode.NumberInNode >= node.NumberInNode && node.Right == null)
            {
                //if the replacement node is LARGER than the node and node to the right is empty
                node.Right = replacementNode;
                replacementNode.Parent = node;
            }
            else if (replacementNode.NumberInNode >= node.NumberInNode)
            {
                //addmethod for more complicated situation of right NOT empty
                Add(node.Right, replacementNode);
            }

            //if the replacement node is LARGER than the node and node to the left is empty
            else if (replacementNode.NumberInNode < node.NumberInNode && node.Left == null)
            {
                //if the replacement node is SMALLER than the node and the node on the left is empty
                node.Left = replacementNode;
                replacementNode.Parent = node;
            }
            else if (replacementNode.NumberInNode < node.NumberInNode)
            {
                //addmethod for more complicated situation of left NOT empty
                Add(node.Left, replacementNode);
            }
        }

        //SEARCH FUNCTION
        public void Search(int value, Node currentNode = null)
        {
            if (currentNode == null)
            {
                currentNode = root;
                Search(value, currentNode);
            }
            else if (value > currentNode.NumberInNode)
            {
                if (currentNode.Right == null)
                {
                    Console.WriteLine("You value wasn't found.");
                    return;
                }
                currentNode = currentNode.Right;
                Search(value, currentNode);
            }
            else if (value < currentNode.NumberInNode)
            {
                if (currentNode.Left == null)
                {
                    Console.WriteLine("Your value wasn't found.");
                    return;
                }
                currentNode = currentNode.Left;
                Search(value, currentNode);
            }
            else if (value == currentNode.NumberInNode)
            {
                currentNode.NumberInNode = value;
                Console.WriteLine("Your value is found.");
            }
            else
            {
                Console.WriteLine("Your value wasn't found.");
            }
        }

    }
}
