namespace FoodEditor
{
    partial class Form1
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
            this.txtLipids = new System.Windows.Forms.TextBox();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.txtProteins = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFibers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(85, 140);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 22);
            this.textBox6.TabIndex = 19;
            // 
            // txtLipids
            // 
            this.txtLipids.Location = new System.Drawing.Point(231, 84);
            this.txtLipids.Name = "txtLipids";
            this.txtLipids.Size = new System.Drawing.Size(79, 22);
            this.txtLipids.TabIndex = 18;
            // 
            // txtCarbs
            // 
            this.txtCarbs.Location = new System.Drawing.Point(231, 56);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(79, 22);
            this.txtCarbs.TabIndex = 17;
            // 
            // txtProteins
            // 
            this.txtProteins.Location = new System.Drawing.Point(85, 84);
            this.txtProteins.Name = "txtProteins";
            this.txtProteins.Size = new System.Drawing.Size(79, 22);
            this.txtProteins.TabIndex = 16;
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(85, 56);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(79, 22);
            this.txtCalories.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 22);
            this.txtName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Calories:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Proteins:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Carbs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Lipids:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Picture:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.CheckOnClick = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 208);
            this.listBox1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fibers:";
            // 
            // txtFibers
            // 
            this.txtFibers.Location = new System.Drawing.Point(85, 112);
            this.txtFibers.Name = "txtFibers";
            this.txtFibers.Size = new System.Drawing.Size(79, 22);
            this.txtFibers.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 436);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFibers);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtLipids);
            this.Controls.Add(this.txtCarbs);
            this.Controls.Add(this.txtProteins);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FoodEditor for eCALculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtLipids;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.TextBox txtProteins;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFibers;
    }
}

