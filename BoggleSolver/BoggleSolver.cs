namespace BoggleSolver
{
    public partial class BoggleSolver : Form
    {
        public BoggleSolver()
        {
            InitializeComponent();
        }

        private void BoggleBoard_Load(object sender, EventArgs e)
        {
            LoadBoard();
        }

        private void RefreshBoard_Click(object sender, EventArgs e)
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

        private void BoggleUI_Click(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            Instructions form = new Instructions();
            form.Show();

            this.Hide();
        }

        private void BoggleSolver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}