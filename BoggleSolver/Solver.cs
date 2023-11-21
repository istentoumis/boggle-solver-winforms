using System;
using System.Collections;
using System.Collections.Generic;
namespace BoggleSolver
{
    public class Solver
    {
        public static Node root = new('^');
        public static List<string> foundWords = new List<string>();

        #region Solver

        public static void RunBoggleSolver(string[] dictionary, string filePath, char[,] board)
        {
            dictionary = GetWordsFromDictionary(filePath);
            BuildTrie(dictionary);
            FindWords(board);
            PrintFoundWords();
            foundWords.Clear();
        }

        private static string[] GetWordsFromDictionary(string filePath)
        {
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        private static void PrintFoundWords()
        {
            if (foundWords.Count == 0)
            {
                MessageBox.Show("Could not found any words");
            }
            else
            {
                string message = "The found words are:\n" + string.Join("\n", foundWords);
                MessageBox.Show(message);
            }
        }

        #endregion

        #region Trie
        public static void BuildTrie(string[] dictionary)
        {
            foreach (string word in dictionary)
            {
                InsertWordToTrie(word);
            }
        }


        public static void InsertWordToTrie(string word)
        {
            Node node = root;

            foreach (char c in word)
            {
                if (!node.children.ContainsKey(c))
                {
                    node.children[c] = new Node(c);
                }

                node = node.children[c];
            }

            node.isEndOfWord = true;
        }

        #endregion

        #region DFS 

        // Explore the board with Depth-First-Search
        public static List<string> FindWords(char[,] board)
        {

            int row = board.GetLength(0);
            int column = board.GetLength(1);
            bool[,] visited = new bool[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    DFS(board, i, j, "", visited, root, foundWords);
                }
            }
            return foundWords;
        }

        private static void DFS(char[,] board, int currentRow, int currentColumn, string currentWord, bool[,] visited, Node node, List<string> foundWords)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            // Check if the current position is valid and not visited
            if (currentRow < 0 || currentColumn < 0 || currentRow >= rows || currentColumn >= columns || visited[currentRow, currentColumn])
                return;

            char currentChar = board[currentRow, currentColumn];

            // If the current char does not have children, then backtrack
            if (!node.children.ContainsKey(currentChar))
                return;

            currentWord += currentChar;

            visited[currentRow, currentColumn] = true;

            // Get the next node in the Trie and check if the current words forms a valid word
            Node nextNode = GetNextNode(node, currentChar, currentWord);

            // Recursion: explore adjacent positions of the current letter on the board
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    DFS(board, currentRow + i, currentColumn + j, currentWord, visited, nextNode, foundWords);
                }
            }

            visited[currentRow, currentColumn] = false;
        }

        private static Node GetNextNode(Node node, char currentChar, string currentWord)
        {
            Node nextNode = node.children[currentChar];

            if (nextNode.isEndOfWord)
            {
                foundWords.Add(currentWord);
                nextNode.isEndOfWord = false; // Mark the word as found to avoid duplicates
            }

            return nextNode;
        }
    }
    #endregion
}
