using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace döngüler_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,baslangiç,bitis,artis;
            baslangiç = Convert.ToInt16(textBox1.Text);
            bitis = Convert.ToInt16(textBox2.Text);
            artis = Convert.ToInt16(textBox3.Text);
            for (i = baslangiç; i <= bitis; i += artis)
            {
                listBox1.Items.Add(i);

            }

        }
    }
}
