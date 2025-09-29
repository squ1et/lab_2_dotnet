using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class OneDimForm : Form
    {
        public OneDimForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                char letter = textBox1.Text[0];  

                Array1D arr = new Array1D(10);   
                arr.FilterLetter = letter;      

                string result = arr.Show;    

                listBox1.Items.Clear();
                foreach (var name in result.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries))
                {
                    listBox1.Items.Add(name);
                }
            }
            else
            {
                MessageBox.Show("Введіть літеру!");
            }
        }

    }
}
