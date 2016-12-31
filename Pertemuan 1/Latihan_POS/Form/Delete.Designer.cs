namespace Latihan_POS
{
    partial class Delete
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
            this.tabPageDelete = new System.Windows.Forms.TabControl();
            this.tabPageBarang = new System.Windows.Forms.TabPage();
            this.btnBatalBarang = new System.Windows.Forms.Button();
            this.btnDeleteBarang = new System.Windows.Forms.Button();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.btnBatalCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.btnBatalSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageDelete.SuspendLayout();
            this.tabPageBarang.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.tabPageSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.tabPageBarang);
            this.tabPageDelete.Controls.Add(this.tabPageCustomer);
            this.tabPageDelete.Controls.Add(this.tabPageSupplier);
            this.tabPageDelete.Font = new System.Drawing.Font("News701 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDelete.Location = new System.Drawing.Point(9, 16);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.SelectedIndex = 0;
            this.tabPageDelete.Size = new System.Drawing.Size(400, 111);
            this.tabPageDelete.TabIndex = 1;
            // 
            // tabPageBarang
            // 
            this.tabPageBarang.Controls.Add(this.btnBatalBarang);
            this.tabPageBarang.Controls.Add(this.btnDeleteBarang);
            this.tabPageBarang.Controls.Add(this.txtIdBarang);
            this.tabPageBarang.Controls.Add(this.label1);
            this.tabPageBarang.Location = new System.Drawing.Point(4, 23);
            this.tabPageBarang.Name = "tabPageBarang";
            this.tabPageBarang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBarang.Size = new System.Drawing.Size(392, 84);
            this.tabPageBarang.TabIndex = 0;
            this.tabPageBarang.Text = "Barang";
            this.tabPageBarang.UseVisualStyleBackColor = true;
            // 
            // btnBatalBarang
            // 
            this.btnBatalBarang.Location = new System.Drawing.Point(268, 43);
            this.btnBatalBarang.Name = "btnBatalBarang";
            this.btnBatalBarang.Size = new System.Drawing.Size(75, 28);
            this.btnBatalBarang.TabIndex = 2;
            this.btnBatalBarang.Text = "Batal";
            this.btnBatalBarang.UseVisualStyleBackColor = true;
            this.btnBatalBarang.Click += new System.EventHandler(this.btnBatalBarang_Click);
            // 
            // btnDeleteBarang
            // 
            this.btnDeleteBarang.Location = new System.Drawing.Point(187, 43);
            this.btnDeleteBarang.Name = "btnDeleteBarang";
            this.btnDeleteBarang.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteBarang.TabIndex = 1;
            this.btnDeleteBarang.Text = "Delete";
            this.btnDeleteBarang.UseVisualStyleBackColor = true;
            this.btnDeleteBarang.Click += new System.EventHandler(this.btnDeleteBarang_Click);
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Location = new System.Drawing.Point(132, 17);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(212, 21);
            this.txtIdBarang.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.btnBatalCustomer);
            this.tabPageCustomer.Controls.Add(this.btnDeleteCustomer);
            this.tabPageCustomer.Controls.Add(this.txtIdCustomer);
            this.tabPageCustomer.Controls.Add(this.label3);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 23);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(392, 84);
            this.tabPageCustomer.TabIndex = 1;
            this.tabPageCustomer.Text = "Customer";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // btnBatalCustomer
            // 
            this.btnBatalCustomer.Location = new System.Drawing.Point(260, 44);
            this.btnBatalCustomer.Name = "btnBatalCustomer";
            this.btnBatalCustomer.Size = new System.Drawing.Size(75, 28);
            this.btnBatalCustomer.TabIndex = 9;
            this.btnBatalCustomer.Text = "Batal";
            this.btnBatalCustomer.UseVisualStyleBackColor = true;
            this.btnBatalCustomer.Click += new System.EventHandler(this.btnBatalCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(179, 44);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteCustomer.TabIndex = 8;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(124, 18);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(212, 21);
            this.txtIdCustomer.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.Controls.Add(this.btnBatalSupplier);
            this.tabPageSupplier.Controls.Add(this.btnDeleteSupplier);
            this.tabPageSupplier.Controls.Add(this.txtIdSupplier);
            this.tabPageSupplier.Controls.Add(this.label2);
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 23);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupplier.Size = new System.Drawing.Size(392, 84);
            this.tabPageSupplier.TabIndex = 2;
            this.tabPageSupplier.Text = "Supplier";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // btnBatalSupplier
            // 
            this.btnBatalSupplier.Location = new System.Drawing.Point(271, 44);
            this.btnBatalSupplier.Name = "btnBatalSupplier";
            this.btnBatalSupplier.Size = new System.Drawing.Size(75, 28);
            this.btnBatalSupplier.TabIndex = 9;
            this.btnBatalSupplier.Text = "Batal";
            this.btnBatalSupplier.UseVisualStyleBackColor = true;
            this.btnBatalSupplier.Click += new System.EventHandler(this.btnBatalSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(190, 44);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteSupplier.TabIndex = 8;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Location = new System.Drawing.Point(135, 18);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(212, 21);
            this.txtIdSupplier.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(420, 140);
            this.Controls.Add(this.tabPageDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageBarang.ResumeLayout(false);
            this.tabPageBarang.PerformLayout();
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageCustomer.PerformLayout();
            this.tabPageSupplier.ResumeLayout(false);
            this.tabPageSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPageDelete;
        private System.Windows.Forms.TabPage tabPageBarang;
        private System.Windows.Forms.Button btnBatalBarang;
        private System.Windows.Forms.Button btnDeleteBarang;
        private System.Windows.Forms.TextBox txtIdBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.Button btnBatalCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.Button btnBatalSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private System.Windows.Forms.Label label2;
    }
}