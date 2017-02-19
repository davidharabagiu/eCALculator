using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCALculator
{
    public partial class FormShape : Form
    {
        private double greutateIdeala;
        private double inaltime;
        private double varsta;
        private double greutate;

        public FormShape()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            greutate = double.Parse(greutateBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            inaltime = double.Parse(inaltimeBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            varsta = double.Parse(varstaBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            double g1;
            double g2;
            if (radioButton1.Checked == true)
            {
                g1 = (inaltime - 150) / 4;
                g2 = (varsta - 20) / 4;
            }
            else
            {
                g1 = (inaltime - 150) / 2.5;
                g2 = (varsta - 20) / 6;
            }
            
            greutateIdeala = inaltime - 100 - (g1 + g2);


            if (greutate <= greutateIdeala)
            {
                label6.Visible = true;
                pictureBox1.Visible = true;
                ideal.Visible = true;
                label8.Visible = true;
                label8.Text = Math.Round(greutateIdeala, 2).ToString() + " kg";
                double diferenta = greutateIdeala - greutate;
                double nr = (diferenta * 100) / greutateIdeala;
                int procentaj = (int)(100 - nr);
                progressBar1.Visible = true;
                progressBar1.Value = procentaj;
                label9.Visible = true;
            }
            else
            {
                label7.Visible = true;
                pictureBox2.Visible = true;
                ideal.Visible = true;
                label8.Visible = true;
                label8.Text = Math.Round(greutateIdeala,2).ToString() + " kg";
                double diferenta = greutate - greutateIdeala;
                double nr = (diferenta * 100) / (double)greutate;
                int proc = (int)(100 - nr);
                progressBar1.Visible = true;
                progressBar1.Value = proc;
                label9.Visible = true;
            }
        }

        private void FormShape_Load(object sender, EventArgs e)
        {
            User user = new User();
            greutateBox.Text = user.Weight.ToString();
            varstaBox.Text = user.Age.ToString();
            inaltimeBox.Text = user.Height.ToString();
            if (user.Gender == "Barbat")
                radioButton1.Checked = true;
            else if (user.Gender == "Femeie")
                radioButton2.Checked = true;
        }
    }
}

