using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Assessment1._1
{
    public partial class Form1 : Form
    {
        // add recipe list here
        bool veganCheck = false;
        List<string> weeksIngredients = new List<string>();
        CheckedListBox checkLB;
        TextBox selectedIngredient = new TextBox();
        int index;
        Button search;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Meals Initialisation

            // initialising a meal with objects

            List<string> ChickpeaFritterRecipe = new List<string> { "red pepper", "shallots", "carrots", "garlic", "lemon", "ginger", "chickpeas", "garam masala", "cumin", "coriander", "plain flour", "egg", "cucumber", "Greek yoghurt"};
            Meals.MealList.Add(new Meals("Chickpea Fritters", ChickpeaFritterRecipe, 700, true, true, true, true));

            List<string> BabyPastaSauceRecipe = new List<string> { "tomatoes", "red pepper", "garlic cloves", "courgettes", "red onion", "basil", "oregano" };
            Meals.MealList.Add(new Meals("Chickpea Fritters", BabyPastaSauceRecipe, 400, true, true, true, true));

            List<string> HealthyPancakesRecipe = new List<string> { "self-raising flour", "wholegrain flour", "eggs", "skimmed milk", "berries", "low-fat yogurt" };
            Meals.MealList.Add(new Meals("Healthy Pancakes", HealthyPancakesRecipe, 450, false, true, false, true));

            List<string> HealthyPumpkinSoupRecipe = new List<string> { "pumpkin", "jumbo oats", "coriander seeds", "chilli flakes", "tamari", "maple syrup", "olive oil", "onion", "celery sticks", "carrots", "garlic cloves", "vegetable stock" };
            Meals.MealList.Add(new Meals("Healthy Pumpkin Soup", HealthyPumpkinSoupRecipe, 300, true, true, true, true));

            List<string> ChickenTacosRecipe = new List<string> { "cumin", "smoked paprika", "chicken breasts", "tomatoes", "red pepper", "red onion", "lime juice", "chilli flakes", "avocados", "spring onions", "coriander", "corn tacos", "shells", "Greek yogurt", "Gem lettuce" };
            Meals.MealList.Add(new Meals("Chicken Tacos", ChickenTacosRecipe, 500, false, true, true, true));

            List<string> TurkeyBurgersRecipe = new List<string> { "turkey mince", "thyme", "lemon", "beetroot", "red onion", "parsley", "olive oil", "wholegrain mustard", "Gem lettuce", "wholemeal pitta bread" };
            Meals.MealList.Add(new Meals("Turkey burgers with beetroot relish", TurkeyBurgersRecipe, 400, false, true, true, true));

            List<string> FishfingersMushypeasRecipe = new List<string> { "pollock", "plain flour", "egg", "breadcrumb", "vegetable oil", "frozen peas", "butter", "lemon", "mint", "new potatoes" };
            Meals.MealList.Add(new Meals("Fish fingers & mushy peas", FishfingersMushypeasRecipe, 400, false, true, true, true));

            List<string> BakedPotatoesRecipe = new List<string> { "baking potatoes", "sunflower oil", "butter", "cheese", "baked beans", "tuna mayonnaise" };
            Meals.MealList.Add(new Meals("Baked potatoes", BakedPotatoesRecipe, 400, false, true, true, true));

            List<string> ChickenChorizoJambalayaRecipe = new List<string> { "olive oil", "chicken breasts", "onion", "red pepper", "garlic", "chorizo", "Cajun seasoning", "long grain rice", "plum tomato", "chicken stock" };
            Meals.MealList.Add(new Meals("Chicken & Chorizo Jambalaya", ChickenChorizoJambalayaRecipe, 800, false, true, true, true));

            List<string> GingerbreadMenRecipe = new List<string> { "Muscovado sugar", "golden syrup", "butter", "plain flour", "bicarbonate of soda", "ground ginger", "ground cinnamon", "egg", "icing", "chocolate buttons" };
            Meals.MealList.Add(new Meals("Gingerbread Men", GingerbreadMenRecipe, 700, false, true, true, true));

            List<string> PepperTomatoHamOmeletteRecipe = new List<string> { "eggs", "egg white", "olive oil", "red pepper", "spring onions", "sliced ham", "mature cheddar", "wholemeal toast", "fresh tomatoes" };
            Meals.MealList.Add(new Meals("Pepper, Tomato & Ham Omelette", PepperTomatoHamOmeletteRecipe, 400, true, true, true, true));

            List<string> HealthyBeefStewRecipe = new List<string> { "onion", "garlic", "olive oil", "beef stir-fry strips", "yellow pepper", "tomato", "rosemary", "pitted olives" };
            Meals.MealList.Add(new Meals("Healthy Beef Stew", HealthyBeefStewRecipe, 600, false, true, true, true));

            List<string> ChickenSaladRecipe = new List<string> { "chicken breast", "fish sauce", "lime", "caster sugar", "mixed salad leaves", "coriander", "red onion", "chilli", "cucumber" };
            Meals.MealList.Add(new Meals("Chicken Salad", ChickenSaladRecipe, 350, false, true, true, true));

            List<string> ChickenParmigianaRecipe = new List<string> { "chicken breasts", "eggs", "breadcrumb", "parmesan", "olive oil", "garlic", "passata", "caster sugar", "dried oregano", "mozzarella" };
            Meals.MealList.Add(new Meals("Chicken Parmigiana", ChickenParmigianaRecipe, 750, false, true, true, true));

            List<string> ToadInTheHoleRecipe = new List<string> { "chipolatas", "sunflower oil", "plain flour", "egg", "semi-skimmed milk" };
            Meals.MealList.Add(new Meals("Toad-in-the-hole", ToadInTheHoleRecipe, 400, true, true, true, true));

            List<string> VegTacosRecipe = new List<string> { "red peppers", "olive oil", "fennel bulb", "onion", "carrot", "garlic", "chillies", "fennel seeds", "tomato purée", "tomatoes", "vegetable stock", "caster sugar", "basil", "tortillas" };
            Meals.MealList.Add(new Meals("Veg Tacos", VegTacosRecipe, 525, true, true, true, true));

            List<string> KidsPastaSaladRecipe = new List<string> { "pasta", "olive oil", "red wine vinegar", "oregano", "cherry tomatoes", "olives", "cucumber", "red onion", "feta cheese"};
            Meals.MealList.Add(new Meals("Kids' pasta salad", KidsPastaSaladRecipe, 400, false, true, true, true));

            List<string> SausageWhiteBeanCasseroleRecipe = new List<string> { "yellow pepper", "carrots", "red onion", "chipolatas", "cherry tomatoes", "white beans", "chicken stock", "Dijon mustard", "frozen peas", "potatoes" };
            Meals.MealList.Add(new Meals("Sausage & White Bean Casserole", SausageWhiteBeanCasseroleRecipe, 650, false, true, true, true));

            List<string> TeriyakiSalmonRecipe = new List<string> { "soy sauce", "honey", "garlic", "mirin", "sunflower oil", "Tenderstem broccoli", "salmon fillets", "ginger", "sesame oil", "spring onions", "toasted", "sesame seeds", "rice" };
            Meals.MealList.Add(new Meals("Teriyaki Salmon", TeriyakiSalmonRecipe, 550, false, true, true, true));

            List<string> VeganChilliRecipe = new List<string> { "olive oil", "sweet potato", "smoked paprika", "ground cumin", "onion", "carrots", "celery sticks", "garlic", "chilli powder", "oregano", "tomato purée", "red pepper", "chopped tomatoes", "black beans", "kidney beans", "lime", "guacamole", "rice", "coriander" };
            Meals.MealList.Add(new Meals("Vegan Chilli", VeganChilliRecipe, 600, true, true, true, true));

            List<string> SpaghettiBologneseRecipe = new List<string> { "minced", "spaghetti", "pasata", "cheese" };
            Meals.MealList.Add(new Meals("Spaghetti Bolognese", SpaghettiBologneseRecipe, 800, false, true, true, true));

            List<string> CourgettePakorasRecipe = new List<string> { "Courgette", "Chilli", "Flour" };
            Meals.MealList.Add(new Meals("Courgette Pakoras", CourgettePakorasRecipe, 84, true, true, false, false));

            List<string> VeggieWrapRecipe = new List<string> { "Tortilla", "Red Cabbage", "Olives" };
            Meals.MealList.Add(new Meals("Veggie Wraps", VeggieWrapRecipe, 281, true, true, false, true));

            List<string> SpinnachMushroomPastaRecipe = new List<string> { "Penne Pasta", "Mushroom", "Spinnach" };
            Meals.MealList.Add(new Meals("Spinach Mushroom Pasta", SpinnachMushroomPastaRecipe, 483, true, true, true, false));

            List<string> VeganBuritoRecipe = new List<string> { "Tortilla", "Rice", "Black Beans" };
            Meals.MealList.Add(new Meals("Vegan Burrito", VeganBuritoRecipe, 513, true, true, false, true));

            List<string> CourgetteCurryRecipe = new List<string> { "Rice", "Courgette", "Chickpeas" };
            Meals.MealList.Add(new Meals("Courgette Curry", CourgetteCurryRecipe, 487, true, false, true, false));

            List<string> CoconutDahlRecipe = new List<string> { "Tomatoes", "Chickpeas", "lentils" };
            Meals.MealList.Add(new Meals("Coconut Dahl", CoconutDahlRecipe, 338, true, true, true, true));

            List<string> JackfruitBurgerRecipe = new List<string> { "Jackfruit", "Mushroom", "Potato" };
            Meals.MealList.Add(new Meals("Jackfruit Burger", JackfruitBurgerRecipe, 416, true, true, true, true));

            List<string> FalafelRecipe = new List<string> { "Chickpease ", "Onions", "Broad Beans" };
            Meals.MealList.Add(new Meals("Falafel", FalafelRecipe, 139, true, true, true, true));

            List<string> VeganCarbonaraRecipe = new List<string> { "Spagehett", "Cashew Nuts", "Mushrooms" };
            Meals.MealList.Add(new Meals("Vegan Carbonara", VeganCarbonaraRecipe, 499, true, true, true, true));

            List<string> CrunchSaladRecipe = new List<string> { "Almonds", "Radishes", "Edamame" };
            Meals.MealList.Add(new Meals("Crunch Salad", CrunchSaladRecipe, 483, true, true, false, false));

            List<string> CouscousRecipe = new List<string> { "Beetroot", "Couscous", "Tomatoes" };
            Meals.MealList.Add(new Meals("Couscous", CouscousRecipe, 461, true, true, false, false));

            List<string> VeganKormaRecipe = new List<string> { "Spring Onions", "Chickpeas", "Almonds" };
            Meals.MealList.Add(new Meals("Vegan Korma", VeganKormaRecipe, 477, true, true, true, true));

            List<string> SweetPotatoSoupRecipe = new List<string> { "Sweet Potato", "Vegetable Stock", "Garlic" };
            Meals.MealList.Add(new Meals("Sweet Potato Soup", SweetPotatoSoupRecipe, 458, true, true, false, true));

            List<string> GreenBeanSaladRecipe = new List<string> { "Green Beans", "Garlic", "Mint" };
            Meals.MealList.Add(new Meals("Green Bean Salad", GreenBeanSaladRecipe, 79, true, true, false, false));

            List<string> TomatoBasilSoupRecipe = new List<string> { "tomato", "turkey", "basil", "garlic" };
            Meals.MealList.Add(new Meals("Tomato & Basil Soup", TomatoBasilSoupRecipe, 213, false, true, true, false));

            List<string> ChickenPastaBakeRecipe = new List<string> { "tomato", "chicken", "mozzarella", "garlic", "oil" };
            Meals.MealList.Add(new Meals("Chicken Pasta Bake", ChickenPastaBakeRecipe, 575, false, true, true, true));

            List<string> ChickenChorizoRaguRecipe = new List<string> { "tomato", "chicken", "chorizo", "onion", "potatoes" };
            Meals.MealList.Add(new Meals("Chicken & Chorizo Ragu", ChickenChorizoRaguRecipe, 383, false, true, true, true));

            List<string> VegetarianLasagneRecipe = new List<string> { "lasagnaSheets", "tomatoes", "basil", "carrot", "onion" };
            Meals.MealList.Add(new Meals("Vegetarian Lasagne", VegetarianLasagneRecipe, 461, true, true, true, true));

            List<string> MeatBallTomatoSoupRecipe = new List<string> { "tomato", "meatballs", "peppers", "onion", "couscous" };
            Meals.MealList.Add(new Meals("Meat & Ball Tomato Soup", MeatBallTomatoSoupRecipe, 330, false, true, true, true));

            List<string> BroccoliPPPastaRecipe = new List<string> { "broccoli", "pasta", "basil", "tomatoes", "garlic" };
            Meals.MealList.Add(new Meals("Broccoli Pesto & Pancetta Pasta", BroccoliPPPastaRecipe, 452, false, true, true, false));

            List<string> HealthyChickenKCRecipe = new List<string> { "chicken", "currry powder", "tumeric", "rice" };
            Meals.MealList.Add(new Meals("Healthy Chicken Katsu Curry", HealthyChickenKCRecipe, 585, false, true, true, false));

            List<string> SpicedLambWrapsRecipe = new List<string> { "lamb", "tomatoes", "potatoes", "peas" };
            Meals.MealList.Add(new Meals("Spiced Lamb Wraps", SpicedLambWrapsRecipe, 576, false, true, true, true));

            List<string> EasyChickenFajitasRecipe = new List<string> { "chicken", "salad", "tortillas", "pepper" };
            Meals.MealList.Add(new Meals("Easy Chicken Fajitas", EasyChickenFajitasRecipe, 723, false, true, true, true));

            List<string> ChorizoCPPastaRecipe = new List<string> { "chorizo", "penne", "basil", "pepper" };
            Meals.MealList.Add(new Meals("Chorizo & Chilli Pepper Pasta", ChorizoCPPastaRecipe, 684, false, true, true, true));

            List<string> TomatoMascarponeRisottoRecipe = new List<string> { "mascarpone ", "tomatoes", "rice", "basil" };
            Meals.MealList.Add(new Meals("Tomato & Mascarpone Risotto", TomatoMascarponeRisottoRecipe, 635, false, true, true, false));

            List<string> PorkNoddleStirFryRecipe = new List<string> { "mince-pork", "egg", "sweetcorn", "carrot" };
            Meals.MealList.Add(new Meals("Pork Noddle Stir Fry", PorkNoddleStirFryRecipe, 599, false, true, true, true));

            List<string> ChorizoMGBakeRecipe = new List<string> { "Chorizo", "tomatoes", "gnocchi", "mozarella" };
            Meals.MealList.Add(new Meals("Chorizo & mozzarella gnocchi bake", ChorizoMGBakeRecipe, 318, false, true, true, true));

            List<string> BreakfastSmoothieRecipe = new List<string> { "banana", "raspberries", "blueberries", "strawberries" };
            Meals.MealList.Add(new Meals("Breakfast Soothie", BreakfastSmoothieRecipe, 124, true, false, false, true));

            List<string> BreakfastMuffinsRecipe = new List<string> { "banana", "seeds", "blueberries", "flour" };
            Meals.MealList.Add(new Meals("Breakfast Muffins", BreakfastMuffinsRecipe, 179, true, false, false, true));
            #endregion
        }

        private void generate_meals_btn_Click(object sender, EventArgs e)
        {
            // load new checkbox and populated
            CreateCheckedlistBox();
            BindCheckedlistBox();
            CreateTxtBox();
            CreateSearchButton();

            Controls.Remove(generate_meals_btn);
            GenerateUi(false);
        }

        // initialize new checkedlistbox
        private void CreateCheckedlistBox()
        {
            checkLB = new CheckedListBox();
            checkLB.FormattingEnabled = true;
            checkLB.Name = "CheckedListBox1";
            checkLB.Dock = DockStyle.Fill;
            checkLB.CheckOnClick = true;
            checkLB.ItemCheck += checkLB_ItemCheck;
        }

        // populate checkedlistbox
        public void BindCheckedlistBox()
        {
            for (int i = 0; i < Meals.MealList.Count; i++)
            {
                checkLB.Items.Add(Meals.MealList[i].name);
            }
        }

        private void CreateSearchButton()
        {
            search = new Button()
            {
                Text = "Core Ingredients Filter",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Coral,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            search.Click += coreIngredientsButton_Click;
        }
        private void checkLB_ItemCheck(System.Object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkLB.CheckedItems.Count > 0)
            {
                // only one check box active at any given time
                checkLB.ItemCheck -= checkLB_ItemCheck;
                checkLB.SetItemChecked(checkLB.CheckedIndices[0], false);
                checkLB.ItemCheck += checkLB_ItemCheck;
            }
            // store index of checked item
            index = e.Index;
            MessageBox.Show("SELECT DAY AND DAYPART FOR THIS MEAL");
        }

        private void CreateTxtBox()
        {
            selectedIngredient.Text = "search by ingredient or daypart";
            selectedIngredient.Dock = DockStyle.Fill;
            selectedIngredient.Enter += textBox_Enter;
            selectedIngredient.Leave += textBox_Leave;

        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (selectedIngredient.Text == "search by ingredient or daypart")
            {
                selectedIngredient.Text = "";
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (selectedIngredient.Text == "")
            {
                selectedIngredient.Text = "search by ingredient or daypart";
            }
        }

        // Generates the user interface 
        public void GenerateUi(bool veganCheck)
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
            mealTimeTableWeek.BackColor = Color.LightBlue;
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
                RowCount = 3,
                BackColor = Color.LightCoral
            };
            mealSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            mealSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            mealSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            mealSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            mealSidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
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

            mealSidePanel.Controls.Add(selectedIngredient, 0, 2);
            mealSidePanel.Controls.Add(search, 0, 3);

            mealSidePanel.Controls.Add(checkLB);
            
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

            Button kidsButton = new Button()
            {
                Text = "Kids Meal Filter",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Coral,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            mealSidePanelButtons.Controls.Add(kidsButton);
            kidsButton.Click += coreIngredientsButton_Click;

            Button veganMealsButton = new Button()
            {
                Text = "Vegan Meals Only",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Coral,
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
                BackColor = Color.Coral,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            mealSidePanelButtons.Controls.Add(exportRecipeButton);
            exportRecipeButton.Click += exportRecipeButton_Click;

            Button addMeals = new Button()
            {
                Text = "Add meals",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Coral,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            mealSidePanelButtons.Controls.Add(addMeals);
            addMeals.Click += addMeals_Click;

            // creates a meal button for every cell in the mealTimeTableWeek

            for (int i = 1; i <= 7; i++)
            {
                int mealLunch = GetLunch();
                mealTimeTableWeek.Controls.Add(new Button()
                {
                    Text = Meals.MealList[mealLunch].name + "\n\n\n\n\n\n\n kcal - " + Meals.MealList[mealLunch].calorie.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.WhiteSmoke,
                    FlatAppearance =
                        { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                }, i, 1);
                int mealDinner = GetDinner();

                mealTimeTableWeek.Controls.Add(new Button()
                {
                    Text = Meals.MealList[mealDinner].name + "\n\n\n\n\n\n\n kcal - " + Meals.MealList[mealDinner].calorie.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.WhiteSmoke,
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
            // loads new UI based on vegan/meat toggle
            weeksIngredients.Clear();

            this.Controls.Clear();
            veganCheck = !veganCheck;
            GenerateUi(veganCheck);

            checkLB.Items.Clear();

            for (int i = 0; i < Meals.MealList.Count; i++)
            {
                if (veganCheck == true)
                {
                    if (Meals.MealList[i].isVegan == true)
                    {
                        checkLB.Items.Add(Meals.MealList[i].name);
                    }
                }
                else
                {
                    checkLB.Items.Add(Meals.MealList[i].name);
                }
            }
        }

        private void exportRecipeButton_Click(object sender, EventArgs e)
        {
            var weeksIngredients2 = weeksIngredients.Distinct().ToList();
            string shoppingList = string.Join(", ", weeksIngredients2.ToArray());

            System.Windows.Forms.MessageBox.Show("This Weeks Shopping List: " + shoppingList);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                File.WriteAllText(name, shoppingList);
            }
        }

        private void coreIngredientsButton_Click(object sender, EventArgs e)
        {
            // rashid working here
            if (selectedIngredient.Text.ToLower() == "lunch" || selectedIngredient.Text.ToLower() == "dinner")
            {
                checkLB.Items.Clear();

                for (int i = 0; i < Meals.MealList.Count; i++)
                {
                    if (Meals.MealList[i].isLunch == true && selectedIngredient.Text.ToLower() == "lunch")
                    {
                        checkLB.Items.Add(Meals.MealList[i].name);
                        
                    }
                    if (Meals.MealList[i].isDinner == true && selectedIngredient.Text.ToLower() == "dinner")
                    {
                        checkLB.Items.Add(Meals.MealList[i].name);
                    }
                }
            }
            else if (selectedIngredient.Text == " " || selectedIngredient.Text == "search by ingredient or daypart")
            {
                checkLB.Items.Clear();
                BindCheckedlistBox();
            }
            else if (selectedIngredient.Text.Length > 2 )
            {
                checkLB.Items.Clear();

                for (int i = 0; i < Meals.MealList.Count; i++)
                {
                    for (int j = 0; j < Meals.MealList[i].ingredient.Count; j++)
                    {
                        if (selectedIngredient.Text.ToLower() == Meals.MealList[i].ingredient[j].ToLower())
                        {
                            checkLB.Items.Add(Meals.MealList[i].name);
                        }
                    }
                }
            }
            else
            {
                return;
            }
            // rashidmethod(coreIngredient);
        }

        // checks if a meal is a meal, appends ingredients to a list for further use
        public int GetLunch()
        {
            while (true)
            {
                var random = new Random();
                var mealIndex = random.Next(Meals.MealList.Count);
                if (Meals.MealList[mealIndex].isLunch == true && Meals.MealList[mealIndex].isVegan == veganCheck)
                {
                    foreach (var x in Meals.MealList[mealIndex].ingredient)
                    {
                        weeksIngredients.Add(x);
                    }
                    return mealIndex;
                }
            }
        }
        // checks if a meal is a dinner, appends ingredients to a list for further use
        public int GetDinner()
        {
            while (true)
            {
                var random = new Random();
                var mealIndex = random.Next(Meals.MealList.Count);
                if (Meals.MealList[mealIndex].isDinner == true && Meals.MealList[mealIndex].isVegan == veganCheck)
                {
                    foreach (var x in Meals.MealList[mealIndex].ingredient)
                    {
                        weeksIngredients.Add(x);
                    }
                    return mealIndex;
                }
            }
        }
       
        private void button_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            for (int i = 0; i < Meals.MealList.Count; i++)
            {
                if (s == Meals.MealList[i].name)
                {
                    for (int j = 0; j < Meals.MealList[i].ingredient.Count; j++)
                    {
                        for (int k = 0; k < weeksIngredients.Count; k++)
                        {
                            if (weeksIngredients[k] == Meals.MealList[i].ingredient[j])
                            {
                                weeksIngredients.RemoveAt(k);
                            }
                        }
                    }
                }
            }
            try
            {
                ((Button)sender).Text = checkLB.CheckedItems[0].ToString();

                for (int x = 0; x < Meals.MealList.Count; x++)
                {
                    if (checkLB.CheckedItems[0].ToString() == Meals.MealList[x].name)
                    {
                        foreach (var y in Meals.MealList[x].ingredient)
                        {
                            weeksIngredients.Add(y);
                        }
                        ((Button)sender).Text += "\n\n\n\n\n\n\n kcal - " + Meals.MealList[x].calorie.ToString();
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No meal selected in side panel");
            }
        }

        // addMeals button click event handler
        private void addMeals_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
