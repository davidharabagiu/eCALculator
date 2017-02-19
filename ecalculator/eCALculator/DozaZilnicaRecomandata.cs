using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCALculator
{
    public class DozaZilnicaRecomandata
    {
        private double calorii, carbohidrati, proteine, lipide, fibre;
        private int age;
        private  string gender;

        public DozaZilnicaRecomandata(User user)
        {
            this.age = user.Age;
            this.gender = user.Gender;
        }

        public double getCalorii()
        {
            if (gender =="Barbat")
            {
                return 2500;
            }
            else
            {
                return 2000;
            }
        }

        public double getCarbohidrati()
        {
            if (gender =="Barbat")
            {
                if( age<=64)
                {
                    return 300;
                }
                else
                {
                    return 300;
                }
            }
            else
            {
                if (age <= 54)
                {
                    return 300;
                }
                else
                {
                    return 300;
                }
            }
        }

        public double getProteine()
        {
            if (gender == "Barbat")
            {
                if (age <= 64)
                {
                    return 55;
                }
                else
                {
                    return 55;
                }
            }
            else
            {
                if (age <= 54)
                {
                    return 45;
                }
                else
                {
                    return 45;
                }
            }
        }

        public double getLipide()
        {
            if (gender == "Barbat")
            {
                if (age <= 64)
                {
                    return 65;
                }
                else
                {
                    return 65;
                }
            }
            else
            {
                if (age <= 54)
                {
                    return 65;
                }
                else
                {
                    return 65;
                }
            }
        }

        public double getFibre()
        {
            if (gender == "Barbat")
            {
                if (age <= 64)
                {
                    return 25;
                }
                else
                {
                    return 25;
                }
            }
            else
            {
                if (age <= 54)
                {
                    return 25;
                }
                else
                {
                    return 25;
                }
            }
        }
    }
}
