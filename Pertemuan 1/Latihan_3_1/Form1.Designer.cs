namespace Latihan_3_1
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
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Location = new System.Drawing.Point(66, 12);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(74, 21);
            this.cbFontSize.TabIndex = 0;
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(12, 39);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(689, 227);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseClick);
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            this.richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_KeyPress);
            this.richTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Font Size";
            // 
            // btnBold
            // 
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(146, 10);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(36, 23);
            this.btnBold.TabIndex = 5;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(188, 10);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(36, 23);
            this.btnItalic.TabIndex = 6;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(230, 10);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(36, 23);
            this.btnUnderline.TabIndex = 7;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Font";
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(306, 10);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(121, 21);
            this.cbFont.TabIndex = 9;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(464, 10);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(237, 21);
            this.cbColor.TabIndex = 14;
            this.cbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor_DrawItem);
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 311);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbColor;
    }
}

    