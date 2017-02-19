using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace eCALculator
{
    public class User
    {
        private string fname, lname, gender;
        private int age;
        private double weight;
        private double height;
        private WeeklyPlan weekPlan = new WeeklyPlan();
        public readonly static int MONDAY = 1;
        public readonly static int TUESDAY = 2;
        public readonly static int WEDNESDAY = 3;
        public readonly static int THURSDAY = 4;
        public readonly static int FRIDAY = 5;
        public readonly static int SATURDAY = 6;
        public readonly static int SUNDAY = 7;

        

        public User(string fname,string lname,string gender,int age,double weight,double height)
        {
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.age = age;
            this.weight = weight;
            this.height = height;
            saveUserData();
        }

       
        

        public User()
        {
            var file = new FileStream(@"conf\user.txt", FileMode.Open, FileAccess.Read);
            var read = new StreamReader(file);
            this.fname = read.ReadLine();
            this.lname = read.ReadLine();
            this.gender = read.ReadLine();
            this.age = Convert.ToInt32(read.ReadLine());
            this.weight = Convert.ToDouble(read.ReadLine());
            this.height = Convert.ToDouble(read.ReadLine());

            weekPlan.setDayDetails(1, Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()));
            weekPlan.setDayDetails(2, Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()));
            weekPlan.setDayDetails(3, Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()));
            weekPlan.setDayDetails(4, Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()));
            weekPlan.setDayDetails(5, Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()));
            weekPlan.setDayDetails(6, Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()));
            weekPlan.setDayDetails(7, Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()), Convert.ToDouble(read.ReadLine()));
            file.Close();
        }

        

        public void saveUserData()
        {
            StreamWriter write = new StreamWriter(@"conf\user.txt");
            /* var file = new FileStream(".../.../UserData.txt", FileMode.Open, FileAccess.Write);
             var write = new StreamWriter(file);*/
            write.WriteLine(fname);
            write.WriteLine(lname);
            write.WriteLine(gender);
            write.WriteLine(age);
            write.WriteLine(weight);
            write.WriteLine(height);
            write.WriteLine(weekPlan.getDayDetails(1).Calorii);
            write.WriteLine(weekPlan.getDayDetails(1).Proteine);
            write.WriteLine(weekPlan.getDayDetails(1).Carbohidrati);
            write.WriteLine(weekPlan.getDayDetails(1).Lipide);
            write.WriteLine(weekPlan.getDayDetails(1).Fibre);

            write.WriteLine(weekPlan.getDayDetails(2).Calorii);
            write.WriteLine(weekPlan.getDayDetails(2).Proteine);
            write.WriteLine(weekPlan.getDayDetails(2).Carbohidrati);
            write.WriteLine(weekPlan.getDayDetails(2).Lipide);
            write.WriteLine(weekPlan.getDayDetails(2).Fibre);

            write.WriteLine(weekPlan.getDayDetails(3).Calorii);
            write.WriteLine(weekPlan.getDayDetails(3).Proteine);
            write.WriteLine(weekPlan.getDayDetails(3).Carbohidrati);
            write.WriteLine(weekPlan.getDayDetails(3).Lipide);
            write.WriteLine(weekPlan.getDayDetails(3).Fibre);

            write.WriteLine(weekPlan.getDayDetails(4).Calorii);
            write.WriteLine(weekPlan.getDayDetails(4).Proteine);
            write.WriteLine(weekPlan.getDayDetails(4).Carbohidrati);
            write.WriteLine(weekPlan.getDayDetails(4).Lipide);
            write.WriteLine(weekPlan.getDayDetails(4).Fibre);

            write.WriteLine(weekPlan.getDayDetails(5).Calorii);
            write.WriteLine(weekPlan.getDayDetails(5).Proteine);
            write.WriteLine(weekPlan.getDayDetails(5).Carbohidrati);
            write.WriteLine(weekPlan.getDayDetails(5).Lipide);
            write.WriteLine(weekPlan.getDayDetails(5).Fibre);

            write.WriteLine(weekPlan.getDayDetails(6).Calorii);
            write.WriteLine(weekPlan.getDayDetails(6).Proteine);
            write.WriteLine(weekPlan.getDayDetails(6).Carbohidrati);
            write.WriteLine(weekPlan.getDayDetails(6).Lipide);
            write.WriteLine(weekPlan.getDayDetails(6).Fibre);

            write.WriteLine(weekPlan.getDayDetails(7).Calorii);
            write.WriteLine(weekPlan.getDayDetails(7).Proteine);
            write.WriteLine(weekPlan.getDayDetails(7).Carbohidrati);
            write.WriteLine(weekPlan.getDayDetails(7).Lipide);
            write.WriteLine(weekPlan.getDayDetails(7).Fibre);
            /* file.Close(); */
            write.Close();
        }

        
        public DailyPlan getDayDetails(int DAY)
        {
            return weekPlan.getDayDetails(DAY);
        }

        public void setDaiDetails(int DAY, double calorii, double proteine, double carbohidrati, double lipide,double fibre)
        {
            weekPlan.setDayDetails(DAY, calorii, proteine, carbohidrati, lipide,fibre);
        }
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

    }
}
