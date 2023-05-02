using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bin2Dec_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //This bit gives a warning if you e
            Regex regex = new Regex(@"[^0-1]");
            MatchCollection matches = regex.Matches(textBox1.Text);
            if (matches.Count > 0)
            {
                textBox1.Text = "";
                MessageBox.Show("Please enter only 1 or 0 in this field.", "Non-Binary value entered",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        public void button1_Click(object sender, EventArgs e)
        {
            
            int Bnumber1 = Convert.ToInt32(textBox1.Text);

            int Dnumber1 = 0;
            int base1 = 1;

            while (Bnumber1 > 0)
            {
                int reminder = Bnumber1 % 10;
                Bnumber1 = Bnumber1 / 10;
                Dnumber1 += reminder * base1;
                base1 = base1 * 2;
            }

            textBox2.Text = "" + Dnumber1;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
