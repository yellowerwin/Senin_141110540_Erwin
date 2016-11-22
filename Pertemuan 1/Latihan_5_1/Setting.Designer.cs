namespace Latihan_5_1
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Background Color");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeEditor = new System.Windows.Forms.TreeView();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeEditor
            // 
            this.treeEditor.Location = new System.Drawing.Point(12, 12);
            this.treeEditor.Name = "treeEditor";
            treeNode5.Name = "nodeBgColor";
            treeNode5.Text = "Background Color";
            treeNode6.Name = "nodeTheme";
            treeNode6.Text = "Theme";
            this.treeEditor.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeEditor.Size = new System.Drawing.Size(162, 348);
            this.treeEditor.TabIndex = 1;
            this.treeEditor.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeEditor_AfterSelect);
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.cbColor);
            this.panelSetting.Controls.Add(this.label1);
            this.panelSetting.Controls.Add(this.cmdSave);
            this.panelSetting.Location = new System.Drawing.Point(180, 13);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(254, 347);
            this.panelSetting.TabIndex = 2;
            this.panelSetting.Visible = false;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(14, 58);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(225, 21);
            this.cbColor.TabIndex = 2;
            this.cbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor_DrawItem);
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbBgColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background Color : ";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(164, 309);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 372);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.treeEditor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeEditor;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSave;
    }
}