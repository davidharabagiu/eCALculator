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
    public partial class formFilter : Form
    {
        List<Aliment> list = new List<Aliment>();
        public List<Aliment> newList = new List<Aliment>();
        public formFilter(List<Aliment> x)
        {
            list = x.ToList();
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newList.Clear();
         
            for(int i = 0; i <list.Count; i++)
            {
                if(!checkBox1.Checked || list[i].Calories < Int32.Parse(textBox1.Text) && checkBox1.Checked)
                {
                    if(!checkBox2.Checked || list[i].Proteins < Int32.Parse(textBox2.Text) && checkBox2.Checked)
                    {
                        if(!checkBox3.Checked || list[i].Carbs < Int32.Parse(textBox3.Text) && checkBox3.Checked)
                        {
                            if(!checkBox4.Checked || list[i].Lipids < Int32.Parse(textBox4.Text) && checkBox4.Checked)
                            {
                                if(!checkBox5.Checked || list[i].Fibers < Int32.Parse(textBox5.Text) && checkBox5.Checked)
                                {
                                    newList.Add(list[i]);
                                }
                            }
                        }
                    }
                }
            }
            List<int> x = new List<int>();
            for(int i = 0; i < newList.Count(); i++)
            {
                x.Add(newList[i].ID);
            }



        }
    }
}
