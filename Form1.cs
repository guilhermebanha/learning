namespace learning;
using System;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    ~Form1()
    {
        MessageBox.Show("Form1 disposed");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form2 f2 = new Form2(textBox1.Text,textBox2.Text);
        f2.ShowDialog();
        this.Close();
    }
}
