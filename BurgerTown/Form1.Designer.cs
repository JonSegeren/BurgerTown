namespace BurgerTown
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
            this.tacoInput = new System.Windows.Forms.TextBox();
            this.burritoInput = new System.Windows.Forms.TextBox();
            this.fryInput = new System.Windows.Forms.TextBox();
            this.changeInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tacoInput
            // 
            this.tacoInput.Location = new System.Drawing.Point(137, 40);
            this.tacoInput.Name = "tacoInput";
            this.tacoInput.Size = new System.Drawing.Size(72, 20);
            this.tacoInput.TabIndex = 0;
            // 
            // burritoInput
            // 
            this.burritoInput.Location = new System.Drawing.Point(137, 93);
            this.burritoInput.Name = "burritoInput";
            this.burritoInput.Size = new System.Drawing.Size(72, 20);
            this.burritoInput.TabIndex = 1;
            this.burritoInput.Text = "v";
            // 
            // fryInput
            // 
            this.fryInput.Location = new System.Drawing.Point(137, 140);
            this.fryInput.Name = "fryInput";
            this.fryInput.Size = new System.Drawing.Size(72, 20);
            this.fryInput.TabIndex = 2;
            // 
            // changeInput
            // 
            this.changeInput.Location = new System.Drawing.Point(137, 326);
            this.changeInput.Name = "changeInput";
            this.changeInput.Size = new System.Drawing.Size(72, 20);
            this.changeInput.TabIndex = 3;
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(137, 199);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(72, 20);
            this.drinkInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.changeInput);
            this.Controls.Add(this.fryInput);
            this.Controls.Add(this.burritoInput);
            this.Controls.Add(this.tacoInput);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label1;
    }
}

