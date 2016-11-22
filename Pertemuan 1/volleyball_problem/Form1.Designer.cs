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
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.btnhitung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(9, 67);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(223, 20);
            this.txtb.TabIndex = 2;
            this.txtb.Text = " ";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(9, 25);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(223, 20);
            this.txta.TabIndex = 1;
            // 
            // txthasil
            // 
            this.txthasil.Location = new System.Drawing.Point(9, 153);
            this.txthasil.Name = "txthasil";
            this.txthasil.ReadOnly = true;
            this.txthasil.Size = new System.Drawing.Size(223, 20);
            this.txthasil.TabIndex = 4;
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(9, 103);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(223, 23);
            this.btnhitung.TabIndex = 3;
            this.btnhitung.Text = "Hitung";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
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
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

