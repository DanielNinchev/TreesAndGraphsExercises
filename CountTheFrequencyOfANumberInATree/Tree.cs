﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CountTheFrequencyOfANumberInATree
{
    public class Tree<T>
    {
        // The root of the tree
        private TreeNode<T> root;

        //The counter that counts the occurances of a node in the tree
        private int nodeCounter = 0;

        /// <summary> Constructs the tree </summary>
        /// <param name="value">the value of the node</param>
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }

        /// <summary> Constructs the tree </summary>
        /// <param name="value">the value of the root node</param>
        /// <param name="children">the children of the root node</param>
        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary> The root node or null if the tree is empty </summary>
        public TreeNode<T> Root => this.root;

        /// <summary> Traverses and prints tree in Depth First Search (DFS) order </summary>
        /// <param name="root">the root of the tree to be traversed</param>
        /// <param name="spaces">the spaces used for representation
        /// of the parent-child relation</param>
        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }

        /// <summary> Traverses & prints the tree in Depth First Search (DFS) order </summary>
        public void PrintDFS() => this.PrintDFS(this.root, string.Empty);

        private void CountTheFrequencyOfANodeInTheTree(TreeNode<T> node, int wantedValue)
        {

            if (this.root == null)
            {
                return;
            }

            

            TreeNode<T> child = null;

            for (int i = 0; i < node.ChildrenCount; i++)
            {
                child = node.GetChild(i);

                if (nodeCounter == 0 && root.Value.Equals(wantedValue))
                {
                    this.nodeCounter++;
                }

                if (child.Value.Equals(wantedValue))
                {
                    this.nodeCounter++;
                }

                CountTheFrequencyOfANodeInTheTree(child, wantedValue);
            }
        }

        public void CountTheFrequencyOfANodeInTheTree(int nodeValue) => this.CountTheFrequencyOfANodeInTheTree(this.root, nodeValue);

        public void PrintResult(int chosenValue)
        {
            Console.WriteLine($"The number {chosenValue} can be found {nodeCounter} times in the tree.");
        }
    }

}
