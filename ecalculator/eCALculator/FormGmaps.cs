using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCALculator
{
    public partial class FormGmaps : Form
    {
        public FormGmaps()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://maps.google.ro");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city="gym" + textBox1.Text;
            string country=textBox2.Text;
            string state=textBox3.Text;

            StringBuilder add = new StringBuilder("http://maps.google.com/maps?q=");
                add.Append(city);
            add.Append(state);
            add.Append(country);

            webBrowser1.Navigate(add.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
