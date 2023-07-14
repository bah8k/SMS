namespace sms.Dashbord
{
    partial class add_content
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
            this.button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button.Location = new System.Drawing.Point(135, 54);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 49);
            this.button.TabIndex = 1;
            this.button.Text = "Add";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textBox1.Location = new System.Drawing.Point(89, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 36);
            this.textBox1.TabIndex = 2;
            // 
            // labelk
            // 
            this.labelk.AutoSize = true;
            this.labelk.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelk.Location = new System.Drawing.Point(-3, 12);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(86, 36);
            this.labelk.TabIndex = 3;
            this.labelk.Text = "Num";
            // 
            // add_content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 109);
            this.Controls.Add(this.labelk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button);
            this.Name = "add_content";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_content";
            this.Load += new System.EventHandler(this.add_content_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelk;
    }
}