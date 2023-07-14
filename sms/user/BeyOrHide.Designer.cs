namespace sms.user
{
    partial class BeyOrHide
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
            this.no = new System.Windows.Forms.Button();
            this.yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "هل تريد شراء المنتج ؟ ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.Red;
            this.no.Location = new System.Drawing.Point(238, 60);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(75, 35);
            this.no.TabIndex = 1;
            this.no.Text = "no";
            this.no.UseVisualStyleBackColor = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yes.Location = new System.Drawing.Point(157, 60);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(75, 35);
            this.yes.TabIndex = 2;
            this.yes.Text = "yes";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // BeyOrHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 107);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label1);
            this.Name = "BeyOrHide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeyOrHide";
            this.Load += new System.EventHandler(this.BeyOrHide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Button yes;
    }
}