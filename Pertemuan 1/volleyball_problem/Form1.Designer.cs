namespace volleyball_problem
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
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(9, 67);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(223, 20);
            this.Txt2.TabIndex = 2;
            this.Txt2.Text = " ";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(9, 25);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(223, 20);
            this.Txt1.TabIndex = 1;
            // 
            // TxtHasil
            // 
            this.TxtHasil.Location = new System.Drawing.Point(9, 153);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.ReadOnly = true;
            this.TxtHasil.Size = new System.Drawing.Size(223, 20);
            this.TxtHasil.TabIndex = 4;
            // 
            // BtnHitung
            // 
            this.BtnHitung.Location = new System.Drawing.Point(9, 103);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(223, 23);
            this.BtnHitung.TabIndex = 3;
            this.BtnHitung.Text = "Hitung";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasil Akhir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nilai B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHitung);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Txt2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox TxtHasil;
        private System.Windows.Forms.Button BtnHitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

