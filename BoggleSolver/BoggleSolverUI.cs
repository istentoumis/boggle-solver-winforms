using BoggleSolver.Properties;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BoggleSolver
{
    public partial class BoggleSolverUI : Form
    {
        public string[] dictionary;
        public char[,] board = new char[4, 3];
        private const string filePath = "Dictionary.txt";
        private static int selectedWords = 0;
        private readonly static Random random = new();
        private int wordCount;
        private readonly InstructionsUI instructionsUI;

        public BoggleSolverUI()
        {
            InitializeComponent();
            this.dictionary = new string[selectedWords];
            instructionsUI = new InstructionsUI(this);
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
            DeleteDictionaryContent(filePath);
        }

        private void Button10Words_Click(object sender, EventArgs e)
        {
            selectedWords = 10;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords, board);
        }

        private void Button50Words_Click(object sender, EventArgs e)
        {
            selectedWords = 50;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords, board);
        }

        private void Button100Words_Click(object sender, EventArgs e)
        {
            selectedWords = 100;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords, board);
        }

        private void Button500Words_Click(object sender, EventArgs e)
        {
            selectedWords = 500;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords, board);
        }

        private void Button1000Words_Click(object sender, EventArgs e)
        {
            selectedWords = 1000;
            Task.Run(async () => await OpenDictionary(filePath));
            WriteRandomWordsToDictionary(filePath, selectedWords, board);
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            instructionsUI.Show();
            DisableButtons();
        }

        private void RunBoggleButton_Click(object sender, EventArgs e)
        {
            if (wordCount == 0)
            {
                MessageBox.Show("Cannot execute with 0 words");

            }
            else
            {
                Solver.RunBoggleSolver(dictionary,filePath, board);
            }
        }

        #endregion

        #region Dictionary

        private async Task OpenDictionary(string filePath)
        {
            DisableButtons();
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
                
                wordCount = CountWordsfromDictionary(filePath);
                UpdateRunBoggleButtonText(wordCount);
                EnableButtons();
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

        private static void WriteRandomWordsToDictionary(string filePath, int selectedWords, char[,] board)
        {
            string[] words = new string[selectedWords];

            for (int i = 0; i < selectedWords; i++)
            {
                string word = GenerateWordFromBoard(board, random);

                words[i] = word;
            }

            Array.Sort(words);
            File.WriteAllLines(filePath, words);

        }

        private static string GenerateWordFromBoard(char[,] board, Random random)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            int wordLength = random.Next(1, 12);

            char[] wordChars = new char[wordLength];

            for (int j = 0; j < wordLength; j++)
            {
                // Generate random indices to select letters from the board
                int row = random.Next(rows);
                int col = random.Next(cols);

                // Append the selected letter to the word
                wordChars[j] = board[row, col];
            }

            return new string(wordChars);
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

        #endregion

        private void DisableButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = false;
                }
            }
        }

        public void EnableButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        private void UpdateRunBoggleButtonText(int wordCount)
        {
            RunBoggleButton.Text = $"Run BoggleSolver for {wordCount} words";
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}