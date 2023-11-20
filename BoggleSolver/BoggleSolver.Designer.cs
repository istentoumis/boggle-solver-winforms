namespace BoggleSolver
{
    partial class BoggleSolver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoggleSolver));
            RunBoggleButton = new Button();
            GenerateFileText = new TextBox();
            Button1000Words = new Button();
            Button500Words = new Button();
            Button100Words = new Button();
            Button50Words = new Button();
            Button10Words = new Button();
            RefreshBoard = new PictureBox();
            BoggleHeaderText = new TextBox();
            dataGridView = new DataGridView();
            GenerateTxtFileButton = new Button();
            Hint1 = new PictureBox();
            QuestionMarkToolTip = new ToolTip(components);
            InstructionsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)RefreshBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hint1).BeginInit();
            SuspendLayout();
            // 
            // RunBoggleButton
            // 
            RunBoggleButton.Location = new Point(264, 404);
            RunBoggleButton.Name = "RunBoggleButton";
            RunBoggleButton.Size = new Size(222, 23);
            RunBoggleButton.TabIndex = 20;
            RunBoggleButton.Text = "Run BoggleSolver for 0 words";
            RunBoggleButton.UseVisualStyleBackColor = true;
            RunBoggleButton.Click += RunBoggleButton_Click;
            // 
            // GenerateFileText
            // 
            GenerateFileText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateFileText.Location = new Point(302, 222);
            GenerateFileText.Name = "GenerateFileText";
            GenerateFileText.ReadOnly = true;
            GenerateFileText.Size = new Size(153, 22);
            GenerateFileText.TabIndex = 19;
            GenerateFileText.TabStop = false;
            GenerateFileText.Text = "Generate a Dictionary with:";
            GenerateFileText.TextAlign = HorizontalAlignment.Center;
            // 
            // Button1000Words
            // 
            Button1000Words.Location = new Point(507, 267);
            Button1000Words.Name = "Button1000Words";
            Button1000Words.Size = new Size(75, 23);
            Button1000Words.TabIndex = 18;
            Button1000Words.Text = "1000 words";
            Button1000Words.UseVisualStyleBackColor = true;
            Button1000Words.Click += Button1000Words_Click;
            // 
            // Button500Words
            // 
            Button500Words.Location = new Point(426, 267);
            Button500Words.Name = "Button500Words";
            Button500Words.Size = new Size(75, 23);
            Button500Words.TabIndex = 17;
            Button500Words.Text = "500 words";
            Button500Words.UseVisualStyleBackColor = true;
            Button500Words.Click += Button500Words_Click;
            // 
            // Button100Words
            // 
            Button100Words.Location = new Point(345, 267);
            Button100Words.Name = "Button100Words";
            Button100Words.Size = new Size(75, 23);
            Button100Words.TabIndex = 16;
            Button100Words.Text = "100 words";
            Button100Words.UseVisualStyleBackColor = true;
            Button100Words.Click += Button100Words_Click;
            // 
            // Button50Words
            // 
            Button50Words.Location = new Point(264, 267);
            Button50Words.Name = "Button50Words";
            Button50Words.Size = new Size(75, 23);
            Button50Words.TabIndex = 15;
            Button50Words.Text = "50 words";
            Button50Words.UseVisualStyleBackColor = true;
            Button50Words.Click += Button50Words_Click;
            // 
            // Button10Words
            // 
            Button10Words.Location = new Point(183, 267);
            Button10Words.Name = "Button10Words";
            Button10Words.Size = new Size(75, 23);
            Button10Words.TabIndex = 14;
            Button10Words.Text = "10 words";
            Button10Words.UseVisualStyleBackColor = true;
            Button10Words.Click += Button10Words_Click;
            // 
            // RefreshBoard
            // 
            RefreshBoard.BackgroundImage = Properties.Resources.redo;
            RefreshBoard.Cursor = Cursors.Hand;
            RefreshBoard.Image = Properties.Resources.redo;
            RefreshBoard.Location = new Point(532, 127);
            RefreshBoard.Name = "RefreshBoard";
            RefreshBoard.Size = new Size(26, 26);
            RefreshBoard.SizeMode = PictureBoxSizeMode.StretchImage;
            RefreshBoard.TabIndex = 13;
            RefreshBoard.TabStop = false;
            RefreshBoard.Click += RefreshBoard_Click;
            // 
            // BoggleHeaderText
            // 
            BoggleHeaderText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BoggleHeaderText.Location = new Point(302, 51);
            BoggleHeaderText.Name = "BoggleHeaderText";
            BoggleHeaderText.ReadOnly = true;
            BoggleHeaderText.Size = new Size(153, 39);
            BoggleHeaderText.TabIndex = 12;
            BoggleHeaderText.TabStop = false;
            BoggleHeaderText.Text = "Boggle Board";
            BoggleHeaderText.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.Location = new Point(246, 96);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(271, 79);
            dataGridView.TabIndex = 11;
            // 
            // GenerateTxtFileButton
            // 
            GenerateTxtFileButton.Location = new Point(288, 328);
            GenerateTxtFileButton.Name = "GenerateTxtFileButton";
            GenerateTxtFileButton.Size = new Size(182, 23);
            GenerateTxtFileButton.TabIndex = 23;
            GenerateTxtFileButton.Text = "Generate your own Dictionary";
            GenerateTxtFileButton.UseVisualStyleBackColor = true;
            GenerateTxtFileButton.Click += GenerateYourOwnDictionaryFileButton_Click;
            // 
            // Hint1
            // 
            Hint1.BackgroundImage = Properties.Resources.redo;
            Hint1.Cursor = Cursors.Hand;
            Hint1.Image = (Image)resources.GetObject("Hint1.Image");
            Hint1.Location = new Point(461, 218);
            Hint1.Name = "Hint1";
            Hint1.Size = new Size(26, 26);
            Hint1.SizeMode = PictureBoxSizeMode.StretchImage;
            Hint1.TabIndex = 24;
            Hint1.TabStop = false;
            QuestionMarkToolTip.SetToolTip(Hint1, "Save & close once ready");
            // 
            // InstructionsButton
            // 
            InstructionsButton.Location = new Point(690, 404);
            InstructionsButton.Name = "InstructionsButton";
            InstructionsButton.Size = new Size(82, 23);
            InstructionsButton.TabIndex = 25;
            InstructionsButton.Text = "Instructions";
            InstructionsButton.UseVisualStyleBackColor = true;
            InstructionsButton.Click += InstructionsButton_Click;
            // 
            // BoggleSolver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InstructionsButton);
            Controls.Add(Hint1);
            Controls.Add(GenerateTxtFileButton);
            Controls.Add(RunBoggleButton);
            Controls.Add(GenerateFileText);
            Controls.Add(Button1000Words);
            Controls.Add(Button500Words);
            Controls.Add(Button100Words);
            Controls.Add(Button50Words);
            Controls.Add(Button10Words);
            Controls.Add(RefreshBoard);
            Controls.Add(BoggleHeaderText);
            Controls.Add(dataGridView);
            Name = "BoggleSolver";
            Text = "BoggleSolver";
            FormClosed += BoggleSolver_FormClosed;
            Load += BoggleBoard_Load;
            Click += BoggleUI_Click;
            ((System.ComponentModel.ISupportInitialize)RefreshBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hint1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button RunBoggleButton;
        private TextBox GenerateFileText;
        private Button Button1000Words;
        private Button Button500Words;
        private Button Button100Words;
        private Button Button50Words;
        private Button Button10Words;
        private PictureBox RefreshBoard;
        private TextBox BoggleHeaderText;
        private DataGridView dataGridView;
        private Button GenerateTxtFileButton;
        private PictureBox Hint1;
        private ToolTip QuestionMarkToolTip;
        private Button InstructionsButton;
    }
}