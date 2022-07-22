using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked New");
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) {
                MessageBox.Show(openFileDialog1.FileName);
            }
            else
            {
                return;
            }
        }

        private void foreGroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.ForeColor = colorDialog1.Color;
            }
        }

        private void backGroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void foregroundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Button btn = (Button) contextMenuStrip1.SourceControl;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn.ForeColor = colorDialog1.Color;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        
        }

        private void backGroundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)contextMenuStrip1.SourceControl;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog1.Color;
            }
        }
    }
}
