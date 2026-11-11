using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cleared)
            {
                textBox2.Visible = true;
                label2.Visible = true;

                string s = textBox1.Text;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1]) sb.Append(s[i]);
                    else sb.Append(s[i] + "*");
                }
                sb.Append(s[s.Length - 1]);
                textBox2.Text = sb.ToString();
                button1.Text = "Clear";
                textBox1.Enabled = false;
                cleared = false;
            }
            else if (!cleared)
            {
                textBox1.Text = " ";
                button1.Text = "Change";
                textBox1.Enabled = true;
                textBox2.Visible = false;
                label2.Visible = false;

                cleared = true; ;
            }
        }
    }
}
