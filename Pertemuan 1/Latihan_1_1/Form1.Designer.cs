namespace Satu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scrollTahun = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.bln = new System.Windows.Forms.Label();
            this.tgl = new System.Windows.Forms.Label();
            this.scrollBulan = new System.Windows.Forms.VScrollBar();
            this.scrollTanggal = new System.Windows.Forms.VScrollBar();
            this.tahun = new System.Windows.Forms.Label();
            this.dateDisplay = new System.Windows.Forms.DateTimePicker();
            this.scrollRangeTahun = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateDisplay2 = new System.Windows.Forms.DateTimePicker();
            this.tahun2 = new System.Windows.Forms.Label();
            this.scrollRangeTahun2 = new System.Windows.Forms.HScrollBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.scrollTahun);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bln);
            this.tabPage1.Controls.Add(this.tgl);
            this.tabPage1.Controls.Add(this.scrollBulan);
            this.tabPage1.Controls.Add(this.scrollTanggal);
            this.tabPage1.Controls.Add(this.tahun);
            this.tabPage1.Controls.Add(this.dateDisplay);
            this.tabPage1.Controls.Add(this.scrollRangeTahun);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(454, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Note: Msih ada bug saat scroll Agresive, Scroll dengan Panah lebih aman.. ^ ^";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tahun";
            // 
            // scrollTahun
            // 
            this.scrollTahun.Location = new System.Drawing.Point(295, 111);
            this.scrollTahun.Maximum = 21;
            this.scrollTahun.Name = "scrollTahun";
            this.scrollTahun.Size = new System.Drawing.Size(23, 115);
            this.scrollTahun.TabIndex = 10;
            this.scrollTahun.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollTahun_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // bln
            // 
            this.bln.AutoSize = true;
            this.bln.Location = new System.Drawing.Point(217, 239);
            this.bln.Name = "bln";
            this.bln.Size = new System.Drawing.Size(34, 13);
            this.bln.TabIndex = 8;
            this.bln.Text = "Bulan";
            // 
            // tgl
            // 
            this.tgl.AutoSize = true;
            this.tgl.Location = new System.Drawing.Point(139, 239);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(46, 13);
            this.tgl.TabIndex = 7;
            this.tgl.Text = "Tanggal";
            // 
            // scrollBulan
            // 
            this.scrollBulan.Location = new System.Drawing.Point(221, 111);
            this.scrollBulan.Maximum = 20;
            this.scrollBulan.Name = "scrollBulan";
            this.scrollBulan.Size = new System.Drawing.Size(23, 115);
            this.scrollBulan.TabIndex = 6;
            this.scrollBulan.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBulan_Scroll);
            // 
            // scrollTanggal
            // 
            this.scrollTanggal.Location = new System.Drawing.Point(149, 111);
            this.scrollTanggal.Maximum = 39;
            this.scrollTanggal.Name = "scrollTanggal";
            this.scrollTanggal.Size = new System.Drawing.Size(24, 115);
            this.scrollTanggal.TabIndex = 5;
            this.scrollTanggal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollTanggal_Scroll);
            // 
            // tahun
            // 
            this.tahun.AutoSize = true;
            this.tahun.Location = new System.Drawing.Point(302, 13);
            this.tahun.Name = "tahun";
            this.tahun.Size = new System.Drawing.Size(38, 13);
            this.tahun.TabIndex = 3;
            this.tahun.Text = "Tahun";
            // 
            // dateDisplay
            // 
            this.dateDisplay.Location = new System.Drawing.Point(6, 50);
            this.dateDisplay.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.Size = new System.Drawing.Size(56, 20);
            this.dateDisplay.TabIndex = 4;
            this.dateDisplay.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateDisplay.Visible = false;
            this.dateDisplay.ValueChanged += new System.EventHandler(this.dateDisplay_ValueChanged);
            // 
            // scrollRangeTahun
            // 
            this.scrollRangeTahun.Location = new System.Drawing.Point(114, 37);
            this.scrollRangeTahun.Maximum = 89;
            this.scrollRangeTahun.Minimum = 5;
            this.scrollRangeTahun.Name = "scrollRangeTahun";
            this.scrollRangeTahun.Size = new System.Drawing.Size(224, 26);
            this.scrollRangeTahun.TabIndex = 1;
            this.scrollRangeTahun.Value = 5;
            this.scrollRangeTahun.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Range Tahun";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.scrollRangeTahun2);
            this.tabPage2.Controls.Add(this.tahun2);
            this.tabPage2.Controls.Add(this.dateDisplay2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Range Tahun";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            // 
            // dateDisplay2
            // 
            this.dateDisplay2.Location = new System.Drawing.Point(144, 119);
            this.dateDisplay2.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateDisplay2.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateDisplay2.Name = "dateDisplay2";
            this.dateDisplay2.Size = new System.Drawing.Size(200, 20);
            this.dateDisplay2.TabIndex = 1;
            this.dateDisplay2.Value = new System.DateTime(2016, 10, 25, 23, 59, 59, 0);
            // 
            // tahun2
            // 
            this.tahun2.AutoSize = true;
            this.tahun2.Location = new System.Drawing.Point(306, 43);
            this.tahun2.Name = "tahun2";
            this.tahun2.Size = new System.Drawing.Size(38, 13);
            this.tahun2.TabIndex = 2;
            this.tahun2.Text = "Tahun";
            // 
            // scrollRangeTahun2
            // 
            this.scrollRangeTahun2.Location = new System.Drawing.Point(140, 82);
            this.scrollRangeTahun2.Minimum = 5;
            this.scrollRangeTahun2.Name = "scrollRangeTahun2";
            this.scrollRangeTahun2.Size = new System.Drawing.Size(204, 17);
            this.scrollRangeTahun2.TabIndex = 3;
            this.scrollRangeTahun2.Value = 5;
            this.scrollRangeTahun2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rangeTahun2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar scrollRangeTahun;
        private System.Windows.Forms.DateTimePicker dateDisplay;
        private System.Windows.Forms.Label tahun;
        private System.Windows.Forms.Label bln;
        private System.Windows.Forms.Label tgl;
        private System.Windows.Forms.VScrollBar scrollBulan;
        private System.Windows.Forms.VScrollBar scrollTanggal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.VScrollBar scrollTahun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar scrollRangeTahun2;
        private System.Windows.Forms.Label tahun2;
        private System.Windows.Forms.DateTimePicker dateDisplay2;
    }
}

