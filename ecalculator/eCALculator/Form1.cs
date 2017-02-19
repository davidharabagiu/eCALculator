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
using EASendMail;

namespace eCALculator
{
    public partial class Form1 : Form
    {
        private ImageList imgList;
        private Dictionary<string, FoodCategory> categories;
        private List<Aliment> aliments;
        private List<Aliment> filteredAliments;
        private List<Aliment> eatenAliments;
        private List<int> eatenQuantities;
        private int selectedCategory = -1;
        private string[] workoutLines;

        float currentCalories;
        float currentProteins;
        float currentCarbs;
        float currentLipids;
        float currentFibers;

        private bool enableEasterEgg;

        private FormRec popup;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFoodForm f = new AddFoodForm();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("days"))
                Directory.CreateDirectory("days");
            if (!Directory.Exists("conf"))
                Directory.CreateDirectory("conf");
            if (!Directory.Exists("img"))
                Directory.CreateDirectory("img");

            if (!File.Exists(@"conf\user.txt"))
            {
                FirstSetup fs = new FirstSetup();
                if (fs.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.FirstRun = false;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Application.Exit();
                }
            }

            eatenQuantities = new List<int>();
            eatenAliments = new List<Aliment>();

            aliments = filteredAliments = new List<Aliment>();
            listCategories.Items.Add("All categories");
            categories = new Dictionary<string, FoodCategory>();
            imgList = new ImageList();
            imgList.ImageSize = new Size(80, 80);

            List<int> did = new List<int>();
            List<string> dnames = new List<string>();
            List<float> dcals = new List<float>();
            List<float> dprots = new List<float>();
            List<float> dcarbs = new List<float>();
            List<float> dlipids = new List<float>();
            List<float> dfibers = new List<float>();
            List<byte[]> dpics = new List<byte[]>();

            string connectionString = "SERVER=localhost;DATABASE=nutrition;UID=ecalculator;PASSWORD=12345;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM food";
            cmd.Connection = connection;
            MySqlDataReader dataReader = cmd.ExecuteReader();
            
            while (dataReader.Read())
            {
                dnames.Add(dataReader["name"].ToString());
                did.Add(Convert.ToInt32(dataReader["id"]));
                dcals.Add((float)Convert.ToDouble(dataReader["calories"]));
                dprots.Add((float)Convert.ToDouble(dataReader["proteins"]));
                dcarbs.Add((float)Convert.ToDouble(dataReader["carbs"]));
                dlipids.Add((float)Convert.ToDouble(dataReader["lipids"]));
                dfibers.Add((float)Convert.ToDouble(dataReader["fibers"]));
                dpics.Add((byte[])dataReader["picture"]);
            }

            dataReader.Close();

            listAllFoods.LargeImageList = imgList;

            for (int i = 0; i < dnames.Count; ++i)
            {
                BinaryWriter w = new BinaryWriter(File.OpenWrite("img\\a" + i + ".jpg"));
                w.Write(dpics[i]);
                w.Close();
                imgList.Images.Add(Image.FromFile("img\\a" + i + ".jpg"));
                Aliment a = new Aliment(did[i], dnames[i], i, dcals[i], dprots[i], dcarbs[i], dlipids[i], dfibers[i]);
                aliments.Add(a);
            }

