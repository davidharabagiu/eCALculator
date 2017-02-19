namespace eCALculator
{
    partial class AddFoodForm
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(24, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(225, 22);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "Picture";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Sugars";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Carbs";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Proteins";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Calories";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Name";
            // 
            // AddFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddFoodForm";
            this.Text = "AddFoodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}