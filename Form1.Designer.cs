namespace Code_Practice_Checkboxes_Radio_Buttons
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
            this.tbSandwich = new System.Windows.Forms.TextBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.gbBread = new System.Windows.Forms.GroupBox();
            this.gbHeat = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbSourdough = new System.Windows.Forms.RadioButton();
            this.rbWheat = new System.Windows.Forms.RadioButton();
            this.rbFoccaccia = new System.Windows.Forms.RadioButton();
            this.rbHot = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbMild = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkPepperoncini = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkBeef = new System.Windows.Forms.CheckBox();
            this.chkHouseSauce = new System.Windows.Forms.CheckBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnMakeSandwich = new System.Windows.Forms.Button();
            this.gbToppings.SuspendLayout();
            this.gbBread.SuspendLayout();
            this.gbHeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSandwich
            // 
            this.tbSandwich.Location = new System.Drawing.Point(12, 29);
            this.tbSandwich.Name = "tbSandwich";
            this.tbSandwich.Size = new System.Drawing.Size(135, 22);
            this.tbSandwich.TabIndex = 0;
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkBeef);
            this.gbToppings.Controls.Add(this.chkHouseSauce);
            this.gbToppings.Controls.Add(this.chkMayo);
            this.gbToppings.Controls.Add(this.chkPeppers);
            this.gbToppings.Controls.Add(this.chkPepperoncini);
            this.gbToppings.Controls.Add(this.chkBacon);
            this.gbToppings.Controls.Add(this.chkChicken);
            this.gbToppings.Controls.Add(this.chkCheese);
            this.gbToppings.Location = new System.Drawing.Point(12, 90);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(205, 326);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // gbBread
            // 
            this.gbBread.Controls.Add(this.rbFoccaccia);
            this.gbBread.Controls.Add(this.rbSourdough);
            this.gbBread.Controls.Add(this.rbWheat);
            this.gbBread.Controls.Add(this.rbWhite);
            this.gbBread.Location = new System.Drawing.Point(520, 50);
            this.gbBread.Name = "gbBread";
            this.gbBread.Size = new System.Drawing.Size(205, 178);
            this.gbBread.TabIndex = 2;
            this.gbBread.TabStop = false;
            this.gbBread.Text = "Bread";
            // 
            // gbHeat
            // 
            this.gbHeat.Controls.Add(this.rbHot);
            this.gbHeat.Controls.Add(this.rbMedium);
            this.gbHeat.Controls.Add(this.rbMild);
            this.gbHeat.Controls.Add(this.rbNone);
            this.gbHeat.Location = new System.Drawing.Point(520, 260);
            this.gbHeat.Name = "gbHeat";
            this.gbHeat.Size = new System.Drawing.Size(205, 190);
            this.gbHeat.TabIndex = 3;
            this.gbHeat.TabStop = false;
            this.gbHeat.Text = "Heat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sandwich Name";
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(6, 34);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(103, 20);
            this.rbWhite.TabIndex = 7;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White - $5.00";
            this.rbWhite.UseVisualStyleBackColor = true;
            // 
            // rbSourdough
            // 
            this.rbSourdough.AutoSize = true;
            this.rbSourdough.Location = new System.Drawing.Point(6, 60);
            this.rbSourdough.Name = "rbSourdough";
            this.rbSourdough.Size = new System.Drawing.Size(135, 20);
            this.rbSourdough.TabIndex = 8;
            this.rbSourdough.TabStop = true;
            this.rbSourdough.Text = "Sourdough - $6.00";
            this.rbSourdough.UseVisualStyleBackColor = true;
            // 
            // rbWheat
            // 
            this.rbWheat.AutoSize = true;
            this.rbWheat.Location = new System.Drawing.Point(6, 86);
            this.rbWheat.Name = "rbWheat";
            this.rbWheat.Size = new System.Drawing.Size(108, 20);
            this.rbWheat.TabIndex = 9;
            this.rbWheat.TabStop = true;
            this.rbWheat.Text = "Wheat - $5.50";
            this.rbWheat.UseVisualStyleBackColor = true;
            // 
            // rbFoccaccia
            // 
            this.rbFoccaccia.AutoSize = true;
            this.rbFoccaccia.Location = new System.Drawing.Point(6, 112);
            this.rbFoccaccia.Name = "rbFoccaccia";
            this.rbFoccaccia.Size = new System.Drawing.Size(132, 20);
            this.rbFoccaccia.TabIndex = 10;
            this.rbFoccaccia.TabStop = true;
            this.rbFoccaccia.Text = "Foccaccia - $7.00";
            this.rbFoccaccia.UseVisualStyleBackColor = true;
            // 
            // rbHot
            // 
            this.rbHot.AutoSize = true;
            this.rbHot.Location = new System.Drawing.Point(6, 108);
            this.rbHot.Name = "rbHot";
            this.rbHot.Size = new System.Drawing.Size(49, 20);
            this.rbHot.TabIndex = 14;
            this.rbHot.TabStop = true;
            this.rbHot.Text = "Hot";
            this.rbHot.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(6, 82);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 13;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbMild
            // 
            this.rbMild.AutoSize = true;
            this.rbMild.Location = new System.Drawing.Point(6, 56);
            this.rbMild.Name = "rbMild";
            this.rbMild.Size = new System.Drawing.Size(53, 20);
            this.rbMild.TabIndex = 12;
            this.rbMild.TabStop = true;
            this.rbMild.Text = "Mild";
            this.rbMild.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(6, 30);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(61, 20);
            this.rbNone.TabIndex = 11;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(6, 31);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(117, 20);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Cheese - $1.00";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(6, 57);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(118, 20);
            this.chkChicken.TabIndex = 1;
            this.chkChicken.Text = "Chicken - $3.00";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkPepperoncini
            // 
            this.chkPepperoncini.AutoSize = true;
            this.chkPepperoncini.Location = new System.Drawing.Point(6, 109);
            this.chkPepperoncini.Name = "chkPepperoncini";
            this.chkPepperoncini.Size = new System.Drawing.Size(150, 20);
            this.chkPepperoncini.TabIndex = 3;
            this.chkPepperoncini.Text = "Pepperoncini - $1.50";
            this.chkPepperoncini.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(6, 83);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(109, 20);
            this.chkBacon.TabIndex = 2;
            this.chkBacon.Text = "Bacon - $2.00";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkBeef
            // 
            this.chkBeef.AutoSize = true;
            this.chkBeef.Location = new System.Drawing.Point(6, 212);
            this.chkBeef.Name = "chkBeef";
            this.chkBeef.Size = new System.Drawing.Size(98, 20);
            this.chkBeef.TabIndex = 7;
            this.chkBeef.Text = "Beef - $3.50";
            this.chkBeef.UseVisualStyleBackColor = true;
            // 
            // chkHouseSauce
            // 
            this.chkHouseSauce.AutoSize = true;
            this.chkHouseSauce.Location = new System.Drawing.Point(6, 186);
            this.chkHouseSauce.Name = "chkHouseSauce";
            this.chkHouseSauce.Size = new System.Drawing.Size(152, 20);
            this.chkHouseSauce.TabIndex = 6;
            this.chkHouseSauce.Text = "House Sauce - $1.00";
            this.chkHouseSauce.UseVisualStyleBackColor = true;
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.Location = new System.Drawing.Point(6, 160);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(97, 20);
            this.chkMayo.TabIndex = 5;
            this.chkMayo.Text = "Mayo - $.50";
            this.chkMayo.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(6, 134);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(122, 20);
            this.chkPeppers.TabIndex = 4;
            this.chkPeppers.Text = "Peppers - $1.50";
            this.chkPeppers.UseVisualStyleBackColor = true;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(250, 26);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(245, 336);
            this.rtbDisplay.TabIndex = 15;
            this.rtbDisplay.Text = "";
            // 
            // btnMakeSandwich
            // 
            this.btnMakeSandwich.Location = new System.Drawing.Point(273, 389);
            this.btnMakeSandwich.Name = "btnMakeSandwich";
            this.btnMakeSandwich.Size = new System.Drawing.Size(187, 45);
            this.btnMakeSandwich.TabIndex = 16;
            this.btnMakeSandwich.Text = "Make Sandwich";
            this.btnMakeSandwich.UseVisualStyleBackColor = true;
            this.btnMakeSandwich.Click += new System.EventHandler(this.btnMakeSandwich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 485);
            this.Controls.Add(this.btnMakeSandwich);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbHeat);
            this.Controls.Add(this.gbBread);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.tbSandwich);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbBread.ResumeLayout(false);
            this.gbBread.PerformLayout();
            this.gbHeat.ResumeLayout(false);
            this.gbHeat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSandwich;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbBread;
        private System.Windows.Forms.GroupBox gbHeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbFoccaccia;
        private System.Windows.Forms.RadioButton rbSourdough;
        private System.Windows.Forms.RadioButton rbWheat;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbHot;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbMild;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.CheckBox chkBeef;
        private System.Windows.Forms.CheckBox chkHouseSauce;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkPepperoncini;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnMakeSandwich;
    }
}

