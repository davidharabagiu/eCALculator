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
    public partial class WeekPlan : Form
    {
        private User user;
        private int selection = 0;
        private DozaZilnicaRecomandata gda;
         
        public WeekPlan(User user)
        {
            InitializeComponent();
            this.user = user;
            gda = new DozaZilnicaRecomandata(user);
        }

        public double getStatus(double actual,double reccommended)
        {
            if(((actual * 100) / reccommended)>100)
            {
                return 100;
            }
            return (actual * 100) / reccommended;
        }

        public void setPictureFalse()
        {
            if (pictureBox1.Visible = true)
            {
                pictureBox1.Visible = false;
            }
            if (pictureBox2.Visible = true)
            {
                pictureBox2.Visible = false;
            }
            if (pictureBox3.Visible = true)
            {
                pictureBox3.Visible = false;
            }
            if (pictureBox4.Visible = true)
            {
                pictureBox4.Visible = false;
            }
            if (pictureBox5.Visible = true)
            {
                pictureBox5.Visible = false;
            }
            if (pictureBox6.Visible = true)
            {
                pictureBox6.Visible = false;
            }
            if (pictureBox7.Visible = true)
            {
                pictureBox7.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            setPictureFalse();
            pictureBox1.Visible = true;
            selection = 1;
            panel1.Hide();
            textBox1.Text = Convert.ToString(user.getDayDetails(1).Calorii);
            textBox2.Text= Convert.ToString(user.getDayDetails(1).Carbohidrati);
            textBox3.Text= Convert.ToString(user.getDayDetails(1).Proteine);
            textBox4.Text= Convert.ToString(user.getDayDetails(1).Lipide);
            textBox6.Text = Convert.ToString(user.getDayDetails(1).Fibre);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            setPictureFalse();
            pictureBox2.Visible = true;
            panel1.Hide();selection = 2;
            textBox1.Text = Convert.ToString(user.getDayDetails(2).Calorii);
            textBox2.Text = Convert.ToString(user.getDayDetails(2).Carbohidrati);
            textBox3.Text = Convert.ToString(user.getDayDetails(2).Proteine);
            textBox4.Text = Convert.ToString(user.getDayDetails(2).Lipide);
            textBox6.Text = Convert.ToString(user.getDayDetails(2).Fibre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            setPictureFalse();
            pictureBox3.Visible = true;
            panel1.Hide();selection = 3;
            textBox1.Text = Convert.ToString(user.getDayDetails(3).Calorii);
            textBox2.Text = Convert.ToString(user.getDayDetails(3).Carbohidrati);
            textBox3.Text = Convert.ToString(user.getDayDetails(3).Proteine);
            textBox4.Text = Convert.ToString(user.getDayDetails(3).Lipide);
            textBox6.Text = Convert.ToString(user.getDayDetails(3).Fibre);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            setPictureFalse();
            pictureBox4.Visible = true;
            panel1.Hide();selection = 4;
            textBox1.Text = Convert.ToString(user.getDayDetails(4).Calorii);
            textBox2.Text = Convert.ToString(user.getDayDetails(4).Carbohidrati);
            textBox3.Text = Convert.ToString(user.getDayDetails(4).Proteine);
            textBox4.Text = Convert.ToString(user.getDayDetails(4).Lipide);
            textBox6.Text = Convert.ToString(user.getDayDetails(4).Fibre);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            setPictureFalse();
            pictureBox5.Visible = true;
            panel1.Hide();selection = 5;
            textBox1.Text = Convert.ToString(user.getDayDetails(5).Calorii);
            textBox2.Text = Convert.ToString(user.getDayDetails(5).Carbohidrati);
            textBox3.Text = Convert.ToString(user.getDayDetails(5).Proteine);
            textBox4.Text = Convert.ToString(user.getDayDetails(5).Lipide);
            textBox6.Text = Convert.ToString(user.getDayDetails(5).Fibre);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            setPictureFalse();
            pictureBox6.Visible = true;
            panel1.Hide();selection = 6;
            textBox1.Text = Convert.ToString(user.getDayDetails(6).Calorii);
            textBox2.Text = Convert.ToString(user.getDayDetails(6).Carbohidrati);
            textBox3.Text = Convert.ToString(user.getDayDetails(6).Proteine);
            textBox4.Text = Convert.ToString(user.getDayDetails(6).Lipide);
            textBox6.Text = Convert.ToString(user.getDayDetails(6).Fibre);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            setPictureFalse();
            pictureBox7.Visible = true;
            panel1.Hide();selection = 7;
            textBox1.Text = Convert.ToString(user.getDayDetails(7).Calorii);
            textBox2.Text = Convert.ToString(user.getDayDetails(7).Carbohidrati);
            textBox3.Text = Convert.ToString(user.getDayDetails(7).Proteine);
            textBox4.Text = Convert.ToString(user.getDayDetails(7).Lipide);
            textBox6.Text = Convert.ToString(user.getDayDetails(7).Fibre);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            user.setDaiDetails(selection, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox4.Text),Convert.ToDouble(textBox6.Text));
            label6.Visible = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if(textBox6.Text!= "")
            {
                progressBar5.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox6.Text), gda.getFibre()));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox1.Text = Convert.ToString(gda.getCalorii());
            textBox2.Text = Convert.ToString(gda.getCarbohidrati());
            textBox3.Text = Convert.ToString(gda.getProteine());
            textBox4.Text = Convert.ToString(gda.getLipide());
            textBox6.Text = Convert.ToString(gda.getFibre());
            progressBar1.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox1.Text), gda.getCalorii()));
            progressBar2.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox2.Text), gda.getCarbohidrati()));
            progressBar3.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox3.Text), gda.getProteine()));
            progressBar4.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox4.Text), gda.getLipide()));
            progressBar5.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox6.Text), gda.getFibre()));
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                progressBar1.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox1.Text), gda.getCalorii()));
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox1.Text), gda.getCalorii()));
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            progressBar2.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox2.Text), gda.getCarbohidrati()));
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            progressBar3.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox3.Text), gda.getProteine()));
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            progressBar4.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox4.Text), gda.getLipide()));
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            progressBar5.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox6.Text), gda.getFibre()));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text!= "")
            {
                progressBar2.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox2.Text), gda.getCarbohidrati()));
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                progressBar3.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox3.Text), gda.getProteine()));
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text!="")
            {
                progressBar4.Value = Convert.ToInt32(getStatus(Convert.ToDouble(textBox4.Text), gda.getLipide()));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            user.saveUserData();
            label6.Visible = true;
        }
    }
}
