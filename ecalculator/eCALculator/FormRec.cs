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
    public partial class FormRec : Form
    {
        public FormRec()
        {
            InitializeComponent();
        }

        private void FormRec_Load(object sender, EventArgs e)
        {
            int pictureNr = rnd.Next(1, 5);

            switch (pictureNr)
            {
                case (1):
                    this.pictureBox1.Image = Properties.Resources.food1;
                    break;
                case (2):
                    this.pictureBox1.Image = Properties.Resources.food2;
                    break;
                case (3):
                    this.pictureBox1.Image = Properties.Resources.food3;
                    break;
                case (4):
                    this.pictureBox1.Image = Properties.Resources.food4;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
