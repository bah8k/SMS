namespace sms
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
            this.label1 = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.singUpLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userTB
            // 
            this.userTB.Font = new System.Drawing.Font("Tahoma", 14F);
            this.userTB.Location = new System.Drawing.Point(53, 54);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(220, 36);
            this.userTB.TabIndex = 1;
            this.userTB.TextChanged += new System.EventHandler(this.userTB_TextChanged);
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.passTB.Location = new System.Drawing.Point(53, 96);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(220, 32);
            this.passTB.TabIndex = 2;
            this.passTB.TextChanged += new System.EventHandler(this.passTB_TextChanged);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Black;
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loginbtn.Location = new System.Drawing.Point(105, 130);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 37);
            this.Loginbtn.TabIndex = 3;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pass";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // singUpLabel
            // 
            this.singUpLabel.AutoSize = true;
            this.singUpLabel.Location = new System.Drawing.Point(112, 170);
            this.singUpLabel.Name = "singUpLabel";
            this.singUpLabel.Size = new System.Drawing.Size(55, 17);
            this.singUpLabel.TabIndex = 6;
            this.singUpLabel.TabStop = true;
            this.singUpLabel.Text = "Sing Up";
            this.singUpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.singUpLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 197);
            this.Controls.Add(this.singUpLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel singUpLabel;
    }
}

