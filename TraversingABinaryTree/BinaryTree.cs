﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TraversingABinaryTree
{
    public class BinaryTree<T>
    {
        /// <summary> Constructs a binary tree </summary>
        /// /// <param name="value">the value of the tree node</param>
        /// <param name="leftChild">the left child of the tree</param>
        /// <param name="rightChild">the right child of the tree</param>
        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        /// <summary> Constructs a binary treewith no children </summary>
        /// <param name="value">the value of the tree node</param>
        public BinaryTree(T value) : this(value, null, null)
        {

        }

        /// <summary> The value stored in the current node </summary>
        public T Value { get; set; }
        /// <summary> The left child of the current node </summary>
        public BinaryTree<T> LeftChild { get; private set; }
        /// <summary> The right child of the current node </summary>
        public BinaryTree<T> RightChild { get; private set; }

        /// <summary> Traverses binary tree in pre-order </summary>
        public void PrintInOrder()
        {
            //1. Visit the left child
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintInOrder();
            }

            //2. Visit the root of this subtree
            Console.Write(this.Value + " ");

            //3. Visit the right child
            if (this.RightChild != null)
            {
                this.RightChild.PrintInOrder();
            }
        }
    }
}
