﻿namespace sms.Dashbord
{
    partial class add_item
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.countTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Tahoma", 16F);
            this.nameTB.Location = new System.Drawing.Point(98, 13);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(338, 40);
            this.nameTB.TabIndex = 0;
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Tahoma", 16F);
            this.priceTB.Location = new System.Drawing.Point(98, 58);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(338, 40);
            this.priceTB.TabIndex = 1;
            // 
            // countTB
            // 
            this.countTB.Font = new System.Drawing.Font("Tahoma", 16F);
            this.countTB.Location = new System.Drawing.Point(98, 104);
            this.countTB.Name = "countTB";
            this.countTB.Size = new System.Drawing.Size(338, 40);
            this.countTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bold Italic Art", 12F);
            this.label1.Location = new System.Drawing.Point(-3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bold Italic Art", 12F);
            this.label2.Location = new System.Drawing.Point(-3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bold Italic Art", 12F);
            this.label3.Location = new System.Drawing.Point(-3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(185, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countTB);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.nameTB);
            this.Name = "add_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_item";
            this.Load += new System.EventHandler(this.add_item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox countTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}