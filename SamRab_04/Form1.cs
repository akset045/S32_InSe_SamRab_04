using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamRab_04
{
    public partial class Form1 : Form
    {
        Transposition t;

        public Form1()
        {
            InitializeComponent();

            t = new Transposition();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.SetKey(textBox3.Text);

            if (radioButton1.Checked)
                textBox2.Text = t.Encrypt(textBox1.Text);
            else
                textBox2.Text = t.Decrypt(textBox1.Text);
        }
    }
}
