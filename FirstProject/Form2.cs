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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    button2 = new System.Windows.Forms.Button();
                    button2.Location = new System.Drawing.Point(100 + i * 50, 100 + j * 50);
                    button2.Name = "button2";
                    button2.Size = new System.Drawing.Size(50, 50);
                    button2.Text = (i+(j-1)*10).ToString();
                    button2.Click += new System.EventHandler(this.OurButtonClick);
                    this.Controls.Add(button2);
                }
            }
        }
        private void OurButtonClick(object sender, EventArgs e)
        {
            Button mybutton;
            mybutton = (Button) sender;
            int sum = Int32.Parse(txtSum.Text);
            sum = sum + Int32.Parse(mybutton.Text);
            txtSum.Text = sum.ToString();
            MessageBox.Show(mybutton.Text);

        }
        private System.Windows.Forms.Button button2;
    }
}
 
 
 
