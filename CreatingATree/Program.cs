using System;

namespace TreesAndGraphsExercises
{
    //Примерна имплементация на дърво
    public static class TreeExample
    {
        static void Main(string[] args)
        {
            //Create the tree from the sample
            Tree<int> tree =
                new Tree<int>(7,
                    new Tree<int>(19,
                        new Tree<int>(1),
                        new Tree<int>(12),
                        new Tree<int>(31)),
                    new Tree<int>(21),
                    new Tree<int>(14,
                        new Tree<int>(23),
                        new Tree<int>(6))
                );

            //Traverseand print he tree using Deth-First-Search
            tree.PrintDFS();
        }
    }
}
