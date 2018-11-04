namespace _2002807_Maeda_MailOrder3
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
            this.exit = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.hoursWorkedInput = new System.Windows.Forms.TextBox();
            this.totalSalesInput = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.labelStoreSales = new System.Windows.Forms.Label();
            this.boxGain = new System.Windows.Forms.GroupBox();
            this.bonusT = new System.Windows.Forms.TextBox();
            this.labelEmployeeBonus = new System.Windows.Forms.Label();
            this.boxGain.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // calculate
            // 
            this.calculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculate.Location = new System.Drawing.Point(41, 193);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.Location = new System.Drawing.Point(122, 193);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(131, 14);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 3;
            // 
            // hoursWorkedInput
            // 
            this.hoursWorkedInput.Location = new System.Drawing.Point(131, 56);
            this.hoursWorkedInput.Name = "hoursWorkedInput";
            this.hoursWorkedInput.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedInput.TabIndex = 4;
            // 
            // totalSalesInput
            // 
            this.totalSalesInput.Location = new System.Drawing.Point(131, 102);
            this.totalSalesInput.Name = "totalSalesInput";
            this.totalSalesInput.Size = new System.Drawing.Size(100, 20);
            this.totalSalesInput.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Employee Name";
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Location = new System.Drawing.Point(13, 59);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(103, 13);
            this.labelHoursWorked.TabIndex = 7;
            this.labelHoursWorked.Text = "Total Hours Worked";
            // 
            // labelStoreSales
            // 
            this.labelStoreSales.AutoSize = true;
            this.labelStoreSales.Location = new System.Drawing.Point(13, 105);
            this.labelStoreSales.Name = "labelStoreSales";
            this.labelStoreSales.Size = new System.Drawing.Size(88, 13);
            this.labelStoreSales.TabIndex = 8;
            this.labelStoreSales.Text = "Total Store Sales";
            // 
            // boxGain
            // 
            this.boxGain.Controls.Add(this.labelEmployeeBonus);
            this.boxGain.Controls.Add(this.bonusT);
            this.boxGain.Location = new System.Drawing.Point(16, 142);
            this.boxGain.Name = "boxGain";
            this.boxGain.Size = new System.Drawing.Size(215, 45);
            this.boxGain.TabIndex = 9;
            this.boxGain.TabStop = false;
            this.boxGain.Text = "Bonus";
            // 
            // bonusT
            // 
            this.bonusT.Location = new System.Drawing.Point(109, 17);
            this.bonusT.Name = "bonusT";
            this.bonusT.Size = new System.Drawing.Size(100, 20);
            this.bonusT.TabIndex = 0;
            // 
            // labelEmployeeBonus
            // 
            this.labelEmployeeBonus.AutoSize = true;
            this.labelEmployeeBonus.Location = new System.Drawing.Point(7, 20);
            this.labelEmployeeBonus.Name = "labelEmployeeBonus";
            this.labelEmployeeBonus.Size = new System.Drawing.Size(86, 13);
            this.labelEmployeeBonus.TabIndex = 1;
            this.labelEmployeeBonus.Text = "Employee Bonus";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxGain);
            this.Controls.Add(this.labelStoreSales);
            this.Controls.Add(this.labelHoursWorked);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.totalSalesInput);
            this.Controls.Add(this.hoursWorkedInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "CS Mail Order Unit 3";
            this.boxGain.ResumeLayout(false);
            this.boxGain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox hoursWorkedInput;
        private System.Windows.Forms.TextBox totalSalesInput;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.Label labelStoreSales;
        private System.Windows.Forms.GroupBox boxGain;
        private System.Windows.Forms.Label labelEmployeeBonus;
        private System.Windows.Forms.TextBox bonusT;
    }
}

