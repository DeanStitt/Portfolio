// Program 4
// CIS 200-01
// Due: 4/20/2020
// By: T9749

// File: Test.cs
// This file tests the generic type for binary tree outputing data for string, double, and int.
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog5
{
    class TreeTest
    {
        // test class Tree
        static void Main()
        {
            int[] intArray = { 8, 2, 4, 3, 1, 7, 5, 6 };
            double[] doubleArray = { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6 };
            string[] stringArray =
               {"eight", "two", "four","three", "one", "seven", "five", "six"};

            // create int Tree
            Tree<int> intTree = new Tree<int>();
            PopulateTree(intArray, intTree, nameof(intTree));
            TraverseTree(intTree, nameof(intTree));

            // create double Tree
            Tree<double> doubleTree = new Tree<double>();
            PopulateTree(doubleArray, doubleTree, nameof(doubleTree));
            TraverseTree(doubleTree, nameof(doubleTree));

            // create string Tree
            Tree<string> stringTree = new Tree<string>();
            PopulateTree(stringArray, stringTree, nameof(stringTree));
            TraverseTree(stringTree, nameof(stringTree));
        }

        // populate Tree with array elements
            private static void PopulateTree <TR> (Array array, Tree <TR> tree, string name) where TR : IComparable<TR>//pre three variables passed to method post inserted into array based on tree
            {
                Console.WriteLine($"\n\n\nInserting into {name}:");

                foreach (TR data in array)
                {
                    Console.Write($"{data} ");
                    tree.InsertNode(data);
                }
            }

            // perform traversals
            private static void TraverseTree <TR> (Tree <TR> tree , string treeType) where TR : IComparable<TR>//pre three variables passed to method post inserted into array based on tree
        {
                // perform preorder traversal of tree
                Console.WriteLine($"\n\nPreorder traversal of {treeType}");
                tree.PreorderTraversal();

                // perform inorder traversal of tree
                Console.WriteLine($"\n\nInorder traversal of {treeType}");
                tree.InorderTraversal();

                // perform postorder traversal of tree
                Console.WriteLine($"\n\nPostorder traversal of {treeType}");
                tree.PostorderTraversal();
            }
        }
    }
