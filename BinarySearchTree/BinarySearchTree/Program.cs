using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Insert(12);
            tree.Insert(2);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(44);
            tree.Insert(9);
            tree.Insert(23);
            tree.Search(23);
            Console.ReadLine();
        }
    }



}
