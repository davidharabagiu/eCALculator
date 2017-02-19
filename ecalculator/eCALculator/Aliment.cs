using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

public class Aliment : ListViewItem
{
    private int id;
    private string foodName;
    private float cal;
    private float prot;
    private float carbs;
    private float fibers;
    private float lipids;

    public Aliment(int id, string name, int imgIndex, float cal, float prot, float carbs, float lipids, float fibers) : base(name, imgIndex)
    {
        this.id = id;
        this.foodName = name;
        this.cal = cal;
        this.prot = prot;
        this.carbs = carbs;
        this.fibers = fibers;
        this.lipids = lipids;
    }

    public int ID
    {
        get { return id; }
    }

    public float Calories
    {
        get { return cal; }
        set { cal = value; }
    }
    public float Proteins
    {
        get { return prot; }
        set { prot = value; }
    }
    public float Carbs
    {
        get { return carbs; }
        set { carbs = value; }
    }
    public float Lipids
    {
        get { return lipids; }
        set { lipids = value; }
    }

    public float Fibers
    {
        get { return fibers; }
        set { fibers = value; }
    }

    public string FoodName
    {
        get { return foodName; }
    }

    public static void addFoodInFile(List<Aliment> alimente, List<int> cantitate, float[] totalVals)
    {
        DateTime thisday = DateTime.Today;
        string path = "days\\";
        path = path + thisday.ToString("d");
        path = path + ".txt";

        StreamWriter wr = new StreamWriter(path);

        for (int i = 0; i < 5; i++)
        {
            wr.WriteLine(((int)totalVals[i]).ToString());
        }

        for (int i = 0; i < alimente.Count; i++)
        {
            wr.WriteLine(alimente[i].ID + " " + cantitate[i]);
        }
        wr.Close();
    }
}
