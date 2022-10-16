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
        //creation of public variables 
        List<string> CoreIngridients;
        List<Meals> MealList = new List<Meals>();
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
            //Adds all entries to Meals Class
            Meals Meal = new Meals (MealName,CoreIngridients,Calories,Vegan,Lunch,Dinner);
            //Closes Form
            this.Close();

        }
        // Converting user input to variables inorder to store information inside the class
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
            //Tests input type to insure it is a number 
            try
            {
                Calories = Convert.ToInt32(CaloriesTextBox.Text);
            }
            catch (Exception) // Cretaes a popup to alert user to error
            {
                Form3 PopUp = new Form3();
                PopUp.ShowDialog();
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
