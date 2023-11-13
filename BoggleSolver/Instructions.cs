using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BoggleSolver
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            BoggleSolver boggleSolver = new BoggleSolver();
            boggleSolver.Show();
            this.Hide();
        }

        private void Instructions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            InstructionsText.TabStop = false;
        }
    }
}
