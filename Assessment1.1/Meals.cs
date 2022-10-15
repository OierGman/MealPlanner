using System.Collections.Generic;

namespace Assessment1._1
{
    class Meals
    {
        public static List<Meals> MealList = new List<Meals>();
        // meals class 
        private string Name;
        private List<string> Ingredients;
        private int Calorie;
        private bool IsVegan;
        private bool VeganAlternative;
        private bool IsLunch;
        private bool IsDinner;

        public Meals(string name, List<string> ingredients, int calorie, bool isVegan, bool isLunch, bool isDinner)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Calorie = calorie;
            this.IsVegan = isVegan;
            this.IsLunch = isLunch;
            this.IsDinner = isDinner;
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public List<string> ingredient
        {
            get { return Ingredients; }
            set { Ingredients = value; }
        }

        public int calorie
        {
            get { return Calorie; }
            set { Calorie = value; }
        }

        public bool isVegan
        {
            get { return IsVegan; }
            set { IsVegan = value; }
        }

        public bool isLunch
        {
            get { return IsLunch; }
            set { IsLunch = value; }
        }

        public bool isDinner
        {
            get { return IsDinner; }
            set { IsDinner = value; }
        }

        public bool veganAlternative
        {
            get { return VeganAlternative; }
            set { VeganAlternative = value; }
        }
    }
}
