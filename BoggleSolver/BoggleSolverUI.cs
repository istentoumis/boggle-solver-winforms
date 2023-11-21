using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace BoggleSolver
{
    public partial class BoggleSolverUI : Form
    {
        private const string filePath = "Dictionary.txt";
        private static int selectedWords = 0;
        private static Random random = new Random();
        private string[] dictionary;
        readonly Solver s = new();
        char[,] board = new char[4, 3];
        private int wordCount;

        public BoggleSolverUI()
        {
            InitializeComponent();
            this.dictionary = new string[selectedWords];
        }

        #region Board
        private void BoggleBoard_Load(object sender, EventArgs e)
        {
            LoadBoard();
        }

        private void LoadBoard()
        {
            this.dataGridView.Rows.Clear();

            board = CreateBoard();

            int row = board.GetLength(0);
            int column = board.GetLength(1);

            this.dataGridView.ColumnCount = column;

            for (int r = 0; r < row; r++)
            {
                DataGridViewRow rows = new DataGridViewRow();
                rows.CreateCells(this.dataGridView);

                for (int c = 0; c < column; c++)
                {
                    rows.Cells[c].Value = board[r, c];
                }

                this.dataGridView.Rows.Add(rows);
            }

            //display the strings in the center of the cell
            this.dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ClearSelection();
        }

        private char[,] CreateBoard()
        {
            Random random = new Random();

            List<char> availableLetters = new List<char>();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                availableLetters.Add(c);
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (availableLetters.Count == 0)
                    {
                        break;
                    }

                    int randomIndex = random.Next(availableLetters.Count);
                    board[i, j] = availableLetters[randomIndex];

                    // Remove the selected letter from the list
                    availableLetters.RemoveAt(randomIndex);
                }
            }
            return board;
            
        }

        private void RefreshBoard_Click(object sender, EventArgs e)
        {
            LoadBoard();
        }

        // clear selection of dataGridView once clicking somewhere in the UI
        private void BoggleUI_Click(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }
        #endregion

        #region Buttons

        private void GenerateYourOwnDictionaryFileButton_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await OpenDictionary(filePath));
            //DeleteDictionaryContent(filePath);
            wordCount = CountWordsfromDictionary(filePath);
        }

        private void Button10Words_Click(object sender, EventArgs e)
        {
            selectedWords = 10;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords);
        }

        private void Button50Words_Click(object sender, EventArgs e)
        {
            selectedWords = 50;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords);
        }

        private void Button100Words_Click(object sender, EventArgs e)
        {
            selectedWords = 100;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords);
        }

        private void Button500Words_Click(object sender, EventArgs e)
        {
            selectedWords = 500;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords);
        }

        private void Button1000Words_Click(object sender, EventArgs e)
        {
            selectedWords = 1000;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords);
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            InstructionsUI form = new InstructionsUI();
            form.Show();

            this.Hide();
        }

        private void RunBoggleButton_Click(object sender, EventArgs e)
        {
            if (selectedWords == 0)
            {
                MessageBox.Show("Cannot execute with 0 words");

            }
            else
            {
                RunBoggleSolver();
            }
        }

        #endregion

        #region BoggleSolver

        private void RunBoggleSolver()
        {
            dictionary = GetWordsFromDictionary(filePath);
            s.BuildTrie(dictionary);
            s.FindWords(board);
            PrintFoundWords(s);
        }

        private static void PrintFoundWords(Solver s)
        {  
            if (s.foundWords.Count == 0)
            {
                MessageBox.Show("Could not found any words");
            }
            else
            {
                string message = "The found words are:\n" + string.Join("\n", s.foundWords);
                MessageBox.Show(message);
            }
        }

        private static string[] GetWordsFromDictionary(string filePath)
        {
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        #endregion

        private async Task OpenDictionary(string filePath)
        {
            Hide();
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close(); // Create the file and immediately close it
            }

            try
            {
                Process? process = Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true //use default text editor 
                });

                await process?.WaitForExitAsync();
                Show();

                wordCount = CountWordsfromDictionary(filePath);
                UpdateRunBoggleButtonText(wordCount);

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Cannot open text editor.");
            }
        }

        private static int CountWordsfromDictionary(string filePath)
        {
            // Read the contents of the file
            string content = File.ReadAllText(filePath);

            // Split the content into words using whitespace as separators
            string[] words = content.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Count the number of words
            return words.Length;
        }

        private static void WriteRandomWordsToDictionary(string filePath, int selectedWords)
        {
            string[] words = new string[selectedWords];

            for (int i = 0; i < selectedWords; i++)
            {
                // Generate a random word (for simplicity, using a fixed set of words)
                string word = "Word" + (i + 1);

                // Append the word to the array
                words[i] = word;
            }

            // Write the words to the file
            File.WriteAllLines(filePath, words);
        }

        private static void DeleteDictionaryContent(string filePath)
        {
            try
            {
                // Overwrite the file with an empty string
                File.WriteAllText(filePath, string.Empty);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error deleting file content: {ex.Message}");
            }
        }

        private void UpdateRunBoggleButtonText(int wordCount)
        {
            RunBoggleButton.Text = $"Run BoggleSolver for {wordCount} words";
        }

        private void BoggleSolver_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteDictionaryContent(filePath);
            Application.Exit();
        }

    }
}