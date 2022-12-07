using System;
using System.Collections.Generic;

namespace DS
{
    // Inspired by: https://stackoverflow.com/questions/36311991/c-sharp-display-a-binary-search-tree-in-console
    public class BST
    {

        public enum NodePosition
        {
            left,
            right,
            center
        }

        public class BNode
        {
            // Variable declaration
            public int item;
            public BNode right;
            public BNode left;

            public BNode(int item)
            {
                this.item = item;
            }

            // Function to print Values
            private void PrintValue(string value, NodePosition nodePostion)
            {
                switch (nodePostion)
                {
                    case NodePosition.left:
                        PrintLeftValue(value);
                        break;
                    case NodePosition.right:
                        PrintRightValue(value);
                        break;
                    case NodePosition.center:
                        Console.WriteLine(value);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            // Function to print left values
            private void PrintLeftValue(string value)
            {
                // Output left node
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("L:");
                Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(value);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            // Function to print right values
            private void PrintRightValue(string value)
            {
                // Output right node
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("R:");
                Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(value);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            // Function to print connecting lines between nodes and values
            public void PrintPretty(string indent, NodePosition nodePosition, bool last, bool empty)
            {

                Console.Write(indent);
                if (last)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "| ";
                }

                // Printing an empty node/value
                var stringValue = empty ? "-" : item.ToString();
                PrintValue(stringValue, nodePosition);

                if (!empty && (this.left != null || this.right != null))
                {
                    if (this.left != null)
                        this.left.PrintPretty(indent, NodePosition.left, false, false);
                    else
                        PrintPretty(indent, NodePosition.left, false, true);

                    if (this.right != null)
                        this.right.PrintPretty(indent, NodePosition.right, true, false);
                    else
                        PrintPretty(indent, NodePosition.right, true, true);
                }
            }

        }

        public class BTree
        {
            private BNode _root;
            private int _count;
            private IComparer<int> _comparer = Comparer<int>.Default;


            public BTree()
            {
                _root = null;
                _count = 0;
            }


            public bool Add(int Item)
            {
                if (_root == null)
                {
                    _root = new BNode(Item);
                    _count++;
                    return true;
                }
                else
                {
                    return Add_Sub(_root, Item);
                }
            }

            private bool Add_Sub(BNode Node, int Item)
            {
                if (_comparer.Compare(Node.item, Item) < 0)
                {
                    if (Node.right == null)
                    {
                        Node.right = new BNode(Item);
                        _count++;
                        return true;
                    }
                    else
                    {
                        return Add_Sub(Node.right, Item);
                    }
                }
                else if (_comparer.Compare(Node.item, Item) > 0)
                {
                    if (Node.left == null)
                    {
                        Node.left = new BNode(Item);
                        _count++;
                        return true;
                    }
                    else
                    {
                        return Add_Sub(Node.left, Item);
                    }
                }
                else
                {
                    return false;
                }
            }

            // Function to print
            public void Print()
            {
                _root.PrintPretty("", NodePosition.center, true, false);
            }

        }
    }
}
