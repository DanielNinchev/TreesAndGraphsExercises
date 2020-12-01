using System;

namespace CountTheFrequencyOfANumberInATree
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Create the tree from the sample
            Tree<int> tree =
                new Tree<int>(7,
                    new Tree<int>(19,
                        new Tree<int>(7),
                        new Tree<int>(12),
                        new Tree<int>(21)),
                    new Tree<int>(21),
                    new Tree<int>(14,
                        new Tree<int>(21),
                        new Tree<int>(6))
                );

            //Traverse and print the tree using Depth-First-Search
            tree.PrintDFS();

            Console.WriteLine();

            Console.WriteLine("Enter the number, the frequency of which you want to count in the tree: ");

            int chosenNumber = int.Parse(Console.ReadLine());

            tree.CountTheFrequencyOfANodeInTheTree(chosenNumber);

            tree.PrintResult(chosenNumber);
        }
    }
}
