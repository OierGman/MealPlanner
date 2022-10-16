using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assessment1._1
{
    public partial class Form2 : Form

    {
        List<string> CoreIngridients = new List<string>();
        String MealName;
        bool Lunch;
        bool Dinner;
        int Calories;
        bool Vegan;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingredients();
            Meals.MealList.Add(new Meals(MealName, CoreIngridients, Calories, Vegan, Lunch, Dinner));
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
            bool Value = Int32.TryParse(CaloriesTextBox.Text, out int tempIntP);

            if (Value == true)
            {
                Calories = tempIntP;
            }
            else
            {
                CaloriesTextBox.Text = "0";
                MessageBox.Show("not valid calorie number");
            }
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

        private void Ingredients()
        {
            string[] CoreIngredients = IngridientsTxtBox.Text.Split(", ", ',');
            
            foreach (var i in CoreIngredients)
            {
                CoreIngridients.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
