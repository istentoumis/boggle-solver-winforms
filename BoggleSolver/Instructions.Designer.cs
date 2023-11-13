namespace BoggleSolver
{
    partial class Instructions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            contextMenuStrip1 = new ContextMenuStrip(components);
            InstructionsText = new TextBox();
            BackButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // InstructionsText
            // 
            InstructionsText.Location = new Point(188, 12);
            InstructionsText.Multiline = true;
            InstructionsText.Name = "InstructionsText";
            InstructionsText.ReadOnly = true;
            InstructionsText.Size = new Size(422, 39);
            InstructionsText.TabIndex = 1;
            InstructionsText.Text = "-You can move from one letter to another if it is a neighbour (in all directions)\r\n-You cannot use a letter more than once in a word";
            // 
            // BackButton
            // 
            BackButton.ForeColor = SystemColors.ControlText;
            BackButton.Location = new Point(21, 402);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.example1;
            pictureBox1.Location = new Point(232, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(232, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BackButton);
            Controls.Add(InstructionsText);
            ForeColor = SystemColors.ButtonFace;
            Name = "Instructions";
            Text = "Instructions";
            FormClosed += Instructions_FormClosed;
            Load += Instructions_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox InstructionsText;
        private Button BackButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}