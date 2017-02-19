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
    public partial class frmSuggestFood : Form
    {
        private List<Aliment> aliments;
        private List<int> quantities;
        private float calories;
        private float proteins;
        private float carbs;
        private float lipids;
        private float fibers;

        public frmSuggestFood(List<Aliment> aliments, float cals, float proteins, float carbs, float lipids, float fibers)
        {
            InitializeComponent();

            this.aliments = aliments;
            this.calories = cals;
            this.proteins = proteins;
            this.carbs = carbs;
            this.lipids = lipids;
            this.fibers = fibers;
        }

        private void frmSuggestFood_Load(object sender, EventArgs e)
        {
            quantities = new List<int>();
            for (int i = 0; i < aliments.Count; ++i)
            {
                quantities.Add(int.MaxValue);
                if (calories > 0 && aliments[i].Calories > 0)
                    quantities[i] = Math.Min(quantities[i], (int)(calories / aliments[i].Calories * 100));
                if (proteins > 0 && aliments[i].Proteins > 0)
                    quantities[i] = Math.Min(quantities[i], (int)(proteins / aliments[i].Proteins * 100));
                if (carbs > 0 && aliments[i].Carbs > 0)
                    quantities[i] = Math.Min(quantities[i], (int)(carbs / aliments[i].Carbs * 100));
                if (lipids > 0 && aliments[i].Lipids > 0)
                    quantities[i] = Math.Min(quantities[i], (int)(lipids / aliments[i].Lipids * 100));
                if (fibers > 0 && aliments[i].Fibers > 0)
                    quantities[i] = Math.Min(quantities[i], (int)(fibers / aliments[i].Fibers * 100));
            }

            for (int i = 0; i < aliments.Count; ++i)
            {
                for (int j = i + 1; j < aliments.Count; ++j)
                {
                    if (quantities[i] < quantities[j])
                    {
                        int qt = quantities[i];
                        quantities[i] = quantities[j];
                        quantities[j] = qt;
                        Aliment at = aliments[i];
                        aliments[i] = aliments[j];
                        aliments[j] = at;
                    }
                }
            }

            for (int i = 0; i < Math.Min(aliments.Count, 100); ++i)
            {
                if (quantities[i] > 0)
                {
                    ListViewItem item = new ListViewItem(aliments[i].FoodName);
                    item.SubItems.Add(quantities[i].ToString());
                    listView1.Items.Add(item);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
