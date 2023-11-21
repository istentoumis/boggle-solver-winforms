using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleSolver
{
    public class Node
    {
        public char letter;
        public bool isEndOfWord;
        public Dictionary<char, Node> children;

        public Node(char letter)
        {
            this.letter = letter;
            isEndOfWord = false;
            children = new Dictionary<char, Node>();
        }
    }
}
