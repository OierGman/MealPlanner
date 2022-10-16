using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1._1
{
    public partial class Form1 : Form
    {

        List<Meals> MealList = new List<Meals>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Meals Initialisation 
            // initialising a meal with objects
            List<string> SpaghettiBologneseRecipe = new List<string>{"minced", "spaghetti", "pasata", "cheese"};
            MealList.Add(new Meals("Spaghetti Bolognese", SpaghettiBologneseRecipe, 800, false, true, true));

            List<string> CourgettePakorasRecipe  = new List<string> { "Courgette", "Chilli", "Flour" };
            MealList.Add(new Meals("Courgette Pakoras", CourgettePakorasRecipe, 84, true, true, false));

            List<string> VeggieWrapRecipe = new List<string> { "Tortilla", "Red Cabbage", "Olives"};
            MealList.Add(new Meals("Veggie Wraps", VeggieWrapRecipe, 281, true ,true, false));

            List<string> SpinnachMushroomPastaRecipe = new List<string> { "Penne Pasta", "Mushroom", "Spinnach" };
            MealList.Add(new Meals("Spinach Mushroom Pasta", SpinnachMushroomPastaRecipe, 483, true, true, true));

            List<string> VeganBuritoRecipe = new List<string> { "Tortilla", "Rice", "Black Beans" };
            MealList.Add(new Meals("Vegan Burrito", VeganBuritoRecipe, 513, true, true, false));

            List<string> CourgetteCurryRecipe = new List<string> { "Rice", "Courgette", "Chickpeas" };
            MealList.Add(new Meals("Courgette Curry", CourgetteCurryRecipe, 487, true, false, true));

            List<string> CoconutDahlRecipe = new List<string> { "Tomatoes", "Chickpeas", "lentils" };
            MealList.Add(new Meals("Coconut Dahl", CoconutDahlRecipe, 338, true, true, true));

            List<string> JackfruitBurgerRecipe = new List<string> { "Jackfruit", "Mushroom", "Potato" };
            MealList.Add(new Meals("Jackfruit Burger", JackfruitBurgerRecipe, 416, true, true, true));

            List<string> FalafelRecipe = new List<string> { "Chickpease ", "Onions", "Broad Beans"};
            MealList.Add(new Meals("Falafel", FalafelRecipe, 139, true, true, true));

            List<string> VeganCarbonaraRecipe = new List<string> { "Spagehett" , "Cashew Nuts", "Mushrooms" };
            MealList.Add(new Meals("Vegan Carbonara", VeganCarbonaraRecipe, 499, true, true, true));

            List<string> CrunchSaladRecipe = new List<string> { "Almonds", "Radishes", "Edamame" };
            MealList.Add(new Meals("Crunch Salad", CrunchSaladRecipe, 483, true, true, false));

            List<string> CouscousRecipe = new List<string> { "Beetroot", "Couscous", "Tomatoes" };
            MealList.Add(new Meals("Couscous", CouscousRecipe, 461, true, true, false));

            List<string> VeganKormaRecipe = new List<string> { "Spring Onions", "Chickpeas", "Almonds" };
            MealList.Add(new Meals("Vegan Korma", VeganKormaRecipe, 477, true, true, true));

            List<string> SweetPotatoSoupRecipe = new List<string> { "Sweet Potato", "Vegetable Stock", "Garlic" };
            MealList.Add(new Meals("Sweet Potato Soup", SweetPotatoSoupRecipe, 458, true, true, false));

            List<string> GreenBeanSaladRecipe = new List<string> {"Green Beans", "Garlic", "Mint" };
            MealList.Add(new Meals("Green Bean Salad", GreenBeanSaladRecipe, 79, true, true, false));

            List<string> LasagnaRecipe = new List<string> { "Pasta", "Cheese", "Mince" };
            MealList.Add(new Meals("Lasagna", LasagnaRecipe, 352, false, false, true));

            List<string> RoastDinnerRecipe = new List<string> { "Chicken", "Potatos", "Gravy"};
            MealList.Add(new Meals("Roast DInner", RoastDinnerRecipe, 212, false, false, true));

            List<string> PizzaRecipe = new List<string> { "Tomato", "Pepperoni", "Cheese" };
            MealList.Add(new Meals("Pizza", PizzaRecipe, 567, false, true, true));

            List<string> LambCurryRecipe = new List<string> { "Lamb", "Chilli", "Rice" };
            MealList.Add(new Meals("Lamb Curry", LambCurryRecipe, 352, false, false, true));

            List<string> ChickenPastaRecipe = new List<string> {"Chickn","Bacon","Pasta" };
            MealList.Add(new Meals("Chicken And Bacon Pasta", ChickenPastaRecipe, 257, false, true, true));

            List<string> ChickenCeaserSalad = new List<string> { "Chicken","Croutons","Salad" };
            MealList.Add(new Meals("Chicken Ceaser Salad", ChickenCeaserSalad, 352, false, true, false));

            List<string> ChickenAndChipsRecipe = new List<string> {"Chicken","Chips","Veg" };
            MealList.Add(new Meals("Chicken And Chips", ChickenAndChipsRecipe, 498, false, false, true));

            List<string> SteakAndChips = new List<string> {"Steak","Chips", "Mushroom" };
            MealList.Add(new Meals("Steak And Chips", SteakAndChips, 290, false, false, true));

            List<string> KebabRecipe = new List<string> {"Lamb","Pepper","Pitta" };
            MealList.Add(new Meals("Kebab", KebabRecipe, 480, false, true, true));

            List<string> TomatoSoupRecipe = new List<string> { "Tomato","Onion","Bread" };
            MealList.Add(new Meals("Tomato Soup", TomatoSoupRecipe, 450, false, true, false));

            List<string> SausageAndMashRecipe = new List<string> { "Sausage","Mash","Gravy" };
            MealList.Add(new Meals("Sausage And Mash",SausageAndMashRecipe, 700, false, false, true));

            List<string> PorkChopAndMashRecipe = new List<string> {"Pork Chop","Mash","Veg" };
            MealList.Add(new Meals("Pork Chop And Mash", PorkChopAndMashRecipe, 385, false, false, true));

            List<string> PieAndChipsRecipe = new List<string> { "Pie","Chips","Veg" };
            MealList.Add(new Meals("Pie And Chips", PieAndChipsRecipe, 725, false, false, true));

            List<string> FishAndChipsRecipe = new List<string> { "Fish","Chips","Lemon" };
            MealList.Add(new Meals("Fish And Chips", FishAndChipsRecipe, 659, false, false, true));
           
            List<string> LambCaserolleRecipe = new List<string> { "Lamb","Onion","Potato" };
            MealList.Add(new Meals("Lamb Caserolle",LambCaserolleRecipe, 378, false, false, true));

            List<string> ChickenBLTRecipe = new List<string> { "Chiken","Bacon","Tomato" };
            MealList.Add(new Meals("Chicken BLT", ChickenBLTRecipe, 217, false, true, false));

            List<string> HoumousRecipe = new List<string> { "Chickpeas","Carrots","Pitta" };
            MealList.Add(new Meals("Houmous", HoumousRecipe, 178, false, true, false)) ;

            List<string> ChickenArrabiataRecipe = new List<string> { "Chicken","Pasta","Chilli" };
            MealList.Add(new Meals("Chicken Arrabiat", ChickenArrabiataRecipe, 367, false, false, true));

            List<string> FishSoupRecipe = new List<string> { "Fish","Onion","Carrot" };
            MealList.Add(new Meals("Fish Soup",FishSoupRecipe , 352, false, true, true));

            #endregion
        }

        private void generate_meals_btn_Click(object sender, EventArgs e)
        {
            // looking at return values
            // how to access name of meal
            // label1.Text = MealList[0].name;

            // accessing a random meal with true lunch value
            Random number = new Random();

            for (int i = 0; i < MealList.Count; i++)
            {
                if (MealList[number.Next(MealList.Count)].isLunch == true ) // for dinner meals change to false
                {
                    // label 1 doesnt exist ( change to element in form )
                    // label1.Text = MealList[number.Next(MealList.Count)].name;

                }
            }
            // use this function to determine whether a meal is lunch/dinner/vegan. change bool attribute in if statement

            // Removes plan meals button, generates ui
            Controls.Remove(generate_meals_btn);
            GenerateUi();

        }
        // Generates the user interface 
        private void GenerateUi()
        {
            Panel mealTableContainer = new Panel();
            this.Controls.Add(mealTableContainer);
            mealTableContainer.Dock = DockStyle.Fill;

            TableLayoutPanel mealTimeTableWeek = new TableLayoutPanel();
            mealTimeTableWeek.ColumnCount = 8;
            mealTimeTableWeek.RowCount = 3;
            mealTimeTableWeek.Dock = DockStyle.Fill;
            // Column styles
            mealTimeTableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mealTimeTableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mealTimeTableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mealTimeTableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mealTimeTableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mealTimeTableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mealTimeTableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mealTimeTableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            // Row styles
            mealTimeTableWeek.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mealTimeTableWeek.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            mealTimeTableWeek.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            // Populating columns/rows
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Monday", TextAlign  = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill}, 1, 0);
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Tuesday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, 0);
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Wednesday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 3, 0);
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Thursday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 4, 0);
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Friday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 5, 0);
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Saturday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 6, 0);
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Sunday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 7, 0);
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Lunch", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 1);
            mealTimeTableWeek.Controls.Add(new Label() { Text = "Dinner", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 2);
            // add meal timetable to container
            mealTableContainer.Controls.Add(mealTimeTableWeek);
            // creates a meal button for every cell in the mealTimeTableWeek
            for (int i = 1; i < 7; i++)
            {
                // gets meal object, accesses property and value using reflection
                object meal = GetMeal();
                // access property name
                var mealPropertyName = meal.GetType().GetProperty("name");
                var mealValueName = mealPropertyName.GetValue(meal);
                // access property isLunch
                var mealPropertyLunch = meal.GetType().GetProperty("isLunch");
                var mealValueLunch = mealPropertyLunch.GetValue(meal);
                // access property isDinner
                var mealPropertyDinner = meal.GetType().GetProperty("isDinner");
                var mealValueDinner = mealPropertyLunch.GetValue(meal);

                if ((bool)mealValueLunch)
                {
                    mealTimeTableWeek.Controls.Add(new Button()
                    {
                        Text = (string)mealValueName,
                        TextAlign = ContentAlignment.TopCenter,
                        Dock = DockStyle.Fill,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Transparent,
                        FlatAppearance =
                            { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                    }, i, 1);
                }
                if((bool)mealValueDinner)
                {
                    mealTimeTableWeek.Controls.Add(new Button()
                    {
                        Text = (string)mealValueName,
                        TextAlign = ContentAlignment.TopCenter,
                        Dock = DockStyle.Fill,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Transparent,
                        FlatAppearance =
                            { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                    }, i, 2);
                }
            }
            // adds a click event for all meals buttons of mealTimeTableWeek
            foreach (var button in mealTimeTableWeek.Controls.OfType<Button>())
            {
                button.Click += button_Click;
            }
        }
        // event handler that accesses meal information
        private void button_Click(object sender, EventArgs e)
        {
            //test works
            ((Button)sender).Text = "X";
            //GetMealData()
        }
        // gets a random meal
        private object GetMeal()
        {
            var random = new Random();
            var mealIndex = random.Next(MealList.Count);
            return MealList[mealIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Opens Second Form inorder to add meal
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
            
        }
    }
}
