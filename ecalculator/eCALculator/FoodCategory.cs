using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCALculator
{
    class FoodCategory
    {
        private string name;
        private List<int> aliments;

        public FoodCategory(string name)
        {
            this.name = name;
            aliments = new List<int>();
        }

        public void AddAliment(int a)
        {
            aliments.Add(a);
        }

        public List<int> Aliments
        {
            get { return aliments; }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
