namespace AdvancedTravel
{
    partial class myStationSearch
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
            this.mySearchFieldMain = new AdvancedTravel.MySearchField();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewStation = new System.Windows.Forms.DataGridView();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStation)).BeginInit();
            this.SuspendLayout();
            // 
            // mySearchFieldMain
            // 
            this.mySearchFieldMain.LabelLocation = new System.Drawing.Point(0, 5);
            this.mySearchFieldMain.LabelText = "LabelText:";
            this.mySearchFieldMain.LastSelect = new System.DateTime(((long)(0)));
            this.mySearchFieldMain.Location = new System.Drawing.Point(86, 0);
            this.mySearchFieldMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mySearchFieldMain.Name = "mySearchFieldMain";
            this.mySearchFieldMain.Size = new System.Drawing.Size(391, 80);
            this.mySearchFieldMain.TabIndex = 0;
            this.mySearchFieldMain.TextFieldLocation = new System.Drawing.Point(0, 38);
            this.mySearchFieldMain.TextFieldText = "";
            this.mySearchFieldMain.TextFieldWidth = 383;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearch.Location = new System.Drawing.Point(86, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(413, 51);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewStation
            // 
            this.dataGridViewStation.AllowUserToAddRows = false;
            this.dataGridViewStation.AllowUserToDeleteRows = false;
            this.dataGridViewStation.AllowUserToResizeRows = false;
            this.dataGridViewStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewStation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFrom,
            this.colTo,
            this.colDeparture});
            this.dataGridViewStation.Location = new System.Drawing.Point(86, 222);
            this.dataGridViewStation.MultiSelect = false;
            this.dataGridViewStation.Name = "dataGridViewStation";
            this.dataGridViewStation.RowHeadersVisible = false;
            this.dataGridViewStation.RowTemplate.Height = 24;
            this.dataGridViewStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewStation.Size = new System.Drawing.Size(413, 410);
            this.dataGridViewStation.TabIndex = 11;
            // 
            // colFrom
            // 
            this.colFrom.HeaderText = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.Width = 69;
            // 
            // colTo
            // 
            this.colTo.HeaderText = "To";
            this.colTo.Name = "colTo";
            this.colTo.Width = 54;
            // 
            // colDeparture
            // 
            this.colDeparture.HeaderText = "Departure";
            this.colDeparture.Name = "colDeparture";
            this.colDeparture.Width = 101;
            // 
            // myStationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewStation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.mySearchFieldMain);
            this.Name = "myStationSearch";
            this.Size = new System.Drawing.Size(562, 643);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MySearchField mySearchFieldMain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparture;
    }
}
