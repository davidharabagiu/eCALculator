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
    public partial class FirstSetup : Form
    {
       private User user;
       private string fname, lname, gender;
       private  double weight, height;
        private int age;

        private void button2_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lname = textBox2.Text;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            age = Convert.ToInt32(textBox3.Text);
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                gender = "Barbat";
            }
            if(radioButton2.Checked==true)
            {
                gender = "Femeie";
            }
            panel5.Visible = false;
            panel6.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                radioButton1.Checked = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            weight = Convert.ToDouble(textBox4.Text);
            panel6.Visible = false;
            panel7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            height = Convert.ToDouble(textBox5.Text);
            panel7.Visible = false;
            panel8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            user = new User(fname, lname, gender, age, weight, height);
            this.Hide();
            Form f = new WeekPlan(user);
            f.ShowDialog();
        }

        private void FirstSetup_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, 0);
            panel3.Location = new Point(0, 0);
            panel4.Location = new Point(0, 0);
            panel5.Location = new Point(0, 0);
            panel6.Location = new Point(0, 0);
            panel7.Location = new Point(0, 0);
            panel8.Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        public FirstSetup()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
