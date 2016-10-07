namespace Latihan_2_1
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
            this.tanggalUpDown = new System.Windows.Forms.DomainUpDown();
            this.bulanUpDown = new System.Windows.Forms.DomainUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // tanggalUpDown
            // 
            this.tanggalUpDown.Location = new System.Drawing.Point(13, 27);
            this.tanggalUpDown.Name = "tanggalUpDown";
            this.tanggalUpDown.Size = new System.Drawing.Size(119, 20);
            this.tanggalUpDown.TabIndex = 0;
            this.tanggalUpDown.Text = "Tanggal";
            // 
            // bulanUpDown
            // 
            this.bulanUpDown.Location = new System.Drawing.Point(153, 27);
            this.bulanUpDown.Name = "bulanUpDown";
            this.bulanUpDown.Size = new System.Drawing.Size(120, 20);
            this.bulanUpDown.TabIndex = 1;
            this.bulanUpDown.Text = "Bulan";
            this.bulanUpDown.SelectedItemChanged += new System.EventHandler(this.bulanUpDown_SelectedItemChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(300, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);

            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(396, 24);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Saturday;
            this.monthCalendar1.Location = new System.Drawing.Point(13, 63);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 387);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.bulanUpDown);
            this.Controls.Add(this.tanggalUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown tanggalUpDown;
        private System.Windows.Forms.DomainUpDown bulanUpDown;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

