using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obfuscator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = Obfuscate(richTextBox1.Text);
        }

        public string Obfuscate(string input)
        {
            var arr = input.Split(new[] { '\n', '\t' });
            string output = "";
            foreach (var str in arr)
            {
                string res = str.Trim();
                if (str.Contains("//")) res = str.Split(new[] { "//" }, StringSplitOptions.None)[0];
                output += res;
            }
            return output;
        }
    }
}
