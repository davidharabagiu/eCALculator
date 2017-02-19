using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCALculator
{
    public class WeeklyPlan
    {
        private List<DailyPlan> daylist = new List<DailyPlan>();
        public readonly static int MONDAY = 1;
        public readonly static int TUESDAY = 2;
        public readonly static int WEDNESDAY = 3;
        public readonly static int THURSDAY = 4;
        public readonly static int FRIDAY = 5;
        public readonly static int SATURDAY = 6;
        public readonly static int SUNDAY = 7;

        public WeeklyPlan()
        {
            for (int i=1; i<=8; i++)
            {
                daylist.Add(new DailyPlan());
            }
        }


        public DailyPlan getDayDetails(int DAY)
        {
            return daylist.ElementAt(DAY);
        }

        public void setDayDetails(int DAY,double calorii, double proteine, double carbohidrati, double lipide,double fibre)
        {
            daylist.ElementAt(DAY).Calorii = calorii;
            daylist.ElementAt(DAY).Proteine = proteine;
            daylist.ElementAt(DAY).Carbohidrati = carbohidrati;
            daylist.ElementAt(DAY).Lipide = lipide;
            daylist.ElementAt(DAY).Fibre = fibre;
        }


    }
}
