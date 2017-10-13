namespace BurgerTown
{
    partial class form1
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
            this.tacoInput = new System.Windows.Forms.TextBox();
            this.burritoInput = new System.Windows.Forms.TextBox();
            this.fryInput = new System.Windows.Forms.TextBox();
            this.changeInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.tacoLabel = new System.Windows.Forms.Label();
            this.burritoLabel = new System.Windows.Forms.Label();
            this.fryLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.changeStag = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.changeDue = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taxStat = new System.Windows.Forms.Label();
            this.taxTotalLabel = new System.Windows.Forms.Label();
            this.grandTotalOutput = new System.Windows.Forms.Label();
            this.subTotalStat = new System.Windows.Forms.Label();
            this.subTotalOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tacoInput
            // 
            this.tacoInput.Location = new System.Drawing.Point(137, 40);
            this.tacoInput.Name = "tacoInput";
            this.tacoInput.Size = new System.Drawing.Size(72, 20);
            this.tacoInput.TabIndex = 1;
            // 
            // burritoInput
            // 
            this.burritoInput.Location = new System.Drawing.Point(137, 90);
            this.burritoInput.Name = "burritoInput";
            this.burritoInput.Size = new System.Drawing.Size(72, 20);
            this.burritoInput.TabIndex = 2;
            // 
            // fryInput
            // 
            this.fryInput.Location = new System.Drawing.Point(137, 137);
            this.fryInput.Name = "fryInput";
            this.fryInput.Size = new System.Drawing.Size(72, 20);
            this.fryInput.TabIndex = 3;
            // 
            // changeInput
            // 
            this.changeInput.Location = new System.Drawing.Point(137, 344);
            this.changeInput.Name = "changeInput";
            this.changeInput.Size = new System.Drawing.Size(72, 20);
            this.changeInput.TabIndex = 6;
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(137, 183);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(72, 20);
            this.drinkInput.TabIndex = 4;
            // 
            // tacoLabel
            // 
            this.tacoLabel.AutoSize = true;
            this.tacoLabel.Location = new System.Drawing.Point(31, 40);
            this.tacoLabel.Name = "tacoLabel";
            this.tacoLabel.Size = new System.Drawing.Size(40, 13);
            this.tacoLabel.TabIndex = 5;
            this.tacoLabel.Text = "Tacos:";
            // 
            // burritoLabel
            // 
            this.burritoLabel.AutoSize = true;
            this.burritoLabel.Location = new System.Drawing.Point(31, 93);
            this.burritoLabel.Name = "burritoLabel";
            this.burritoLabel.Size = new System.Drawing.Size(45, 13);
            this.burritoLabel.TabIndex = 6;
            this.burritoLabel.Text = "Burritos:";
            // 
            // fryLabel
            // 
            this.fryLabel.AutoSize = true;
            this.fryLabel.Location = new System.Drawing.Point(31, 140);
            this.fryLabel.Name = "fryLabel";
            this.fryLabel.Size = new System.Drawing.Size(32, 13);
            this.fryLabel.TabIndex = 7;
            this.fryLabel.Text = "Fries:";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Location = new System.Drawing.Point(31, 186);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(40, 13);
            this.drinkLabel.TabIndex = 8;
            this.drinkLabel.Text = "Drinks:";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Location = new System.Drawing.Point(30, 347);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(83, 13);
            this.cashLabel.TabIndex = 9;
            this.cashLabel.Text = "Cash Tendered:";
            // 
            // changeStag
            // 
            this.changeStag.AutoSize = true;
            this.changeStag.Location = new System.Drawing.Point(35, 381);
            this.changeStag.Name = "changeStag";
            this.changeStag.Size = new System.Drawing.Size(70, 13);
            this.changeStag.TabIndex = 11;
            this.changeStag.Text = "Chagne Due:";
            // 
            // changeOutput
            // 
            this.changeOutput.Location = new System.Drawing.Point(134, 375);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(75, 24);
            this.changeOutput.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate Totals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeDue
            // 
            this.changeDue.Location = new System.Drawing.Point(38, 402);
            this.changeDue.Name = "changeDue";
            this.changeDue.Size = new System.Drawing.Size(75, 23);
            this.changeDue.TabIndex = 7;
            this.changeDue.Text = "Change";
            this.changeDue.UseVisualStyleBackColor = true;
            this.changeDue.Click += new System.EventHandler(this.changeDue_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Recipt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(275, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "New Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Grand Total:";
            // 
            // taxStat
            // 
            this.taxStat.AutoSize = true;
            this.taxStat.Location = new System.Drawing.Point(49, 289);
            this.taxStat.Name = "taxStat";
            this.taxStat.Size = new System.Drawing.Size(28, 13);
            this.taxStat.TabIndex = 18;
            this.taxStat.Text = "Tax:";
            // 
            // taxTotalLabel
            // 
            this.taxTotalLabel.Location = new System.Drawing.Point(134, 289);
            this.taxTotalLabel.Name = "taxTotalLabel";
            this.taxTotalLabel.Size = new System.Drawing.Size(78, 23);
            this.taxTotalLabel.TabIndex = 19;
            this.taxTotalLabel.Text = " ";
            // 
            // grandTotalOutput
            // 
            this.grandTotalOutput.Location = new System.Drawing.Point(134, 319);
            this.grandTotalOutput.Name = "grandTotalOutput";
            this.grandTotalOutput.Size = new System.Drawing.Size(73, 25);
            this.grandTotalOutput.TabIndex = 20;
            this.grandTotalOutput.Text = " ";
            // 
            // subTotalStat
            // 
            this.subTotalStat.AutoSize = true;
            this.subTotalStat.Location = new System.Drawing.Point(39, 261);
            this.subTotalStat.Name = "subTotalStat";
            this.subTotalStat.Size = new System.Drawing.Size(49, 13);
            this.subTotalStat.TabIndex = 21;
            this.subTotalStat.Text = "Subtotal:";
            // 
            // subTotalOut
            // 
            this.subTotalOut.Location = new System.Drawing.Point(134, 251);
            this.subTotalOut.Name = "subTotalOut";
            this.subTotalOut.Size = new System.Drawing.Size(59, 28);
            this.subTotalOut.TabIndex = 22;
            this.subTotalOut.Text = " ";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 437);
            this.Controls.Add(this.subTotalOut);
            this.Controls.Add(this.subTotalStat);
            this.Controls.Add(this.grandTotalOutput);
            this.Controls.Add(this.taxTotalLabel);
            this.Controls.Add(this.taxStat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.changeDue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeStag);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.fryLabel);
            this.Controls.Add(this.burritoLabel);
            this.Controls.Add(this.tacoLabel);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.changeInput);
            this.Controls.Add(this.fryInput);
            this.Controls.Add(this.burritoInput);
            this.Controls.Add(this.tacoInput);
            this.Name = "form1";
            this.Text = "Taco Town";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tacoInput;
        private System.Windows.Forms.TextBox burritoInput;
        private System.Windows.Forms.TextBox fryInput;
        private System.Windows.Forms.TextBox changeInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Label tacoLabel;
        private System.Windows.Forms.Label burritoLabel;
        private System.Windows.Forms.Label fryLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label changeStag;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button changeDue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label taxStat;
        private System.Windows.Forms.Label taxTotalLabel;
        private System.Windows.Forms.Label grandTotalOutput;
        private System.Windows.Forms.Label subTotalStat;
        private System.Windows.Forms.Label subTotalOut;
    }
}

