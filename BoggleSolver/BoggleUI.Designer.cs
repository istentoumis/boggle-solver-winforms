namespace BoggleSolver
{
    partial class BoggleUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoggleUI));
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
            button1 = new Button();
            Hint1 = new PictureBox();
            QuestionMarkToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)RefreshBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hint1).BeginInit();
            SuspendLayout();
            // 
            // RunBoggleButton
            // 
            RunBoggleButton.Location = new Point(313, 404);
            RunBoggleButton.Name = "RunBoggleButton";
            RunBoggleButton.Size = new Size(119, 23);
            RunBoggleButton.TabIndex = 20;
            RunBoggleButton.Text = "Run BoggleSolver";
            RunBoggleButton.UseVisualStyleBackColor = true;
            // 
            // GenerateFileText
            // 
            GenerateFileText.Enabled = false;
            GenerateFileText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateFileText.Location = new Point(302, 222);
            GenerateFileText.Name = "GenerateFileText";
            GenerateFileText.ReadOnly = true;
            GenerateFileText.Size = new Size(153, 22);
            GenerateFileText.TabIndex = 19;
            GenerateFileText.TabStop = false;
            GenerateFileText.Text = "Generate a txt file with:";
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
            // 
            // Button500Words
            // 
            Button500Words.Location = new Point(426, 267);
            Button500Words.Name = "Button500Words";
            Button500Words.Size = new Size(75, 23);
            Button500Words.TabIndex = 17;
            Button500Words.Text = "500 words";
            Button500Words.UseVisualStyleBackColor = true;
            // 
            // Button100Words
            // 
            Button100Words.Location = new Point(345, 267);
            Button100Words.Name = "Button100Words";
            Button100Words.Size = new Size(75, 23);
            Button100Words.TabIndex = 16;
            Button100Words.Text = "100 words";
            Button100Words.UseVisualStyleBackColor = true;
            // 
            // Button50Words
            // 
            Button50Words.Location = new Point(264, 267);
            Button50Words.Name = "Button50Words";
            Button50Words.Size = new Size(75, 23);
            Button50Words.TabIndex = 15;
            Button50Words.Text = "50 words";
            Button50Words.UseVisualStyleBackColor = true;
            // 
            // Button10Words
            // 
            Button10Words.Location = new Point(183, 267);
            Button10Words.Name = "Button10Words";
            Button10Words.Size = new Size(75, 23);
            Button10Words.TabIndex = 14;
            Button10Words.Text = "10 words";
            Button10Words.UseVisualStyleBackColor = true;
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
            BoggleHeaderText.Enabled = false;
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
            // button1
            // 
            button1.Location = new Point(295, 328);
            button1.Name = "button1";
            button1.Size = new Size(160, 23);
            button1.TabIndex = 23;
            button1.Text = "Generate your own txt file";
            button1.UseVisualStyleBackColor = true;
            // 
            // Hint1
            // 
            Hint1.BackgroundImage = Properties.Resources.redo;
            Hint1.Cursor = Cursors.Hand;
            Hint1.Image = (Image)resources.GetObject("Hint1.Image");
            Hint1.Location = new Point(461, 328);
            Hint1.Name = "Hint1";
            Hint1.Size = new Size(26, 26);
            Hint1.SizeMode = PictureBoxSizeMode.StretchImage;
            Hint1.TabIndex = 24;
            Hint1.TabStop = false;
            QuestionMarkToolTip.SetToolTip(Hint1, "Place the words manually, save & close once ready");
            // 
            // BoggleUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Hint1);
            Controls.Add(button1);
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
            Name = "BoggleUI";
            Text = "BoggleUI";
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
        private Button button1;
        private PictureBox Hint1;
        private ToolTip QuestionMarkToolTip;
    }
}