namespace TelerikWinFormsApp3
{
    partial class HashTable
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(17, 46);
            this.radTextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(91, 21);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.ThemeName = "VisualStudio2012Dark";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(17, 91);
            this.radButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(91, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Add";
            this.radButton2.ThemeName = "VisualStudio2012Dark";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(17, 132);
            this.radButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(91, 24);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Search";
            this.radButton1.ThemeName = "VisualStudio2012Dark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(17, 177);
            this.radButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(91, 24);
            this.radButton3.TabIndex = 4;
            this.radButton3.Text = "Delete";
            this.radButton3.ThemeName = "VisualStudio2012Dark";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.EnableHotTracking = false;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(129, 21);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Index";
            gridViewTextBoxColumn3.MinWidth = 0;
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.RowSpan = 0;
            gridViewTextBoxColumn3.Width = 60;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(537, 289);
            this.radGridView1.TabIndex = 6;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "VisualStudio2012Dark";
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // radButton4
            // 
            this.radButton4.Location = new System.Drawing.Point(17, 223);
            this.radButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(91, 24);
            this.radButton4.TabIndex = 7;
            this.radButton4.Text = "Randomize";
            this.radButton4.ThemeName = "VisualStudio2012Dark";
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // radButton5
            // 
            this.radButton5.Location = new System.Drawing.Point(17, 271);
            this.radButton5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(91, 24);
            this.radButton5.TabIndex = 8;
            this.radButton5.Text = "Clear";
            this.radButton5.ThemeName = "VisualStudio2012Dark";
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            // 
            // HashTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 338);
            this.Controls.Add(this.radButton5);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "HashTable";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashTable";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.HashTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadButton radButton5;
    }
}
