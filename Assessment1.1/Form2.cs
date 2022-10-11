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
    public partial class Form2 : Form

    {
        List<string> CoreIngridients;
        List<Meals> MealList = new List<Meals>();
        String MealName;
        bool Lunch;
        bool Dinner;
        int Calories;
        bool Vegan;
        String Test;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            MealList.Add(new Meals(MealName,CoreIngridients,Calories,Vegan,Lunch,Dinner));
            this.Close();
        
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MealName = MealNameTextBox.Text;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LunchCheckBox.Checked == true)
            {
                Lunch = true;
            }
            else if (DinnerCheckbox.Checked == true)
            {
                Dinner = true;
            }
        }

        private void CaloriesTextBox_TextChanged(object sender, EventArgs e)
        {
            Calories = Convert.ToInt32(CaloriesTextBox.Text);
        }

        private void VeganYesBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (VeganYesBtn.Checked == true)
            {
                Vegan = true;

            }
            else if (VeganYesBtn.Checked == false)
            {
                Vegan = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IngridientsTxtBox_TextChanged(object sender, EventArgs e, string ingridients)
        {
            CoreIngridients = new List<string> {IngridientsTxtBox.Text};
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