            connection.Close();

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM category";
            cmd.Connection = connection;
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                listCategories.Items.Add(dataReader["name"].ToString());
                categories.Add(dataReader["name"].ToString(), new FoodCategory(dataReader["name"].ToString()));
            }

            dataReader.Close();
            connection.Close();

            foreach (Aliment i in aliments)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                cmd = new MySqlCommand();
                cmd.CommandText = "SELECT category.name FROM food JOIN food_category ON (food.id = food_category.food_id) JOIN category ON (category.id = food_category.cat_id) WHERE food.id=";
                cmd.CommandText += i.ID;
                cmd.Connection = connection;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    categories[dataReader["name"].ToString()].AddAliment(i.ID);
                }
                dataReader.Close();
                connection.Close();
            }

            AddAllAlimentsToListView();

            ReadFromFile();

            RefreshGoals();

            workoutLines = File.ReadAllText(@"conf\sports.txt").Split('\n');

            timer2.Start();
        }

        private void AddAllAlimentsToListView()
        {
            foreach(Aliment a in filteredAliments)
            {
                listAllFoods.Items.Add(a);
            }
        }

        private void ApplyFilters()
        {
            if (selectedCategory <= 0)
            {
                listAllFoods.Items.Clear();
                AddAllAlimentsToListView();
            }
            else if (selectedCategory >= 1)
            {
                listAllFoods.Items.Clear();
                foreach (int alID in categories[listCategories.SelectedItem.ToString()].Aliments)
                {
                    foreach (Aliment al in filteredAliments)
                    {
                        if (al.ID == alID)
                            listAllFoods.Items.Add(al);
                    }
                }
            }

            if (txtSearch.Text != "")
            {
                for (int i = listAllFoods.Items.Count - 1; i >= 0; --i)
                {
                    if (!((Aliment)listAllFoods.Items[i]).FoodName.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listAllFoods.Items.Remove(listAllFoods.Items[i]);
                    }
                }
            }
        }

        private void listAllFoods_DoubleClick(object sender, EventArgs e)
        {
            if (listAllFoods.SelectedIndices.Count > 0)
            {
                AddToEaten((Aliment)listAllFoods.SelectedItems[0], Convert.ToInt32(textQuantity.Text), true);
                if (((Aliment)listAllFoods.SelectedItems[0]).FoodName == "Shaorma")
                {
                    Utils.shaorma();
                    Utils.SetWallpaper(Application.StartupPath + @"\conf\fatshaming.jpg");
                }
            }
        }

        private void AddToEaten(Aliment a, int quantity, bool addInFile)
        {
            ListViewItem pula = new ListViewItem(a.FoodName);
            pula.SubItems.Add(quantity.ToString());

            float calPer100 = a.Calories;
            float protPer100 = a.Proteins;
            float carbsPer100 = a.Carbs;
            float lipidsPer100 = a.Lipids;
            float fibersPer100 = a.Fibers;

            pula.SubItems.Add(Math.Round(calPer100 * quantity / 100, 2).ToString());
            pula.SubItems.Add(Math.Round(protPer100 * quantity / 100, 2).ToString());
            pula.SubItems.Add(Math.Round(carbsPer100 * quantity / 100, 2).ToString());
            pula.SubItems.Add(Math.Round(lipidsPer100 * quantity / 100, 2).ToString());
            pula.SubItems.Add(Math.Round(fibersPer100 * quantity / 100, 2).ToString());

            listEaten.Items.Add(pula);

            UpdateStats();
            RefreshGoals();

            eatenAliments.Add(a);
            eatenQuantities.Add(quantity);

            if (addInFile)
                Aliment.addFoodInFile(eatenAliments, eatenQuantities,
                    new float[] { currentCalories, currentProteins, currentCarbs, currentLipids, currentFibers });
        }

        private void listCategories_Click(object sender, EventArgs e)
        {
            if (listCategories.SelectedIndex >= 0)
            {
                selectedCategory = listCategories.SelectedIndex;
                ApplyFilters();
            }
                
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void UpdateStats()
        {
            float calories = 0;
            float proteins = 0;
            float carbs = 0;
            float lipids = 0;
            float fibers = 0;

            foreach (ListViewItem i in listEaten.Items)
            {
                calories += Convert.ToSingle(i.SubItems[2].Text);
                proteins += Convert.ToSingle(i.SubItems[3].Text);
                carbs += Convert.ToSingle(i.SubItems[4].Text);
                lipids += Convert.ToSingle(i.SubItems[5].Text);
                fibers += Convert.ToSingle(i.SubItems[6].Text);
            }

            labelCalories.Text = calories.ToString();
            labelProteins.Text = proteins.ToString();
            labelCarbs.Text = carbs.ToString();
            labelLipids.Text = lipids.ToString();
            labelFibers.Text = fibers.ToString();

            currentCalories = calories;
            currentProteins = proteins;
            currentCarbs = carbs;
            currentLipids = lipids;
            currentFibers = fibers;
        }

        private void listEaten_DoubleClick(object sender, EventArgs e)
        {
            if (listEaten.SelectedIndices.Count > 0)
            {
                int toRemove = listEaten.SelectedIndices[0];
                listEaten.Items.RemoveAt(toRemove);
                eatenAliments.RemoveAt(toRemove);
                eatenQuantities.RemoveAt(toRemove);
                UpdateStats();
                RefreshGoals();
                Aliment.addFoodInFile(eatenAliments, eatenQuantities,
                    new float[] { currentCalories, currentProteins, currentCarbs, currentLipids, currentFibers });
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormShape f = new FormShape();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formFilter f = new formFilter(aliments);
            if (f.ShowDialog() ==DialogResult.OK)
            {
                filteredAliments = f.newList;
                ApplyFilters();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WeekPlan wp = new WeekPlan(new User());
            wp.ShowDialog();
            RefreshGoals();
        }

        private void RefreshGoals()
        {
            User user = new User();
            DayOfWeek day = DateTime.Today.DayOfWeek;
            int dayNumber = 1;
            switch(day)
            {
                case DayOfWeek.Monday:
                    dayNumber = 1;
                    break;
                case DayOfWeek.Tuesday:
                    dayNumber = 2;
                    break;
                case DayOfWeek.Wednesday:
                    dayNumber = 3;
                    break;
                case DayOfWeek.Thursday:
                    dayNumber = 4;
                    break;
                case DayOfWeek.Friday:
                    dayNumber = 5;
                    break;
                case DayOfWeek.Saturday:
                    dayNumber = 6;
                    break;
                case DayOfWeek.Sunday:
                    dayNumber = 7;
                    break;
            }
            float goalCalories = (float)user.getDayDetails(dayNumber).Calorii;
            float goalProteins = (float)user.getDayDetails(dayNumber).Proteine;
            float goalCarbs = (float)user.getDayDetails(dayNumber).Carbohidrati;
            float goalLipids = (float)user.getDayDetails(dayNumber).Lipide;
            float goalFibers = (float)user.getDayDetails(dayNumber).Fibre;
            if (goalCalories > 0)
            {
                progressCalories.Visible = true;
                labelGoalCalories.Visible = true;
                label10.Visible = true;
                progressCalories.Value = (int)Math.Min(100, currentCalories / goalCalories * 100);
                labelGoalCalories.Text = goalCalories.ToString();
                if (currentCalories > goalCalories)
                {
                    timer1.Start();
                    button6.Visible = true;
                    labelWarningCalories.Visible = true;
                    enableEasterEgg = true;
                }
                else
                {
                    timer1.Stop();
                    button6.Visible = false;
                    labelWarningCalories.Visible = false;
                    enableEasterEgg = false;
                }
            }
            else
            {
                progressCalories.Visible = false;
                labelGoalCalories.Visible = false;
                labelWarningCalories.Visible = false;
                label10.Visible = false;
                timer1.Stop();
            }
            if (goalProteins > 0)
            {
                progressProteins.Visible = true;
                labelGoalProteins.Visible = true;
                label11.Visible = true;
                progressProteins.Value = (int)Math.Min(100, currentProteins / goalProteins * 100);
                labelGoalProteins.Text = goalProteins.ToString();
                if (currentProteins > goalProteins)
                    labelWarningProteins.Visible = true;
                else
                    labelWarningProteins.Visible = false;
            }
            else
            {
                progressProteins.Visible = false;
                labelGoalProteins.Visible = false;
                labelWarningProteins.Visible = false;
                label11.Visible = false;
            }
            if (goalCarbs > 0)
            {
                progressCarbs.Visible = true;
                labelGoalCarbs.Visible = true;
                label12.Visible = true;
                progressCarbs.Value = (int)Math.Min(100, currentCarbs / goalCarbs * 100);
                labelGoalCarbs.Text = goalCarbs.ToString();
                if (currentCarbs > goalCarbs)
                    labelWarningCarbs.Visible = true;
                else
                    labelWarningCarbs.Visible = false;
            }
            else
            {
                progressCarbs.Visible = false;
                labelGoalCarbs.Visible = false;
                labelWarningCarbs.Visible = false;
                label12.Visible = false;
            }
            if (goalLipids > 0)
            {
                progressLipids.Visible = true;
                labelGoalLipids.Visible = true;
                label13.Visible = true;
                progressLipids.Value = (int)Math.Min(100, currentLipids / goalLipids * 100);
                labelGoalLipids.Text = goalLipids.ToString();
                if (currentLipids > goalLipids)
                    labelWarningLipids.Visible = true;
                else
                    labelWarningLipids.Visible = false;
            }
            else
            {
                progressLipids.Visible = false;
                labelGoalLipids.Visible = false;
                labelWarningLipids.Visible = false;
                label13.Visible = false;
            }
            if (goalFibers > 0)
            {
                progressFibers.Visible = true;
                labelGoalFibers.Visible = true;
                label15.Visible = true;
                progressFibers.Value = (int)Math.Min(100, currentFibers / goalFibers * 100);
                labelGoalFibers.Text = goalFibers.ToString();
                if (currentFibers > goalFibers)
                    labelWarningFibers.Visible = true;
                else
                    labelWarningFibers.Visible = false;
            }
            else
            {
                progressFibers.Visible = false;
                labelGoalFibers.Visible = false;
                labelWarningFibers.Visible = false;
                label15.Visible = false;
            }
        }

        private void listAllFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAllFoods.SelectedIndices.Count > 0)
            {
                pictureBox1.Image = imgList.Images[listAllFoods.SelectedItems[0].ImageIndex];
                pictureBox1.Visible = true;
                labelSelectedFood.Text = ((Aliment)listAllFoods.SelectedItems[0]).FoodName;
                labelSelectedCalories.Text = "Calories: " + ((Aliment)listAllFoods.SelectedItems[0]).Calories;
                labelSelectedProteins.Text = "Proteins: " + ((Aliment)listAllFoods.SelectedItems[0]).Proteins;
                labelSelectedCarbs.Text = "Carbs: " + ((Aliment)listAllFoods.SelectedItems[0]).Carbs;
                labelSelectedLipids.Text = "Lipids: " + ((Aliment)listAllFoods.SelectedItems[0]).Lipids;
                labelSelectedFibers.Text = "Fibers: " + ((Aliment)listAllFoods.SelectedItems[0]).Fibers;
                labelSelectedCalories.Visible = true;
                labelSelectedProteins.Visible = true;
                labelSelectedCarbs.Visible = true;
                labelSelectedLipids.Visible = true;
                labelSelectedFibers.Visible = true;
                labelSelectedFood.Visible = true;
            }
        }

        private void ReadFromFile()
        {
            string path = "days\\" + DateTime.Today.ToString("d") + ".txt";
            if (File.Exists(path))
            {
                StreamReader rd = new StreamReader(path);

                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();

                while (!rd.EndOfStream)
                {
                    string line = rd.ReadLine();
                    int foodID = Convert.ToInt32(line.Substring(0, line.IndexOf(' ')));
                    int foodQuantity = Convert.ToInt32(line.Substring(line.IndexOf(' ') + 1));

                    foreach (Aliment al in aliments)
                    {
                        if (al.ID == foodID)
                        {
                            AddToEaten(al, foodQuantity, false);
                        }
                    }
                }

                rd.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeUserData ch = new ChangeUserData(new User());
            ch.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float caloriesToEat = 0;
            if (labelGoalCalories.Visible == true)
            {
                float goalCalories = Convert.ToSingle(labelGoalCalories.Text);
                if (goalCalories <= currentCalories)
                    return;
                caloriesToEat = goalCalories - currentCalories;
            }
            float proteinsToEat = 0;
            if (labelGoalProteins.Visible == true)
            {
                float goalProteins = Convert.ToSingle(labelGoalProteins.Text);
                if (goalProteins <= currentProteins)
                    return;
                proteinsToEat = goalProteins - currentProteins;
            }
            float carbsToEat = 0;
            if (labelGoalCarbs.Visible == true)
            {
                float goalCarbs = Convert.ToSingle(labelGoalCarbs.Text);
                if (goalCarbs <= currentCarbs)
                    return;
                carbsToEat = goalCarbs - currentCarbs;
            }
            float lipidsToEat = 0;
            if (labelGoalLipids.Visible == true)
            {
                float goalLipids = Convert.ToSingle(labelGoalLipids.Text);
                if (goalLipids <= currentLipids)
                    return;
                lipidsToEat = goalLipids - currentLipids;
            }
            float fibersToEat = 0;
            if (labelGoalFibers.Visible == true)
            {
                float goalFibers = Convert.ToSingle(labelGoalFibers.Text);
                if (goalFibers <= currentFibers)
                    return;
                fibersToEat = goalFibers - currentFibers;
            }
            if (caloriesToEat + proteinsToEat + carbsToEat + lipidsToEat + fibersToEat == 0)
                return;
            frmSuggestFood sf = new frmSuggestFood(aliments, caloriesToEat, proteinsToEat, carbsToEat, lipidsToEat, fibersToEat);
            sf.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sport = SuggestSport();
            if (sport != "")
            {
                var notification = new System.Windows.Forms.NotifyIcon()
                {
                    Visible = true,
                    Icon = System.Drawing.SystemIcons.Information,
                    // optional - BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                    // optional - BalloonTipTitle = "My Title",
                    BalloonTipText = sport,
                };

                // Display for 5 seconds.
                notification.ShowBalloonTip(5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sport = SuggestSport();
            if (sport != "")
            {
                MessageBox.Show(sport, "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string SuggestSport()
        {
            int goalcals = Convert.ToInt32(labelGoalCalories.Text);
            if (currentCalories > goalcals)
            {
                string temp;
                string temp1;
                int nrCalorii = (int)currentCalories - goalcals;

                int calPermin;
                Random random = new Random();
                int randomNumber = random.Next(0, workoutLines.Length - 1);

                if (randomNumber % 2 == 0)
                {
                    calPermin = (Int32.Parse(workoutLines[randomNumber + 1])) / 15;
                    temp = (nrCalorii / calPermin).ToString();
                    temp1 = "You should practice " + workoutLines[randomNumber] + " for " + temp + " minutes!";
                }
                else
                {
                    calPermin = (Int32.Parse(workoutLines[randomNumber])) / 15;
                    temp = (nrCalorii / calPermin).ToString();
                    temp1 = "You should practice " + workoutLines[randomNumber - 1] + " for " + temp + " minutes!";
                }

                return temp1;
            }
            else return "";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (popup == null)
            {
                popup = new FormRec();
                popup.FormClosed += Popup_FormClosed;
                popup.Show();
            }
        }

        private void Popup_FormClosed(object sender, FormClosedEventArgs e)
        {
            popup = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormGmaps gymFinder = new FormGmaps();
            gymFinder.Show();
        }

        private void SendMail()
        {
            EMailPrompt dlg = new EMailPrompt();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                EASendMail.SmtpClient oSmtp = new EASendMail.SmtpClient();

                oMail.From = "ecalculatorinc@gmail.com";
                oMail.To = dlg.EMail;
                oMail.Subject = "Your nutrition stats from eCalculatorInc";
                oMail.HtmlBody = BuildStatsHTML();

                // Your SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                // Set 25 port, if your server uses 587 port, please change 25 to 587
                oServer.Port = 587;

                // Set TLS connection
                oServer.ConnectType = SmtpConnectType.ConnectSTARTTLS;

                // User and password for ESMTP authentication            
                oServer.User = "ecalculatorinc@gmail.com";
                oServer.Password = "labacalutcluj";

                try
                {

                    oSmtp.SendMail(oServer, oMail);
                    label3.Text = "email was sent successfully!";
                }
                catch (Exception ep)
                {
                    label3.Text = "failed to send email with the following error:" + ep.Message;

                }
            }
        }

        private string BuildStatsHTML()
        {
            string[] f = Directory.GetFiles(@"days\");
            if (f.Length >= 2)
            {
                string firstDay = f[0].Substring(0, f[0].IndexOf(".txt"));
                string lastDay = f[f.Length - 1].Substring(0, f[f.Length - 1].IndexOf(".txt"));

                int[] historyCalories = new int[f.Length];
                int[] historyProteins = new int[f.Length];
                int[] historyCarbs = new int[f.Length];
                int[] historyLipids = new int[f.Length];
                int[] historyFibers = new int[f.Length];
                int avgCalories = 0;
                int avgProteins = 0;
                int avgCarbs = 0;
                int avgLipids = 0;
                int avgFibers = 0;

                for (int i = 0; i < f.Length; ++i)
                {
                    StreamReader rd = new StreamReader(f[i]);
                    historyCalories[i] = Convert.ToInt32(rd.ReadLine());
                    historyProteins[i] = Convert.ToInt32(rd.ReadLine());
                    historyCarbs[i] = Convert.ToInt32(rd.ReadLine());
                    historyLipids[i] = Convert.ToInt32(rd.ReadLine());
                    historyFibers[i] = Convert.ToInt32(rd.ReadLine());
                    avgCalories += historyCalories[i];
                    avgProteins += historyProteins[i];
                    avgCarbs += historyCarbs[i];
                    avgLipids += historyLipids[i];
                    avgFibers += historyFibers[i];
                }

                avgCalories /= f.Length;
                avgProteins /= f.Length;
                avgLipids /= f.Length;
                avgCarbs /= f.Length;
                avgFibers /= f.Length;

                Graphic gCalories = new Graphic(historyCalories);
                Graphic gProteins = new Graphic(historyProteins);
                Graphic gCarbs = new Graphic(historyCarbs);
                Graphic gLipids = new Graphic(historyLipids);
                Graphic gFibers = new Graphic(historyFibers);

                string mailtext = File.ReadAllText(@"conf\mail.html");
                string base64Logo;

                using (Image image = Image.FromFile(@"conf\logo.png"))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String
                        base64Logo = Convert.ToBase64String(imageBytes);
                    }
                }

                mailtext = mailtext.Replace("*logo*", base64Logo);
                mailtext = mailtext.Replace("*calstats*", gCalories.GetBase64Image());
                mailtext = mailtext.Replace("*protstats*", gProteins.GetBase64Image());
                mailtext = mailtext.Replace("*carbstats*", gCarbs.GetBase64Image());
                mailtext = mailtext.Replace("*lipstats*", gLipids.GetBase64Image());
                mailtext = mailtext.Replace("*fibstats*", gFibers.GetBase64Image());
                mailtext = mailtext.Replace("*avgcal*", avgCalories.ToString());
                mailtext = mailtext.Replace("*avgprot*", avgProteins.ToString());
                mailtext = mailtext.Replace("*avgcarbs*", avgCarbs.ToString());
                mailtext = mailtext.Replace("*avglip*", avgLipids.ToString());
                mailtext = mailtext.Replace("*avgfib*", avgFibers.ToString());
                mailtext = mailtext.Replace("*day1*", firstDay);
                mailtext = mailtext.Replace("*day2*", lastDay);

                File.WriteAllText("stats.html", mailtext);
                System.Diagnostics.Process.Start("stats.html");
                return mailtext;
            }
            return null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SendMail();
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }
    }
}

