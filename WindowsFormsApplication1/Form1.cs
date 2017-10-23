using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            string str = textBox1.Text;
            bool ok = int.TryParse(str, out a);
            if ((ok) & (a>0))
                label2.Text = Class1.CowConter(a);
            else
                label2.Text = "Ввведите корректное число";
            

        }
    }
}
