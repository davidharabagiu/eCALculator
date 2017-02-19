using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCALculator
{
    public class DailyPlan
    {
        private double calorii, proteine, carbohidrati, lipide,fibre;

        public DailyPlan()
        {
            this.calorii = 0;
            this.proteine = 0;
            this.carbohidrati = 0;
            this.lipide = 0;
            this.fibre = 0;
        }

        public DailyPlan(double calorii,double proteine,double carbohidrati,double lipide,double fibre)
        {
            this.calorii = calorii;
            this.proteine = proteine;
            this.carbohidrati = carbohidrati;
            this.lipide = lipide;
            this.fibre = fibre;
        }


        public double Calorii
        {
            get
            {
                return calorii;
            }
            set
            {
                calorii = value;
            }
        }
        public double Carbohidrati
        {
            get
            {
                return carbohidrati;
            }
            set
            {
                carbohidrati = value;
            }
        }

        public double Proteine
        {
            get
            {
                return proteine;
            }
            set
            {
                proteine = value;
            }
        }

        public double Lipide
        {
            get
            {
                return lipide;
            }
            set
            {
                lipide = value;
            }
        }

        public double Fibre
        {
            get
            {
                return fibre;
            }
            set
            {
                fibre = value;
            }
        }
    }
}
