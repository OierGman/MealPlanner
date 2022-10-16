
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // generate_meals_btn
            // 
            this.generate_meals_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generate_meals_btn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generate_meals_btn.Location = new System.Drawing.Point(338, 272);
            this.generate_meals_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generate_meals_btn.Name = "generate_meals_btn";
            this.generate_meals_btn.Size = new System.Drawing.Size(203, 63);
            this.generate_meals_btn.TabIndex = 0;
            this.generate_meals_btn.Text = "Plan My Meals!";
            this.generate_meals_btn.UseVisualStyleBackColor = true;
            this.generate_meals_btn.Click += new System.EventHandler(this.generate_meals_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 800);
            this.Controls.Add(this.generate_meals_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Meal Allocator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generate_meals_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

