namespace BoggleSolver
{
    public partial class BoggleUI : Form
    {
        public BoggleUI()
        {
            InitializeComponent();
        }

        private void BoggleBoard_Load(object sender, EventArgs e)
        {

            string[,] board = new string[,]
            {
                { "A", "B", "C"},
                { "D", "E", "F"},
                { "G", "H", "I"},
                { "J", "K", "L"},
            };

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

        private void BoggleUI_Click(object sender, EventArgs e)
        {
            // Clear the selection in the DataGridView
            dataGridView.ClearSelection();
        }
    }
}