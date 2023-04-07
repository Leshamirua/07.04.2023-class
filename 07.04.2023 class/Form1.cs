using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _07._04._2023_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("../../1.txt");
            string text = read.ReadToEnd();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;
            progressBar1.Value = 0;
            string[] words = text.Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            int numWords = words.Length;
            foreach (string word in words)
            {
                richTextBox1.AppendText(" " + word);

            }
            int progressBarValue = numWords;
            progressBar1.Value = progressBarValue;
            read.Close();
            
            

        }
    }
}
