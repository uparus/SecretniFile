using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        bool cleared = true;

        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cleared)
            {
                label2.Visible = true;
                textBox2.Visible = true;

                string s = textBox1.Text;
                StringBuilder sb = new StringBuilder();
                bool inBraket = false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(') inBraket = true;
                    if (!inBraket) sb.Append(s[i]);
                    if (s[i] == ')') inBraket = false;
                }
                button1.Text = "Clear";
                textBox2.Text = sb.ToString();
                cleared = false;
                textBox1.Enabled = false;
            }
            else if (!cleared)
            {
                textBox1.Text = " ";
                button1.Text = "Change";
                textBox1.Enabled = true;
                textBox2.Visible = false;
                label2.Visible = false;

                cleared = true;
            }

        }
    }
}
