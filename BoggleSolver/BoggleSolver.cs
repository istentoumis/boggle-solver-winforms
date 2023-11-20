using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BoggleSolver
{
    public partial class BoggleSolver : Form
    {
        private const string filePath = "Dictionary.txt";
        private static readonly int selectedWords = 0;
        private static Random random = new Random();

        public BoggleSolver()
        {
            InitializeComponent();
        }

        #region Board
        private void BoggleBoard_Load(object sender, EventArgs e)
        {
            LoadBoard();
        }

        private void LoadBoard()
        {
            this.dataGridView.Rows.Clear();

            string[,] board = CreateBoard();

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

        private static string[,] CreateBoard()
        {
            Random random = new Random();

            List<string> availableLetters = new List<string>();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                availableLetters.Add(c.ToString());
            }

            string[,] board = new string[4, 3];

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

        private void GenerateYourOwnTxtFileButton_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await OpenTxtFile(filePath, 0));
            DeleteTxtContent(filePath);
        }

        private void Button10Words_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await OpenTxtFile(filePath, 10));
            WriteRandomWordsToTxt(filePath, 10);
            UpdateRunBoggleButtonText(10);
        }

        private void Button50Words_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await OpenTxtFile(filePath, 50));
            WriteRandomWordsToTxt(filePath, 50);
            UpdateRunBoggleButtonText(50);
        }

        private void Button100Words_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await OpenTxtFile(filePath, 100));
            WriteRandomWordsToTxt(filePath, 100);
            UpdateRunBoggleButtonText(100);
        }

        private void Button500Words_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await OpenTxtFile(filePath, 500));
            WriteRandomWordsToTxt(filePath, 500);
            UpdateRunBoggleButtonText(500);
        }

        private void Button1000Words_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await OpenTxtFile(filePath, 1000));
            WriteRandomWordsToTxt(filePath, 1000);
            UpdateRunBoggleButtonText(1000);
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            Instructions form = new Instructions();
            form.Show();

            this.Hide();
        }

        private void RunBoggleButton_Click(object sender, EventArgs e)
        {
            if (selectedWords == 0)
            {
                MessageBox.Show("Cannot execute with 0 words");
            }
        }

        #endregion

        private void UpdateRunBoggleButtonText(int selectedWords)
        {
            RunBoggleButton.Text = $"Run BoggleSolver for {selectedWords} words";
        }

        private static void WriteRandomWordsToTxt(string filePath, int selectedWords)
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

        private static void DeleteTxtContent(string filePath)
        {
            try
            {
                // Overwrite the file with an empty string
                File.WriteAllText(filePath, string.Empty);
                Console.WriteLine($"Content of {filePath} deleted.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error deleting file content: {ex.Message}");
            }
        }

        private async Task OpenTxtFile(string filePath, int selectedWords)
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
                if (process != null)
                {
                    await process?.WaitForExitAsync();
                }

                
                Show();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Cannot open text editor.");
            }

            
        }

        private void BoggleSolver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}