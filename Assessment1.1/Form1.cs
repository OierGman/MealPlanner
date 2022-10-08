using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1._1
{
    public partial class Form1 : Form
    {
        // next atempt to store the data will be using nested dictionaries





        List<Meals> MealList = new List<Meals>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialising a meal with objects
            List<string> recipeSB = new List<string>{"minced", "spaghetti", "pasata", "cheese"};
            MealList.Add(new Meals("Spaghetti Bolognese", recipeSB, 2000, false, true, true));
        }

        private void generate_meals_btn_Click(object sender, EventArgs e)
        {
            // looking at return values 
            label1.Text = "meal selected: " + MealList[0].ingredient[0];
        }
    }
}
