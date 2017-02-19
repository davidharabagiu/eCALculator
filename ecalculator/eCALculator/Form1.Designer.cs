namespace eCALculator
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
            this.components = new System.ComponentModel.Container();
            this.listAllFoods = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listCategories = new System.Windows.Forms.ListBox();
            this.listEaten = new System.Windows.Forms.ListView();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCalories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnProteins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCarbs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnLipids = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFibers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelProteins = new System.Windows.Forms.Label();
            this.labelCarbs = new System.Windows.Forms.Label();
            this.labelLipids = new System.Windows.Forms.Label();
            this.labelFibers = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressCalories = new System.Windows.Forms.ProgressBar();
            this.progressProteins = new System.Windows.Forms.ProgressBar();
            this.progressCarbs = new System.Windows.Forms.ProgressBar();
            this.progressLipids = new System.Windows.Forms.ProgressBar();
            this.progressFibers = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelGoalCalories = new System.Windows.Forms.Label();
            this.labelGoalProteins = new System.Windows.Forms.Label();
            this.labelGoalCarbs = new System.Windows.Forms.Label();
            this.labelGoalLipids = new System.Windows.Forms.Label();
            this.labelGoalFibers = new System.Windows.Forms.Label();
            this.labelWarningCalories = new System.Windows.Forms.Label();
            this.labelWarningProteins = new System.Windows.Forms.Label();
            this.labelWarningCarbs = new System.Windows.Forms.Label();
            this.labelWarningLipids = new System.Windows.Forms.Label();
            this.labelWarningFibers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSelectedCalories = new System.Windows.Forms.Label();
            this.labelSelectedProteins = new System.Windows.Forms.Label();
            this.labelSelectedCarbs = new System.Windows.Forms.Label();
            this.labelSelectedLipids = new System.Windows.Forms.Label();
            this.labelSelectedFibers = new System.Windows.Forms.Label();
            this.labelSelectedFood = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listAllFoods
            // 
            this.listAllFoods.Location = new System.Drawing.Point(15, 40);
            this.listAllFoods.Name = "listAllFoods";
            this.listAllFoods.Size = new System.Drawing.Size(525, 406);
            this.listAllFoods.TabIndex = 0;
            this.listAllFoods.UseCompatibleStateImageBehavior = false;
            this.listAllFoods.SelectedIndexChanged += new System.EventHandler(this.listAllFoods_SelectedIndexChanged);
            this.listAllFoods.DoubleClick += new System.EventHandler(this.listAllFoods_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(110, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(430, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search foods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(542, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categories";
            // 
            // listCategories
            // 
            this.listCategories.FormattingEnabled = true;
            this.listCategories.ItemHeight = 16;
            this.listCategories.Location = new System.Drawing.Point(546, 42);
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(167, 164);
            this.listCategories.TabIndex = 4;
            this.listCategories.Click += new System.EventHandler(this.listCategories_Click);
            // 
            // listEaten
            // 
            this.listEaten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnQuantity,
            this.ColumnCalories,
            this.ColumnProteins,
            this.ColumnCarbs,
            this.ColumnLipids,
            this.ColumnFibers});
            this.listEaten.Location = new System.Drawing.Point(724, 40);
            this.listEaten.Name = "listEaten";
            this.listEaten.Size = new System.Drawing.Size(713, 567);
            this.listEaten.TabIndex = 5;
            this.listEaten.UseCompatibleStateImageBehavior = false;
            this.listEaten.View = System.Windows.Forms.View.Details;
            this.listEaten.DoubleClick += new System.EventHandler(this.listEaten_DoubleClick);
            // 
            // ColumnName
            // 
            this.ColumnName.Tag = "Name";
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 150;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.Tag = "Quantity";
            this.ColumnQuantity.Text = "Quantity";
            this.ColumnQuantity.Width = 70;
            // 
            // ColumnCalories
            // 
            this.ColumnCalories.Tag = "Calories";
            this.ColumnCalories.Text = "Calories";
            this.ColumnCalories.Width = 70;
            // 
            // ColumnProteins
            // 
            this.ColumnProteins.Tag = "Proteins";
            this.ColumnProteins.Text = "Proteins";
            this.ColumnProteins.Width = 70;
            // 
            // ColumnCarbs
            // 
            this.ColumnCarbs.Tag = "Carbs";
            this.ColumnCarbs.Text = "Carbs";
            this.ColumnCarbs.Width = 70;
            // 
            // ColumnLipids
            // 
            this.ColumnLipids.Text = "Lipids";
            this.ColumnLipids.Width = 70;
            // 
            // ColumnFibers
            // 
            this.ColumnFibers.Text = "Fibers";
            this.ColumnFibers.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(720, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eaten today";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Today\'s stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calories:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Proteins:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Carbs:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Lipids:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Quantity";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(654, 452);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(59, 22);
            this.textQuantity.TabIndex = 14;
            this.textQuantity.Text = "100";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Location = new System.Drawing.Point(81, 521);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(16, 17);
            this.labelCalories.TabIndex = 15;
            this.labelCalories.Text = "0";
            // 
            // labelProteins
            // 
            this.labelProteins.AutoSize = true;
            this.labelProteins.Location = new System.Drawing.Point(81, 544);
            this.labelProteins.Name = "labelProteins";
            this.labelProteins.Size = new System.Drawing.Size(16, 17);
            this.labelProteins.TabIndex = 16;
            this.labelProteins.Text = "0";
            // 
            // labelCarbs
            // 
            this.labelCarbs.AutoSize = true;
            this.labelCarbs.Location = new System.Drawing.Point(81, 567);
            this.labelCarbs.Name = "labelCarbs";
            this.labelCarbs.Size = new System.Drawing.Size(16, 17);
            this.labelCarbs.TabIndex = 17;
            this.labelCarbs.Text = "0";
            // 
            // labelLipids
            // 
            this.labelLipids.AutoSize = true;
            this.labelLipids.Location = new System.Drawing.Point(81, 590);
            this.labelLipids.Name = "labelLipids";
            this.labelLipids.Size = new System.Drawing.Size(16, 17);
            this.labelLipids.TabIndex = 18;
            this.labelLipids.Text = "0";
            // 
            // labelFibers
            // 
            this.labelFibers.AutoSize = true;
            this.labelFibers.Location = new System.Drawing.Point(81, 613);
            this.labelFibers.Name = "labelFibers";
            this.labelFibers.Size = new System.Drawing.Size(16, 17);
            this.labelFibers.TabIndex = 19;
            this.labelFibers.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 613);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Fibers:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1000, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Am I in shape?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 47);
            this.button2.TabIndex = 22;
            this.button2.Text = "Filter by nutritive values";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(726, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 43);
            this.button3.TabIndex = 23;
            this.button3.Text = "Weekly plan setup";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressCalories
            // 
            this.progressCalories.Location = new System.Drawing.Point(148, 521);
            this.progressCalories.Name = "progressCalories";
            this.progressCalories.Size = new System.Drawing.Size(100, 17);
            this.progressCalories.TabIndex = 24;
            this.progressCalories.Visible = false;
            // 
            // progressProteins
            // 
            this.progressProteins.Location = new System.Drawing.Point(148, 544);
            this.progressProteins.Name = "progressProteins";
            this.progressProteins.Size = new System.Drawing.Size(100, 17);
            this.progressProteins.TabIndex = 25;
            this.progressProteins.Visible = false;
            // 
            // progressCarbs
            // 
            this.progressCarbs.Location = new System.Drawing.Point(148, 567);
            this.progressCarbs.Name = "progressCarbs";
            this.progressCarbs.Size = new System.Drawing.Size(100, 17);
            this.progressCarbs.TabIndex = 26;
            this.progressCarbs.Visible = false;
            // 
            // progressLipids
            // 
            this.progressLipids.Location = new System.Drawing.Point(148, 590);
            this.progressLipids.Name = "progressLipids";
            this.progressLipids.Size = new System.Drawing.Size(100, 17);
            this.progressLipids.TabIndex = 27;
            this.progressLipids.Visible = false;
            // 
            // progressFibers
            // 
            this.progressFibers.Location = new System.Drawing.Point(148, 613);
            this.progressFibers.Name = "progressFibers";
            this.progressFibers.Size = new System.Drawing.Size(100, 17);
            this.progressFibers.TabIndex = 28;
            this.progressFibers.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Goal:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 544);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Goal:";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 567);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Goal:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 590);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Goal:";
            this.label13.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 613);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Goal:";
            this.label15.Visible = false;
            // 
            // labelGoalCalories
            // 
            this.labelGoalCalories.AutoSize = true;
            this.labelGoalCalories.Location = new System.Drawing.Point(302, 521);
            this.labelGoalCalories.Name = "labelGoalCalories";
            this.labelGoalCalories.Size = new System.Drawing.Size(16, 17);
            this.labelGoalCalories.TabIndex = 34;
            this.labelGoalCalories.Text = "0";
            this.labelGoalCalories.Visible = false;
            // 
            // labelGoalProteins
            // 
            this.labelGoalProteins.AutoSize = true;
            this.labelGoalProteins.Location = new System.Drawing.Point(302, 544);
            this.labelGoalProteins.Name = "labelGoalProteins";
            this.labelGoalProteins.Size = new System.Drawing.Size(16, 17);
            this.labelGoalProteins.TabIndex = 35;
            this.labelGoalProteins.Text = "0";
            this.labelGoalProteins.Visible = false;
            // 
            // labelGoalCarbs
            // 
            this.labelGoalCarbs.AutoSize = true;
            this.labelGoalCarbs.Location = new System.Drawing.Point(302, 567);
            this.labelGoalCarbs.Name = "labelGoalCarbs";
            this.labelGoalCarbs.Size = new System.Drawing.Size(16, 17);
            this.labelGoalCarbs.TabIndex = 36;
            this.labelGoalCarbs.Text = "0";
            this.labelGoalCarbs.Visible = false;
            // 
            // labelGoalLipids
            // 
            this.labelGoalLipids.AutoSize = true;
            this.labelGoalLipids.Location = new System.Drawing.Point(302, 590);
            this.labelGoalLipids.Name = "labelGoalLipids";
            this.labelGoalLipids.Size = new System.Drawing.Size(16, 17);
            this.labelGoalLipids.TabIndex = 37;
            this.labelGoalLipids.Text = "0";
            this.labelGoalLipids.Visible = false;
            // 
            // labelGoalFibers
            // 
            this.labelGoalFibers.AutoSize = true;
            this.labelGoalFibers.Location = new System.Drawing.Point(302, 613);
            this.labelGoalFibers.Name = "labelGoalFibers";
            this.labelGoalFibers.Size = new System.Drawing.Size(16, 17);
            this.labelGoalFibers.TabIndex = 38;
            this.labelGoalFibers.Text = "0";
            this.labelGoalFibers.Visible = false;
            // 
            // labelWarningCalories
            // 
            this.labelWarningCalories.AutoSize = true;
            this.labelWarningCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWarningCalories.ForeColor = System.Drawing.Color.Red;
            this.labelWarningCalories.Location = new System.Drawing.Point(363, 521);
            this.labelWarningCalories.Name = "labelWarningCalories";
            this.labelWarningCalories.Size = new System.Drawing.Size(197, 17);
            this.labelWarningCalories.TabIndex = 39;
            this.labelWarningCalories.Text = "Warning! Value exceeded.";
            this.labelWarningCalories.Visible = false;
            // 
            // labelWarningProteins
            // 
            this.labelWarningProteins.AutoSize = true;
            this.labelWarningProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWarningProteins.ForeColor = System.Drawing.Color.Red;
            this.labelWarningProteins.Location = new System.Drawing.Point(363, 544);
            this.labelWarningProteins.Name = "labelWarningProteins";
            this.labelWarningProteins.Size = new System.Drawing.Size(197, 17);
            this.labelWarningProteins.TabIndex = 40;
            this.labelWarningProteins.Text = "Warning! Value exceeded.";
            this.labelWarningProteins.Visible = false;
            // 
            // labelWarningCarbs
            // 
            this.labelWarningCarbs.AutoSize = true;
            this.labelWarningCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWarningCarbs.ForeColor = System.Drawing.Color.Red;
            this.labelWarningCarbs.Location = new System.Drawing.Point(363, 567);
            this.labelWarningCarbs.Name = "labelWarningCarbs";
            this.labelWarningCarbs.Size = new System.Drawing.Size(197, 17);
            this.labelWarningCarbs.TabIndex = 41;
            this.labelWarningCarbs.Text = "Warning! Value exceeded.";
            this.labelWarningCarbs.Visible = false;
            // 
            // labelWarningLipids
            // 
            this.labelWarningLipids.AutoSize = true;
            this.labelWarningLipids.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWarningLipids.ForeColor = System.Drawing.Color.Red;
            this.labelWarningLipids.Location = new System.Drawing.Point(363, 590);
            this.labelWarningLipids.Name = "labelWarningLipids";
            this.labelWarningLipids.Size = new System.Drawing.Size(197, 17);
            this.labelWarningLipids.TabIndex = 42;
            this.labelWarningLipids.Text = "Warning! Value exceeded.";
            this.labelWarningLipids.Visible = false;
            // 
            // labelWarningFibers
            // 
            this.labelWarningFibers.AutoSize = true;
            this.labelWarningFibers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWarningFibers.ForeColor = System.Drawing.Color.Red;
            this.labelWarningFibers.Location = new System.Drawing.Point(363, 613);
            this.labelWarningFibers.Name = "labelWarningFibers";
            this.labelWarningFibers.Size = new System.Drawing.Size(197, 17);
            this.labelWarningFibers.TabIndex = 43;
            this.labelWarningFibers.Text = "Warning! Value exceeded.";
            this.labelWarningFibers.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(581, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // labelSelectedCalories
            // 
            this.labelSelectedCalories.Location = new System.Drawing.Point(549, 338);
            this.labelSelectedCalories.Name = "labelSelectedCalories";
            this.labelSelectedCalories.Size = new System.Drawing.Size(164, 17);
            this.labelSelectedCalories.TabIndex = 45;
            this.labelSelectedCalories.Text = "label16";
            this.labelSelectedCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSelectedCalories.Visible = false;
            // 
            // labelSelectedProteins
            // 
            this.labelSelectedProteins.Location = new System.Drawing.Point(549, 355);
            this.labelSelectedProteins.Name = "labelSelectedProteins";
            this.labelSelectedProteins.Size = new System.Drawing.Size(164, 17);
            this.labelSelectedProteins.TabIndex = 46;
            this.labelSelectedProteins.Text = "label16";
            this.labelSelectedProteins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSelectedProteins.Visible = false;
            // 
            // labelSelectedCarbs
            // 
            this.labelSelectedCarbs.Location = new System.Drawing.Point(549, 372);
            this.labelSelectedCarbs.Name = "labelSelectedCarbs";
            this.labelSelectedCarbs.Size = new System.Drawing.Size(164, 17);
            this.labelSelectedCarbs.TabIndex = 47;
            this.labelSelectedCarbs.Text = "label16";
            this.labelSelectedCarbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSelectedCarbs.Visible = false;
            // 
            // labelSelectedLipids
            // 
            this.labelSelectedLipids.Location = new System.Drawing.Point(549, 389);
            this.labelSelectedLipids.Name = "labelSelectedLipids";
            this.labelSelectedLipids.Size = new System.Drawing.Size(164, 17);
            this.labelSelectedLipids.TabIndex = 48;
            this.labelSelectedLipids.Text = "label16";
            this.labelSelectedLipids.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSelectedLipids.Visible = false;
            // 
            // labelSelectedFibers
            // 
            this.labelSelectedFibers.Location = new System.Drawing.Point(549, 406);
            this.labelSelectedFibers.Name = "labelSelectedFibers";
            this.labelSelectedFibers.Size = new System.Drawing.Size(164, 17);
            this.labelSelectedFibers.TabIndex = 49;
            this.labelSelectedFibers.Text = "label16";
            this.labelSelectedFibers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSelectedFibers.Visible = false;
            // 
            // labelSelectedFood
            // 
            this.labelSelectedFood.Location = new System.Drawing.Point(546, 315);
            this.labelSelectedFood.Name = "labelSelectedFood";
            this.labelSelectedFood.Size = new System.Drawing.Size(167, 17);
            this.labelSelectedFood.TabIndex = 50;
            this.labelSelectedFood.Text = "label16";
            this.labelSelectedFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSelectedFood.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(863, 613);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 43);
            this.button4.TabIndex = 51;
            this.button4.Text = "Change user data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1137, 613);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 43);
            this.button5.TabIndex = 52;
            this.button5.Text = "Sugest food";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1800000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(589, 613);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 43);
            this.button6.TabIndex = 53;
            this.button6.Text = "Sugest sport";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 7200000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(589, 564);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 43);
            this.button7.TabIndex = 54;
            this.button7.Text = "Gym finder";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(590, 515);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(131, 43);
            this.button8.TabIndex = 55;
            this.button8.Text = "Generate stats";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1366, 620);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 29);
            this.button9.TabIndex = 56;
            this.button9.Text = "About";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 689);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelSelectedFood);
            this.Controls.Add(this.labelSelectedFibers);
            this.Controls.Add(this.labelSelectedLipids);
            this.Controls.Add(this.labelSelectedCarbs);
            this.Controls.Add(this.labelSelectedProteins);
            this.Controls.Add(this.labelSelectedCalories);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelWarningFibers);
            this.Controls.Add(this.labelWarningLipids);
            this.Controls.Add(this.labelWarningCarbs);
            this.Controls.Add(this.labelWarningProteins);
            this.Controls.Add(this.labelWarningCalories);
            this.Controls.Add(this.labelGoalFibers);
            this.Controls.Add(this.labelGoalLipids);
            this.Controls.Add(this.labelGoalCarbs);
            this.Controls.Add(this.labelGoalProteins);
            this.Controls.Add(this.labelGoalCalories);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressFibers);
            this.Controls.Add(this.progressLipids);
            this.Controls.Add(this.progressCarbs);
            this.Controls.Add(this.progressProteins);
            this.Controls.Add(this.progressCalories);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelFibers);
            this.Controls.Add(this.labelLipids);
            this.Controls.Add(this.labelCarbs);
            this.Controls.Add(this.labelProteins);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listEaten);
            this.Controls.Add(this.listCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listAllFoods);
            this.Name = "Form1";
            this.Text = "eCALculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listAllFoods;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.ListView listEaten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader ColumnQuantity;
        private System.Windows.Forms.ColumnHeader ColumnCalories;
        private System.Windows.Forms.ColumnHeader ColumnProteins;
        private System.Windows.Forms.ColumnHeader ColumnCarbs;
        private System.Windows.Forms.ColumnHeader ColumnLipids;
        private System.Windows.Forms.ColumnHeader ColumnFibers;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelProteins;
        private System.Windows.Forms.Label labelCarbs;
        private System.Windows.Forms.Label labelLipids;
        private System.Windows.Forms.Label labelFibers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressCalories;
        private System.Windows.Forms.ProgressBar progressProteins;
        private System.Windows.Forms.ProgressBar progressCarbs;
        private System.Windows.Forms.ProgressBar progressLipids;
        private System.Windows.Forms.ProgressBar progressFibers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelGoalCalories;
        private System.Windows.Forms.Label labelGoalProteins;
        private System.Windows.Forms.Label labelGoalCarbs;
        private System.Windows.Forms.Label labelGoalLipids;
        private System.Windows.Forms.Label labelGoalFibers;
        private System.Windows.Forms.Label labelWarningCalories;
        private System.Windows.Forms.Label labelWarningProteins;
        private System.Windows.Forms.Label labelWarningCarbs;
        private System.Windows.Forms.Label labelWarningLipids;
        private System.Windows.Forms.Label labelWarningFibers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSelectedCalories;
        private System.Windows.Forms.Label labelSelectedProteins;
        private System.Windows.Forms.Label labelSelectedCarbs;
        private System.Windows.Forms.Label labelSelectedLipids;
        private System.Windows.Forms.Label labelSelectedFibers;
        private System.Windows.Forms.Label labelSelectedFood;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

