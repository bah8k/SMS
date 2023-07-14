namespace sms
{
    partial class create
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
            this.singUpLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.passTB = new System.Windows.Forms.TextBox();
            this.userTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // singUpLabel
            // 
            this.singUpLabel.AutoSize = true;
            this.singUpLabel.Location = new System.Drawing.Point(117, 188);
            this.singUpLabel.Name = "singUpLabel";
            this.singUpLabel.Size = new System.Drawing.Size(48, 17);
            this.singUpLabel.TabIndex = 13;
            this.singUpLabel.TabStop = true;
            this.singUpLabel.Text = "Sing in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "User";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Black;
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loginbtn.Location = new System.Drawing.Point(105, 148);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 37);
            this.Loginbtn.TabIndex = 10;
            this.Loginbtn.Text = "SingUp";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(52, 118);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(220, 24);
            this.passTB.TabIndex = 9;
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(52, 92);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(220, 24);
            this.userTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sing Up";
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.singUpLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.label1);
            this.Name = "create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel singUpLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Label label1;
    }
}