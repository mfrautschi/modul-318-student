namespace AdvancedTravel
{
    partial class MySearchField
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
            this.txtSearch.Location = new System.Drawing.Point(0, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblText.Location = new System.Drawing.Point(0, 4);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(112, 26);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "LabelText:";
            // 
            // lstSearch
            // 
            this.lstSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstSearch.FormattingEnabled = true;
            this.lstSearch.ItemHeight = 16;
            this.lstSearch.Location = new System.Drawing.Point(0, 62);
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(288, 84);
            this.lstSearch.TabIndex = 2;
            this.lstSearch.Visible = false;
            // 
            // MySearchField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstSearch);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtSearch);
            this.Name = "MySearchField";
            this.Size = new System.Drawing.Size(293, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ListBox lstSearch;
    }
}
