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
    public partial class EMailPrompt : Form
    {
        public string EMail;

        public EMailPrompt()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EMail = textBox1.Text;
        }
    }
}
