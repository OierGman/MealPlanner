using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assessment1._1
{
    public partial class Form1 : Form
    {
        // add recipe list here
        List<Meals> MealList = new List<Meals>();
        List<string> weeksIngredients = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Meals Initialisation

            // initialising a meal with objects
            List<string> SpaghettiBologneseRecipe = new List<string> { "minced", "spaghetti", "pasata", "cheese" };
            MealList.Add(new Meals("Spaghetti Bolognese", SpaghettiBologneseRecipe, 800, false, true, true));

            List<string> CourgettePakorasRecipe = new List<string> { "Courgette", "Chilli", "Flour" };
            MealList.Add(new Meals("Courgette Pakoras", CourgettePakorasRecipe, 84, true, true, false));

            List<string> VeggieWrapRecipe = new List<string> { "Tortilla", "Red Cabbage", "Olives" };
            MealList.Add(new Meals("Veggie Wraps", VeggieWrapRecipe, 281, true, true, false));

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

            List<string> FalafelRecipe = new List<string> { "Chickpease ", "Onions", "Broad Beans" };
            MealList.Add(new Meals("Falafel", FalafelRecipe, 139, true, true, true));

            List<string> VeganCarbonaraRecipe = new List<string> { "Spagehett", "Cashew Nuts", "Mushrooms" };
            MealList.Add(new Meals("Vegan Carbonara", VeganCarbonaraRecipe, 499, true, true, true));

            List<string> CrunchSaladRecipe = new List<string> { "Almonds", "Radishes", "Edamame" };
            MealList.Add(new Meals("Crunch Salad", CrunchSaladRecipe, 483, true, true, false));

            List<string> CouscousRecipe = new List<string> { "Beetroot", "Couscous", "Tomatoes" };
            MealList.Add(new Meals("Couscous", CouscousRecipe, 461, true, true, false));

            List<string> VeganKormaRecipe = new List<string> { "Spring Onions", "Chickpeas", "Almonds" };
            MealList.Add(new Meals("Vegan Korma", VeganKormaRecipe, 477, true, true, true));

            List<string> SweetPotatoSoupRecipe = new List<string> { "Sweet Potato", "Vegetable Stock", "Garlic" };
            MealList.Add(new Meals("Sweet Potato Soup", SweetPotatoSoupRecipe, 458, true, true, false));

            List<string> GreenBeanSaladRecipe = new List<string> { "Green Beans", "Garlic", "Mint" };
            MealList.Add(new Meals("Green Bean Salad", GreenBeanSaladRecipe, 79, true, true, false));

            List<string> TomatoBasilSoupRecipe = new List<string> { "tomato", "turkey", "basil", "garlic" };
            MealList.Add(new Meals("Tomato & Basil Soup", TomatoBasilSoupRecipe, 213, false, true, true));

            List<string> ChickenPastaBakeRecipe = new List<string> { "tomato", "chicken", "mozzarella", "garlic", "oil" };
            MealList.Add(new Meals("Chicken Pasta Bake", ChickenPastaBakeRecipe, 575, false, true, true));

            List<string> ChickenChorizoRaguRecipe = new List<string> { "tomato", "chicken", "chorizo", "onion", "potatoes" };
            MealList.Add(new Meals("Chicken & Chorizo Ragu", ChickenChorizoRaguRecipe, 383, false, true, true));

            List<string> VegetarianLasagneRecipe = new List<string> { "lasagnaSheets", "tomatoes", "basil", "carrot", "onion" };
            MealList.Add(new Meals("Vegetarian Lasagne", VegetarianLasagneRecipe, 461, true, true, true));

            List<string> MeatBallTomatoSoupRecipe = new List<string> { "tomato", "meatballs", "peppers", "onion", "couscous" };
            MealList.Add(new Meals("Meat & Ball Tomato Soup", MeatBallTomatoSoupRecipe, 330, false, true, true));

            List<string> BroccoliPPPastaRecipe = new List<string> { "broccoli", "pasta", "basil", "tomatoes", "garlic" };
            MealList.Add(new Meals("Broccoli Pesto & Pancetta Pasta", BroccoliPPPastaRecipe, 452, false, true, true));

            List<string> HealthyChickenKCRecipe = new List<string> { "chicken", "currry powder", "tumeric", "rice" };
            MealList.Add(new Meals("Healthy Chicken Katsu Curry", HealthyChickenKCRecipe, 585, false, true, true));

            List<string> SpicedLambWrapsRecipe = new List<string> { "lamb", "tomatoes", "potatoes", "peas" };
            MealList.Add(new Meals("Spiced Lamb Wraps", SpicedLambWrapsRecipe, 576, false, true, true));

            List<string> EasyChickenFajitasRecipe = new List<string> { "chicken", "salad", "tortillas", "pepper" };
            MealList.Add(new Meals("Easy Chicken Fajitas", EasyChickenFajitasRecipe, 723, false, true, true));

            List<string> ChorizoCPPastaRecipe = new List<string> { "chorizo", "penne", "basil", "pepper" };
            MealList.Add(new Meals("Chorizo & Chilli Pepper Pasta", ChorizoCPPastaRecipe, 684, false, true, true));

            List<string> TomatoMascarponeRisottoRecipe = new List<string> { "mascarpone ", "tomatoes", "rice", "basil" };
            MealList.Add(new Meals("Tomato & Mascarpone Risotto", TomatoMascarponeRisottoRecipe, 635, false, true, true));

            List<string> PorkNoddleStirFryRecipe = new List<string> { "mince-pork", "egg", "sweetcorn", "carrot" };
            MealList.Add(new Meals("Pork Noddle Stir Fry", PorkNoddleStirFryRecipe, 599, false, true, true));

            List<string> ChorizoMGBakeRecipe = new List<string> { "Chorizo", "tomatoes", "gnocchi", "mozarella" };
            MealList.Add(new Meals("Chorizo & mozzarella gnocchi bake", ChorizoMGBakeRecipe, 318, false, true, true));

            List<string> BreakfastSmoothieRecipe = new List<string> { "banana", "raspberries", "blueberries", "strawberries" };
            MealList.Add(new Meals("Breakfast Soothie", BreakfastSmoothieRecipe, 124, true, false, false));

            List<string> BreakfastMuffinsRecipe = new List<string> { "banana", "seeds", "blueberries", "flour" };
            MealList.Add(new Meals("Breakfast Muffins", BreakfastMuffinsRecipe, 179, true, false, false));
            #endregion
        }

        private void generate_meals_btn_Click(object sender, EventArgs e)
        {
            Controls.Remove(generate_meals_btn);
            GenerateUi(false);
        }

        // Generates the user interface 
        public void GenerateUi(bool vegan)
        {
            TableLayoutPanel mealTableContainer = new TableLayoutPanel();
            this.Controls.Add(mealTableContainer);
            mealTableContainer.Dock = DockStyle.Fill;
            mealTableContainer.ColumnCount = 2;
            mealTableContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            mealTableContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

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
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Monday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1,
                0);
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Tuesday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2,
                0);
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Wednesday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 3,
                0);
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Thursday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 4,
                0);
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Friday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 5,
                0);
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Saturday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 6,
                0);
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Sunday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 7,
                0);
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Lunch", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 1);
            mealTimeTableWeek.Controls.Add(
                new Label() { Text = "Dinner", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 2);

            // add meal timetable to container
            mealTableContainer.Controls.Add(mealTimeTableWeek);

            // Meal Table Side Panel
            TableLayoutPanel mealSidePanel = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 3
            };
            mealSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mealSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            mealSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            // adds side panel to container
            mealTableContainer.Controls.Add(mealSidePanel);
            // adds meal label
            mealSidePanel.Controls.Add(new Label()
            {
                Text = "MEAL NAME",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
            }, 0, 0);
            mealSidePanel.Controls.Add(new TextBox()
            {
                Text = "MEAL RECIPE",
                Dock = DockStyle.Fill,
                Multiline = true,
            }, 0, 1);
            TableLayoutPanel mealSidePanelButtons = new TableLayoutPanel()
            {
                RowCount = 2,
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            mealSidePanel.Controls.Add(mealSidePanelButtons);

            mealSidePanelButtons.RowStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mealSidePanelButtons.RowStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            mealSidePanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mealSidePanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            Button veganMealsButton = new Button()
            {
                Text = "Vegan Meals Only",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            mealSidePanelButtons.Controls.Add(veganMealsButton);
            veganMealsButton.Click += veganMealsButton_Click;

            Button exportRecipeButton = new Button()
            {
                Text = "Export Recipe",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            mealSidePanelButtons.Controls.Add(exportRecipeButton);
            exportRecipeButton.Click += exportRecipeButton_Click;

            Button coreIngredientsButton = new Button()
            {
                Text = "Core Ingredients Filter",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            mealSidePanelButtons.Controls.Add(coreIngredientsButton);
            coreIngredientsButton.Click += coreIngredientsButton_Click;

            Button addMeals = new Button()
            {
                Text = "Add meals",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            mealSidePanelButtons.Controls.Add(addMeals);
            addMeals.Click += addMeals_Click;

            // creates a meal button for every cell in the mealTimeTableWeek

            for (int i = 1; i <= 7; i++)
            {
                int mealLunch = GetLunch(vegan);
                mealTimeTableWeek.Controls.Add(new Button()
                {
                    Text = MealList[mealLunch].name,
                    // extract ingredient list
                    TextAlign = ContentAlignment.TopCenter,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
                    FlatAppearance =
                        { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                }, i, 1);
                int mealDinner = GetDinner(vegan);
                mealTimeTableWeek.Controls.Add(new Button()
                {
                    Text = MealList[mealDinner].name,
                    // extract ingredient list
                    TextAlign = ContentAlignment.TopCenter,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
                    FlatAppearance =
                        { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                }, i, 2);
            }


            // adds a click event for all meals buttons of mealTimeTableWeek
            foreach (var button in mealTimeTableWeek.Controls.OfType<Button>())
            {
                button.Click += button_Click;
            }
        }

        private void veganMealsButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            GenerateUi(true);
        }

        private void exportRecipeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void coreIngredientsButton_Click(object sender, EventArgs e)
        {
            
        }

        // checks if a meal is a meal, appends ingredients to a list for further use
        public int GetLunch(bool vegan)
        {
            while (true)
            {
                var random = new Random();
                var mealIndex = random.Next(MealList.Count);
                if (MealList[mealIndex].isLunch == true && MealList[mealIndex].isVegan == vegan)
                {
                    foreach (var x in MealList[mealIndex].ingredient)
                    {
                        weeksIngredients.Add(x);
                    }
                    return mealIndex;
                }
            }
        }
        // checks if a meal is a dinner, appends ingredients to a list for further use
        public int GetDinner(bool vegan)
        {
            while (true)
            {
                var random = new Random();
                var mealIndex = random.Next(MealList.Count);
                if (MealList[mealIndex].isDinner == true && MealList[mealIndex].isVegan == vegan)
                {
                    foreach (var x in MealList[mealIndex].ingredient)
                    {
                        weeksIngredients.Add(x);
                    }
                    return mealIndex;
                }
            }
        }
        //Button click to display the shopping list in a pop up box and save it as a .txt file. 
        private void button2_Click(object sender, EventArgs e)
        {
            string shoppingList = string.Join(", ", weeksIngredients.ToArray());

            System.Windows.Forms.MessageBox.Show("This Weeks Shopping List: " + shoppingList);

            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "ShoppingList.txt";
            save.Filter = "Text File | *.txt";
            saveFileDialog1.RestoreDirectory = true;

        // event handler that accesses meal information
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, shoppingList);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            //test works
            ((Button)sender).Text = MealList[GetLunch(false)].name;

            //GetMealData()
        }
        // addMeals button click event handler
        private void addMeals_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
