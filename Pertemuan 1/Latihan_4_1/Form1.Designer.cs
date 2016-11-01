namespace Latihan_4_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBgColor = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbColor
            // 
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(464, 29);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(237, 21);
            this.cbColor.TabIndex = 24;
            this.cbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor_DrawItem);
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Color";
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(306, 29);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(121, 21);
            this.cbFont.TabIndex = 22;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Font";
            // 
            // btnUnderline
            // 
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(230, 29);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(36, 23);
            this.btnUnderline.TabIndex = 20;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(188, 29);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(36, 23);
            this.btnItalic.TabIndex = 19;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnBold
            // 
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(146, 29);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(36, 23);
            this.btnBold.TabIndex = 18;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Font Size";
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(12, 58);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(689, 227);
            this.richTextBox.TabIndex = 16;
            this.richTextBox.Text = "";
            this.richTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseClick);
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            this.richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_KeyPress);
            this.richTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyUp);
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Location = new System.Drawing.Point(66, 31);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(74, 21);
            this.cbFontSize.TabIndex = 15;
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Text Background Color";
            // 
            // cbBgColor
            // 
            this.cbBgColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBgColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBgColor.FormattingEnabled = true;
            this.cbBgColor.Location = new System.Drawing.Point(134, 295);
            this.cbBgColor.Name = "cbBgColor";
            this.cbBgColor.Size = new System.Drawing.Size(237, 21);
            this.cbBgColor.TabIndex = 26;
            this.cbBgColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor_DrawItem);
            this.cbBgColor.SelectedIndexChanged += new System.EventHandler(this.cbBgColor_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 358);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbBgColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.cbFontSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBgColor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

