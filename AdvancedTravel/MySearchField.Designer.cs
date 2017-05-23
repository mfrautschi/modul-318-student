namespace AdvancedTravel
{
    partial class mySearchField
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lstSearch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSearch.Location = new System.Drawing.Point(0, 38);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(383, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblText.Location = new System.Drawing.Point(0, 5);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(141, 31);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "LabelText:";
            // 
            // lstSearch
            // 
            this.lstSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstSearch.FormattingEnabled = true;
            this.lstSearch.ItemHeight = 20;
            this.lstSearch.Location = new System.Drawing.Point(0, 76);
            this.lstSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(383, 84);
            this.lstSearch.TabIndex = 2;
            this.lstSearch.Visible = false;
            this.lstSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSearch_MouseClick);
            this.lstSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSearch_KeyDown);
            // 
            // MySearchField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lstSearch);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MySearchField";
            this.Size = new System.Drawing.Size(391, 80);
            this.Leave += new System.EventHandler(this.MySearchField_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ListBox lstSearch;
    }
}
