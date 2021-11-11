using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempratureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int text = int.Parse(textBox1.Text);
            double farenhiet = text * (9 / 5) + 32;
            String f = farenhiet.ToString();
            label3.Text = $"Converted Value In Farenheit Is : {f}°";
        }
    }
}
