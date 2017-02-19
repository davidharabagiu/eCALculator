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
    public partial class ChangeUserData : Form
    {
        User user;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public ChangeUserData(User user)
        {
            InitializeComponent();
            this.user = user;
            textBox1.Text = user.Fname;
            textBox2.Text = user.Lname;
            textBox3.Text = Convert.ToString(user.Age);
            textBox4.Text = Convert.ToString(user.Weight);
            textBox5.Text = Convert.ToString(user.Height);
        }

        private void ChangeUserData_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Fname = textBox1.Text;
            user.Lname = textBox2.Text;
            user.Age = Convert.ToInt32(textBox3.Text);
            user.Weight = Convert.ToDouble(textBox4.Text);
            user.Height = Convert.ToDouble(textBox5.Text);
            user.saveUserData();
        }
    }
}
