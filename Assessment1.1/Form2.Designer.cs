﻿namespace Assessment1._1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MealNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CaloriesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VeganYesBtn = new System.Windows.Forms.RadioButton();
            this.VeganNoBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.LunchCheckBox = new System.Windows.Forms.CheckBox();
            this.DinnerCheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IngridientsTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meal Name";
            // 
            // MealNameTextBox
            // 
            this.MealNameTextBox.Location = new System.Drawing.Point(9, 42);
            this.MealNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MealNameTextBox.Name = "MealNameTextBox";
            this.MealNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.MealNameTextBox.TabIndex = 3;
            this.MealNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calories";
            // 
            // CaloriesTextBox
            // 
            this.CaloriesTextBox.Location = new System.Drawing.Point(7, 113);
            this.CaloriesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CaloriesTextBox.Name = "CaloriesTextBox";
            this.CaloriesTextBox.Size = new System.Drawing.Size(125, 27);
            this.CaloriesTextBox.TabIndex = 5;
            this.CaloriesTextBox.TextChanged += new System.EventHandler(this.CaloriesTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lunch Or Dinner";
            // 
            // VeganYesBtn
            // 
            this.VeganYesBtn.AutoSize = true;
            this.VeganYesBtn.Location = new System.Drawing.Point(262, 131);
            this.VeganYesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VeganYesBtn.Name = "VeganYesBtn";
            this.VeganYesBtn.Size = new System.Drawing.Size(51, 24);
            this.VeganYesBtn.TabIndex = 7;
            this.VeganYesBtn.TabStop = true;
            this.VeganYesBtn.Text = "Yes";
            this.VeganYesBtn.UseVisualStyleBackColor = true;
            this.VeganYesBtn.CheckedChanged += new System.EventHandler(this.VeganYesBtn_CheckedChanged);
            // 
            // VeganNoBtn
            // 
            this.VeganNoBtn.AutoSize = true;
            this.VeganNoBtn.Location = new System.Drawing.Point(330, 131);
            this.VeganNoBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VeganNoBtn.Name = "VeganNoBtn";
            this.VeganNoBtn.Size = new System.Drawing.Size(50, 24);
            this.VeganNoBtn.TabIndex = 8;
            this.VeganNoBtn.TabStop = true;
            this.VeganNoBtn.Text = "No";
            this.VeganNoBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vegan?";
            // 
            // LunchCheckBox
            // 
            this.LunchCheckBox.AutoSize = true;
            this.LunchCheckBox.Location = new System.Drawing.Point(9, 183);
            this.LunchCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LunchCheckBox.Name = "LunchCheckBox";
            this.LunchCheckBox.Size = new System.Drawing.Size(69, 24);
            this.LunchCheckBox.TabIndex = 10;
            this.LunchCheckBox.Text = "Lunch";
            this.LunchCheckBox.UseVisualStyleBackColor = true;
            this.LunchCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DinnerCheckbox
            // 
            this.DinnerCheckbox.AutoSize = true;
            this.DinnerCheckbox.Location = new System.Drawing.Point(7, 218);
            this.DinnerCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DinnerCheckbox.Name = "DinnerCheckbox";
            this.DinnerCheckbox.Size = new System.Drawing.Size(75, 24);
            this.DinnerCheckbox.TabIndex = 11;
            this.DinnerCheckbox.Text = "Dinner";
            this.DinnerCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Core Ingridients (seperate with Comma)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // IngridientsTxtBox
            // 
            this.IngridientsTxtBox.Location = new System.Drawing.Point(187, 42);
            this.IngridientsTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IngridientsTxtBox.Name = "IngridientsTxtBox";
            this.IngridientsTxtBox.Size = new System.Drawing.Size(125, 27);
            this.IngridientsTxtBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Test";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 281);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IngridientsTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DinnerCheckbox);
            this.Controls.Add(this.LunchCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VeganNoBtn);
            this.Controls.Add(this.VeganYesBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CaloriesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MealNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MealNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CaloriesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton VeganYesBtn;
        private System.Windows.Forms.RadioButton VeganNoBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox LunchCheckBox;
        private System.Windows.Forms.CheckBox DinnerCheckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IngridientsTxtBox;
        private System.Windows.Forms.Label label6;
    }
}