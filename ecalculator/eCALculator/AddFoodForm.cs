using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace eCALculator
{
    public partial class AddFoodForm : Form
    {
        public AddFoodForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

            string connectionString = "SERVER=localhost;DATABASE=nutrition;UID=root;PASSWORD=amdoar1coi;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO food(name,calories,proteins,carbs,sugars,picture) VALUES('";
            cmd.CommandText += textBox1.Text;
            cmd.CommandText += "',";
            cmd.CommandText += textBox2.Text;
            cmd.CommandText += ",";
            cmd.CommandText += textBox3.Text;
            cmd.CommandText += ",";
            cmd.CommandText += textBox4.Text;
            cmd.CommandText += ",";
            cmd.CommandText += textBox5.Text;
            cmd.CommandText += ",";
            cmd.CommandText += "0x";
            cmd.CommandText += img;
            cmd.CommandText += ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
