using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning
{
    public partial class Form2 : Form
    {
        public Form2(string a, string b)
        {
            InitializeComponent();
            Label l1 = new Label();
            l1.Location = new Point(100, 100);
            l1.Text = a;
            Label l2 = new Label();
            l2.Location = new Point(100, 200);
            l2.Text = b;
            Controls.Add(l1);
            Controls.Add(l2);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
