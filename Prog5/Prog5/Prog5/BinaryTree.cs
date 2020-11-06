// Program 5
// CIS 200-01
// Due: 4/20/2020
// By: T9749

// File: Program.cs
// This file creates a binary tree in preorder, inorder and postorder. 
using System;

namespace Prog5
    {
        // class TreeNode declaration
        class TreeNode <T> where T : IComparable<T>
        {

            // automatic property LeftNode
            public TreeNode <T> LeftNode { get; set; }

            // automatic property Data
            public T Data { get; private set; }

            // automatic property RightNode
            public TreeNode <T> RightNode { get; set; }

            // initialize Data and make this a leaf node
            public TreeNode(T nodeData)
            {
                Data = nodeData;
            }

            // insert TreeNode into Tree that contains nodes;
            // ignore duplicate values
            public void Insert(T insertValue)
            {
                if (insertValue.CompareTo(Data) < 0) // insert in left subtree
                {
                    // insert new TreeNode
                    if (LeftNode == null)
                    {
                        LeftNode = new TreeNode <T>(insertValue);
                    }
                    else // continue traversing left subtree
                    {
                        LeftNode.Insert(insertValue);
                    }
                }
                else if (insertValue.CompareTo(Data) > 0) // insert in right
                {
                    // insert new TreeNode
                    if (RightNode == null)
                    {
                        RightNode = new TreeNode <T>(insertValue);
                    }
                    else // continue traversing right subtree
                    {
                        RightNode.Insert(insertValue);
                    }
                }
            }
        }

        // class Tree declaration
        public class Tree <TR> where TR : IComparable <TR>
        {
            private TreeNode <TR> root;

            // Insert a new node in the binary search tree.
            // If the root node is null, create the root node here.
            // Otherwise, call the insert method of class TreeNode.
            public void InsertNode(TR insertValue)
            {
                if (root == null)
                {
                    root = new TreeNode<TR>(insertValue);
                }
                else
                {
                    root.Insert(insertValue);
                }
            }

            // begin preorder traversal
            public void PreorderTraversal()
            {
                PreorderHelper(root);
            }

            // recursive method to perform preorder traversal
            private void PreorderHelper(TreeNode <TR> node)
            {
                if (node != null)
                {
                    // output node Data
                    Console.Write($"{node.Data} ");

                    // traverse left subtree
                    PreorderHelper(node.LeftNode);

                    // traverse right subtree
                    PreorderHelper(node.RightNode);
                }
            }

            // begin inorder traversal
            public void InorderTraversal()
            {
                InorderHelper(root);
            }

            // recursive method to perform inorder traversal
            private void InorderHelper(TreeNode <TR> node)
            {
                if (node != null)
                {
                    // traverse left subtree
                    InorderHelper(node.LeftNode);

                    // output node data
                    Console.Write($"{node.Data} ");

                    // traverse right subtree
                    InorderHelper(node.RightNode);
                }
            }

            // begin postorder traversal
            public void PostorderTraversal()
            {
                PostorderHelper(root);
            }

            // recursive method to perform postorder traversal
            private void PostorderHelper(TreeNode <TR> node)
            {
                if (node != null)
                {
                    // traverse left subtree
                    PostorderHelper(node.LeftNode);

                    // traverse right subtree
                    PostorderHelper(node.RightNode);

                    // output node Data
                    Console.Write($"{node.Data} ");
                }
            }
        }
    }