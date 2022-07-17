namespace Activity4
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
            this.enterBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBut
            // 
            this.enterBut.Location = new System.Drawing.Point(148, 414);
            this.enterBut.Name = "enterBut";
            this.enterBut.Size = new System.Drawing.Size(250, 103);
            this.enterBut.TabIndex = 1;
            this.enterBut.Text = "Enter";
            this.enterBut.UseVisualStyleBackColor = true;
            this.enterBut.Click += new System.EventHandler(this.enterBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBut.Location = new System.Drawing.Point(453, 414);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(258, 103);
            this.exitBut.TabIndex = 2;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = true;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minutes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Days";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seconds";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17975, 6343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1177, 31);
            this.textBox1.TabIndex = 6;
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(355, 104);
            this.userInput.Multiline = true;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(373, 45);
            this.userInput.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Seconds:";
            // 
            // daysLabel
            // 
            this.daysLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.daysLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daysLabel.Location = new System.Drawing.Point(355, 161);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(373, 43);
            this.daysLabel.TabIndex = 9;
            // 
            // hoursLabel
            // 
            this.hoursLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hoursLabel.Location = new System.Drawing.Point(355, 214);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(373, 43);
            this.hoursLabel.TabIndex = 10;
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.minLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minLabel.Location = new System.Drawing.Point(355, 268);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(373, 43);
            this.minLabel.TabIndex = 11;
            // 
            // secLabel
            // 
            this.secLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.secLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secLabel.Location = new System.Drawing.Point(355, 317);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(373, 43);
            this.secLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.enterBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBut;
            this.ClientSize = new System.Drawing.Size(864, 620);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.enterBut);
            this.Name = "Form1";
            this.Text = "Seconds Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterBut;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
    }
}

