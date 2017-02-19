using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace FoodEditor
{
    public partial class Form1 : Form
    {
        private List<int> catIDList;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "";
            dlg.Title = "Open Image";
            dlg.Filter = "JPG Image(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = dlg.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Nu ai selectat categoria", "ESTI UN BOU!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    FileInfo f = new FileInfo(textBox6.Text);
                    string img = string.Empty;
                    BinaryReader reader = new BinaryReader(File.Open(textBox6.Text, FileMode.Open));
                    byte[] buffer = new byte[f.Length];
                    buffer = reader.ReadBytes((int)f.Length);
                    for (int i = 0; i < buffer.Length; ++i)
                    {
                        int ln = buffer[i] % 16;
                        int fn = (buffer[i] / 16) % 16;
                        if (fn < 10)
                            fn += '0';
                        else
                            fn += 'A' - 10;
                        if (ln < 10)
                            ln += '0';
                        else
                            ln += 'A' - 10;
                        img += (char)fn;
                        img += (char)ln;
                    }

                    reader.Close();

                    string connectionString = "SERVER=130.211.50.66;DATABASE=nutrition;UID=root;PASSWORD=qwerty123;";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO food(name,calories,proteins,carbs,picture,lipids,fibers) VALUES('";
                    cmd.CommandText += txtName.Text;
                    cmd.CommandText += "',";
                    cmd.CommandText += txtCalories.Text;
                    cmd.CommandText += ",";
                    cmd.CommandText += txtProteins.Text;
                    cmd.CommandText += ",";
                    cmd.CommandText += txtCarbs.Text;
                    cmd.CommandText += ",";
                    cmd.CommandText += "0x";
                    cmd.CommandText += img;
                    cmd.CommandText += ",";
                    cmd.CommandText += txtLipids.Text;
                    cmd.CommandText += ",";
                    cmd.CommandText += txtFibers.Text;
                    cmd.CommandText += ")";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                    MySqlConnection connection2 = new MySqlConnection(connectionString);
                    connection2.Open();
                    MySqlCommand cmd2 = new MySqlCommand("SELECT MAX(id) AS id FROM food", connection2);
                    MySqlDataReader dreader = cmd2.ExecuteReader();
                    dreader.Read();

                    foreach (int item in listBox1.CheckedIndices)
                    {
                        cmd.CommandText = "INSERT INTO food_category(food_id,cat_id) VALUES(" + dreader["id"].ToString() + "," + catIDList[item] + ")";
                        cmd.ExecuteNonQuery();
                    }

                    dreader.Close();
                    connection.Close();
                    connection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ESTI UN BOU!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            catIDList = new List<int>();

            string connectionString = "SERVER=130.211.50.66;DATABASE=nutrition;UID=root;PASSWORD=qwerty123;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM category";
            cmd.Connection = connection;
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                catIDList.Add(Convert.ToInt32(dataReader["id"]));
                listBox1.Items.Add(dataReader["name"].ToString());
            }

            dataReader.Close();
            connection.Close();
        }
    }
}
