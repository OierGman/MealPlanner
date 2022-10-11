
namespace Assessment1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generate_meals_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate_meals_btn
            // 
            this.generate_meals_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generate_meals_btn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generate_meals_btn.Location = new System.Drawing.Point(549, 435);
            this.generate_meals_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.generate_meals_btn.Name = "generate_meals_btn";
            this.generate_meals_btn.Size = new System.Drawing.Size(330, 101);
            this.generate_meals_btn.TabIndex = 0;
            this.generate_meals_btn.Text = "Plan My Meals!";
            this.generate_meals_btn.UseVisualStyleBackColor = true;
            this.generate_meals_btn.Click += new System.EventHandler(this.generate_meals_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1223, 856);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Meal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1485, 960);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generate_meals_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Meal Allocator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generate_meals_btn;
        private System.Windows.Forms.Button button1;
    }
}

