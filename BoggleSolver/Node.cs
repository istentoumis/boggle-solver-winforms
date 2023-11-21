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
