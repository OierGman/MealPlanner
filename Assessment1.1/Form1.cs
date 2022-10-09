using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Plan my meals button click event
        private void generate_meals_btn_Click(object sender, EventArgs e)
        {
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

            mealTableContainer.Controls.Add(mealTimeTableWeek);

            for (int i = 1; i < mealTimeTableWeek.ColumnCount; i++)
            {
                mealTimeTableWeek.Controls.Add(new Button()
                {
                    Text = "Test: " + i, 
                    TextAlign = ContentAlignment.TopCenter,
                    Dock = DockStyle.Fill, 
                    FlatStyle = FlatStyle.Flat, 
                    BackColor = Color.Transparent, 
                    FlatAppearance = { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green}
                }, i, 1);

                mealTimeTableWeek.Controls.Add(new Button()
                {
                    Text = "Test: " + i,
                    TextAlign = ContentAlignment.TopCenter,
                    Dock = DockStyle.Fill, 
                    FlatStyle = FlatStyle.Flat, 
                    BackColor = Color.Transparent, 
                    FlatAppearance = { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green}
                }, i, 2);
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
    }
}
