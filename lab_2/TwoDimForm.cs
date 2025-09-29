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
    public partial class TwoDimForm : Form
    {
        Array2D arr;

        public TwoDimForm()
        {
            InitializeComponent();
            arr = new Array2D();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string line in arr.ToStringArray())
            {
                listBox1.Items.Add(line);
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int sum = arr.SumOddIndexes();
            label1.Text = "Sum: " + sum.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

    }
}
