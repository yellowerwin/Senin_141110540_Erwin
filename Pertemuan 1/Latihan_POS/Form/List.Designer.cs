namespace Latihan_POS
{
    partial class List
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
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.btnBatalSupplier = new System.Windows.Forms.Button();
            this.tabPageDisplay = new System.Windows.Forms.TabControl();
            this.tabPageBarang = new System.Windows.Forms.TabPage();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.btnBatalBarang = new System.Windows.Forms.Button();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.btnBatalCustomer = new System.Windows.Forms.Button();
            this.tabPagePenjualan = new System.Windows.Forms.TabPage();
            this.dataGridViewPenjualan = new System.Windows.Forms.DataGridView();
            this.btnBatalPenjualan = new System.Windows.Forms.Button();
            this.tabPagePembelian = new System.Windows.Forms.TabPage();
            this.dataGridViewPembelian = new System.Windows.Forms.DataGridView();
            this.btnBatalPembelian = new System.Windows.Forms.Button();
            this.tabPageSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.tabPageDisplay.SuspendLayout();
            this.tabPageBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.tabPagePenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenjualan)).BeginInit();
            this.tabPagePembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.Controls.Add(this.dataGridViewSupplier);
            this.tabPageSupplier.Controls.Add(this.btnBatalSupplier);
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 23);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupplier.Size = new System.Drawing.Size(449, 247);
            this.tabPageSupplier.TabIndex = 2;
            this.tabPageSupplier.Text = "Supplier";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.Size = new System.Drawing.Size(437, 197);
            this.dataGridViewSupplier.TabIndex = 16;
            // 
            // btnBatalSupplier
            // 
            this.btnBatalSupplier.Location = new System.Drawing.Point(359, 209);
            this.btnBatalSupplier.Name = "btnBatalSupplier";
            this.btnBatalSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnBatalSupplier.TabIndex = 15;
            this.btnBatalSupplier.Text = "Back";
            this.btnBatalSupplier.UseVisualStyleBackColor = true;
            this.btnBatalSupplier.Click += new System.EventHandler(this.btnBatalSupplier_Click);
            // 
            // tabPageDisplay
            // 
            this.tabPageDisplay.Controls.Add(this.tabPageBarang);
            this.tabPageDisplay.Controls.Add(this.tabPageCustomer);
            this.tabPageDisplay.Controls.Add(this.tabPageSupplier);
            this.tabPageDisplay.Controls.Add(this.tabPagePenjualan);
            this.tabPageDisplay.Controls.Add(this.tabPagePembelian);
            this.tabPageDisplay.Font = new System.Drawing.Font("News701 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDisplay.Location = new System.Drawing.Point(12, 16);
            this.tabPageDisplay.Name = "tabPageDisplay";
            this.tabPageDisplay.SelectedIndex = 0;
            this.tabPageDisplay.Size = new System.Drawing.Size(457, 274);
            this.tabPageDisplay.TabIndex = 2;
            // 
            // tabPageBarang
            // 
            this.tabPageBarang.BackColor = System.Drawing.Color.White;
            this.tabPageBarang.Controls.Add(this.dataGridViewBarang);
            this.tabPageBarang.Controls.Add(this.btnBatalBarang);
            this.tabPageBarang.Location = new System.Drawing.Point(4, 23);
            this.tabPageBarang.Name = "tabPageBarang";
            this.tabPageBarang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBarang.Size = new System.Drawing.Size(449, 247);
            this.tabPageBarang.TabIndex = 0;
            this.tabPageBarang.Text = "Barang";
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.Size = new System.Drawing.Size(435, 195);
            this.dataGridViewBarang.TabIndex = 3;
            // 
            // btnBatalBarang
            // 
            this.btnBatalBarang.Location = new System.Drawing.Point(366, 207);
            this.btnBatalBarang.Name = "btnBatalBarang";
            this.btnBatalBarang.Size = new System.Drawing.Size(75, 23);
            this.btnBatalBarang.TabIndex = 2;
            this.btnBatalBarang.Text = "Back";
            this.btnBatalBarang.UseVisualStyleBackColor = true;
            this.btnBatalBarang.Click += new System.EventHandler(this.btnBatalBarang_Click);
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.dataGridViewCustomer);
            this.tabPageCustomer.Controls.Add(this.btnBatalCustomer);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 23);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(449, 247);
            this.tabPageCustomer.TabIndex = 1;
            this.tabPageCustomer.Text = "Customer";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(437, 197);
            this.dataGridViewCustomer.TabIndex = 16;
            // 
            // btnBatalCustomer
            // 
            this.btnBatalCustomer.Location = new System.Drawing.Point(359, 209);
            this.btnBatalCustomer.Name = "btnBatalCustomer";
            this.btnBatalCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnBatalCustomer.TabIndex = 15;
            this.btnBatalCustomer.Text = "Back";
            this.btnBatalCustomer.UseVisualStyleBackColor = true;
            this.btnBatalCustomer.Click += new System.EventHandler(this.btnBatalCustomer_Click);
            // 
            // tabPagePenjualan
            // 
            this.tabPagePenjualan.Controls.Add(this.dataGridViewPenjualan);
            this.tabPagePenjualan.Controls.Add(this.btnBatalPenjualan);
            this.tabPagePenjualan.Location = new System.Drawing.Point(4, 23);
            this.tabPagePenjualan.Name = "tabPagePenjualan";
            this.tabPagePenjualan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePenjualan.Size = new System.Drawing.Size(449, 247);
            this.tabPagePenjualan.TabIndex = 3;
            this.tabPagePenjualan.Text = "Penjualan";
            this.tabPagePenjualan.UseVisualStyleBackColor = true;
            this.tabPagePenjualan.Click += new System.EventHandler(this.tabPagePenjualan_Click);
            // 
            // dataGridViewPenjualan
            // 
            this.dataGridViewPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPenjualan.Location = new System.Drawing.Point(6, 10);
            this.dataGridViewPenjualan.Name = "dataGridViewPenjualan";
            this.dataGridViewPenjualan.Size = new System.Drawing.Size(437, 197);
            this.dataGridViewPenjualan.TabIndex = 18;
            // 
            // btnBatalPenjualan
            // 
            this.btnBatalPenjualan.Location = new System.Drawing.Point(359, 213);
            this.btnBatalPenjualan.Name = "btnBatalPenjualan";
            this.btnBatalPenjualan.Size = new System.Drawing.Size(75, 23);
            this.btnBatalPenjualan.TabIndex = 17;
            this.btnBatalPenjualan.Text = "Back";
            this.btnBatalPenjualan.UseVisualStyleBackColor = true;
            this.btnBatalPenjualan.Click += new System.EventHandler(this.btnBatalPenjualan_Click);
            // 
            // tabPagePembelian
            // 
            this.tabPagePembelian.Controls.Add(this.dataGridViewPembelian);
            this.tabPagePembelian.Controls.Add(this.btnBatalPembelian);
            this.tabPagePembelian.Location = new System.Drawing.Point(4, 23);
            this.tabPagePembelian.Name = "tabPagePembelian";
            this.tabPagePembelian.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePembelian.Size = new System.Drawing.Size(449, 247);
            this.tabPagePembelian.TabIndex = 4;
            this.tabPagePembelian.Text = "Pembelian";
            this.tabPagePembelian.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPembelian
            // 
            this.dataGridViewPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembelian.Location = new System.Drawing.Point(6, 10);
            this.dataGridViewPembelian.Name = "dataGridViewPembelian";
            this.dataGridViewPembelian.Size = new System.Drawing.Size(437, 197);
            this.dataGridViewPembelian.TabIndex = 18;
            // 
            // btnBatalPembelian
            // 
            this.btnBatalPembelian.Location = new System.Drawing.Point(359, 213);
            this.btnBatalPembelian.Name = "btnBatalPembelian";
            this.btnBatalPembelian.Size = new System.Drawing.Size(75, 23);
            this.btnBatalPembelian.TabIndex = 17;
            this.btnBatalPembelian.Text = "Back";
            this.btnBatalPembelian.UseVisualStyleBackColor = true;
            this.btnBatalPembelian.Click += new System.EventHandler(this.btnBatalPembelian_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(482, 302);
            this.Controls.Add(this.tabPageDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.List_Load);
            this.tabPageSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.tabPageDisplay.ResumeLayout(false);
            this.tabPageBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.tabPageCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.tabPagePenjualan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenjualan)).EndInit();
            this.tabPagePembelian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembelian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.Button btnBatalSupplier;
        private System.Windows.Forms.TabControl tabPageDisplay;
        private System.Windows.Forms.TabPage tabPageBarang;
        private System.Windows.Forms.Button btnBatalBarang;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.Button btnBatalCustomer;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TabPage tabPagePenjualan;
        private System.Windows.Forms.TabPage tabPagePembelian;
        private System.Windows.Forms.DataGridView dataGridViewPenjualan;
        private System.Windows.Forms.Button btnBatalPenjualan;
        private System.Windows.Forms.DataGridView dataGridViewPembelian;
        private System.Windows.Forms.Button btnBatalPembelian;
    }
}