namespace AdvancedTravel
{
    partial class mySideSearch
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
            this.mySearchFieldFrom = new AdvancedTravel.mySearchField();
            this.mySearchFieldTo = new AdvancedTravel.mySearchField();
            this.btnNow = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.dtmTime = new System.Windows.Forms.DateTimePicker();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewConnection = new System.Windows.Forms.DataGridView();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // mySearchFieldFrom
            // 
            this.mySearchFieldFrom.LabelText = "LabelText:";
            this.mySearchFieldFrom.LastSelect = new System.DateTime(((long)(0)));
            this.mySearchFieldFrom.Location = new System.Drawing.Point(0, -1);
            this.mySearchFieldFrom.Margin = new System.Windows.Forms.Padding(4);
            this.mySearchFieldFrom.Name = "mySearchFieldFrom";
            this.mySearchFieldFrom.Size = new System.Drawing.Size(388, 80);
            this.mySearchFieldFrom.TabIndex = 0;
             this.mySearchFieldFrom.TextFieldText = "";
             this.mySearchFieldFrom.Enter += new System.EventHandler(this.mySearchFieldFrom_Enter);
            // 
            // mySearchFieldTo
            // 
             this.mySearchFieldTo.LabelText = "LabelText:";
            this.mySearchFieldTo.LastSelect = new System.DateTime(((long)(0)));
            this.mySearchFieldTo.Location = new System.Drawing.Point(0, 97);
            this.mySearchFieldTo.Margin = new System.Windows.Forms.Padding(4);
            this.mySearchFieldTo.Name = "mySearchFieldTo";
            this.mySearchFieldTo.Size = new System.Drawing.Size(388, 80);
            this.mySearchFieldTo.TabIndex = 1;
            this.mySearchFieldTo.TextFieldText = "";
             this.mySearchFieldTo.Enter += new System.EventHandler(this.mySearchFieldTo_Enter);
            // 
            // btnNow
            // 
            this.btnNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNow.Location = new System.Drawing.Point(0, 184);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(381, 46);
            this.btnNow.TabIndex = 2;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 244);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 31);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(16, 320);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 31);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // dtmDate
            // 
            this.dtmDate.Location = new System.Drawing.Point(19, 285);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(362, 22);
            this.dtmDate.TabIndex = 3;
            // 
            // dtmTime
            // 
            this.dtmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmTime.Location = new System.Drawing.Point(22, 358);
            this.dtmTime.Name = "dtmTime";
            this.dtmTime.ShowUpDown = true;
            this.dtmTime.Size = new System.Drawing.Size(105, 22);
            this.dtmTime.TabIndex = 4;
            this.dtmTime.ValueChanged += new System.EventHandler(this.timeValueChanged);
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOn.Location = new System.Drawing.Point(199, 337);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(54, 43);
            this.btnOn.TabIndex = 5;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(273, 337);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(54, 43);
            this.btnOff.TabIndex = 6;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearch.Location = new System.Drawing.Point(3, 405);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(378, 51);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewConnection
            // 
            this.dataGridViewConnection.AllowUserToAddRows = false;
            this.dataGridViewConnection.AllowUserToDeleteRows = false;
            this.dataGridViewConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConnection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFrom,
            this.colTo,
            this.colDeparture,
            this.colArrival,
            this.colDuration});
            this.dataGridViewConnection.Location = new System.Drawing.Point(450, 18);
            this.dataGridViewConnection.Name = "dataGridViewConnection";
            this.dataGridViewConnection.RowHeadersVisible = false;
            this.dataGridViewConnection.RowTemplate.Height = 24;
            this.dataGridViewConnection.Size = new System.Drawing.Size(666, 438);
            this.dataGridViewConnection.TabIndex = 10;
            // 
            // colFrom
            // 
            this.colFrom.HeaderText = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.ReadOnly = true;
            this.colFrom.Width = 69;
            // 
            // colTo
            // 
            this.colTo.HeaderText = "To";
            this.colTo.Name = "colTo";
            this.colTo.ReadOnly = true;
            this.colTo.Width = 54;
            // 
            // colDeparture
            // 
            this.colDeparture.HeaderText = "Departure";
            this.colDeparture.Name = "colDeparture";
            this.colDeparture.ReadOnly = true;
            this.colDeparture.Width = 101;
            // 
            // colArrival
            // 
            this.colArrival.HeaderText = "Arrival";
            this.colArrival.Name = "colArrival";
            this.colArrival.ReadOnly = true;
            this.colArrival.Width = 77;
            // 
            // colDuration
            // 
            this.colDuration.HeaderText = "Duration";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.Width = 91;
            // 
            // mySideSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.mySearchFieldFrom);
            this.Controls.Add(this.dataGridViewConnection);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.dtmTime);
            this.Controls.Add(this.dtmDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.mySearchFieldTo);
            this.Name = "mySideSearch";
            this.Size = new System.Drawing.Size(1130, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mySearchField mySearchFieldFrom;
        private mySearchField mySearchFieldTo;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.DateTimePicker dtmTime;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridView dataGridViewConnection;
    }
}
