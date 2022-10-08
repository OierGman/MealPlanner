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

            List<string> CourgettePakorasRecipe  = new List<string> { "Courgette", "Chiili", "Flour" };
            MealList.Add(new Meals("Courgette Pakoras", CourgettePakorasRecipe, 84, true, true, false));

            List<string> VeggieWrapRecipe = new List<string> { "Tortilla", "Red Cabbage", "Olives"};
            MealList.Add(new Meals("Veggie Wraps", VeggieWrapRecipe, 281, true ,true, false));

            List<string> SpinnachMushroomPastaRecipe = new List<string> { "Penne Pasta", "Mushroom", "Spinnach" };
            MealList.Add(new Meals("Veggie Wraps", SpinnachMushroomPastaRecipe, 483, true, true, true));

            List<string> VeganBuritoRecipe = new List<string> { "Tortilla", "Rice", "Black Beans" };
            MealList.Add(new Meals("Veggie Wraps", VeganBuritoRecipe, 513, true, true, false));

            List<string> CourgetteCurryRecipe = new List<string> { "Rice", "Courgette", "Chickpeas" };
            MealList.Add(new Meals("Veggie Wraps", CourgetteCurryRecipe, 487, true, false, true));

            List<string> CoconutDahlRecipe = new List<string> { "Tomatoes", "Chickpeas", "lentils" };
            MealList.Add(new Meals("Veggie Wraps", CoconutDahlRecipe, 338, true, true, true));

            List<string> JackfruitBurgerRecipe = new List<string> { "Jackfruit", "Mushroom", "Potato" };
            MealList.Add(new Meals("Veggie Wraps", JackfruitBurgerRecipe, 416, true, true, true));

            List<string> FalafelRecipe = new List<string> { "Chickpease ", "Onions", "Broad Beans"};
            MealList.Add(new Meals("Veggie Wraps", FalafelRecipe, 139, true, true, true));

            List<string> VeganCarbonaraRecipe = new List<string> { "Spagehett" , "Cashew Nuts", "Mushrooms" };
            MealList.Add(new Meals("Veggie Wraps", VeganCarbonaraRecipe, 499, true, true, true));

            List<string> CrunchSaladRecipe = new List<string> { "Almonds", "Radishes", "Edamame" };
            MealList.Add(new Meals("Veggie Wraps", CrunchSaladRecipe, 483, true, true, false));

            List<string> CouscousRecipe = new List<string> { "Beetroot", "Couscous", "Tomatoes" };
            MealList.Add(new Meals("Veggie Wraps", CouscousRecipe, 461, true, true, false));

            List<string> VeganKormaRecipe = new List<string> { "Spring Onions", "Chickpeas", "Almonds" };
            MealList.Add(new Meals("Veggie Wraps", VeganKormaRecipe, 477, true, true, true));

            List<string> SweetPotatoSoupRecipe = new List<string> { "Sweet Potato", "Vegetable Stock", "Garlic" };
            MealList.Add(new Meals("Veggie Wraps", SweetPotatoSoupRecipe, 458, true, true, false));

            List<string> GreenBeanSaladRecipe = new List<string> {"Green Beans", "Garlic", "Mint" };
            MealList.Add(new Meals("Veggie Wraps", GreenBeanSaladRecipe, 79, true, true, false));
        }

        private void generate_meals_btn_Click(object sender, EventArgs e)
        {
            // looking at return values 
            label1.Text = "meal selected: " + MealList[0].ingredient[0];
        }
    }
}
