namespace AdvancedTravel
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSwitch = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnNow = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLater = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnShare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.columnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStation = new System.Windows.Forms.Button();
            this.mySearchFieldTo = new AdvancedTravel.MySearchField();
            this.mySearchFieldFrom = new AdvancedTravel.MySearchField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitch.Image")));
            this.btnSwitch.Location = new System.Drawing.Point(340, 115);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(29, 37);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpDate.Location = new System.Drawing.Point(140, 332);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(191, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // btnNow
            // 
            this.btnNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNow.Location = new System.Drawing.Point(250, 203);
            this.btnNow.Margin = new System.Windows.Forms.Padding(2);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(92, 36);
            this.btnNow.TabIndex = 4;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDate.Location = new System.Drawing.Point(136, 305);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 26);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTime.Location = new System.Drawing.Point(347, 305);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 26);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time:";
            // 
            // btnLater
            // 
            this.btnLater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLater.Location = new System.Drawing.Point(367, 203);
            this.btnLater.Margin = new System.Windows.Forms.Padding(2);
            this.btnLater.Name = "btnLater";
            this.btnLater.Size = new System.Drawing.Size(92, 36);
            this.btnLater.TabIndex = 5;
            this.btnLater.Text = "Later";
            this.btnLater.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOn.Location = new System.Drawing.Point(474, 328);
            this.btnOn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(37, 30);
            this.btnOn.TabIndex = 8;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(532, 328);
            this.btnOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(41, 30);
            this.btnOff.TabIndex = 9;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSearch.Location = new System.Drawing.Point(140, 414);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(452, 51);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(352, 332);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(72, 20);
            this.dtpTime.TabIndex = 7;
            // 
            // btnShare
            // 
            this.btnShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShare.Location = new System.Drawing.Point(317, 542);
            this.btnShare.Margin = new System.Windows.Forms.Padding(2);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(84, 30);
            this.btnShare.TabIndex = 11;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.label1.Location = new System.Drawing.Point(194, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 53);
            this.label1.TabIndex = 15;
            this.label1.Text = "Advanced Travel";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeColumns = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFrom,
            this.columnTo,
            this.columnDeparture,
            this.columnArrival,
            this.columnDuration});
            this.dataGridViewMain.Location = new System.Drawing.Point(280, 109);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(469, 479);
            this.dataGridViewMain.TabIndex = 16;
            // 
            // columnFrom
            // 
            this.columnFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnFrom.HeaderText = "From";
            this.columnFrom.Name = "columnFrom";
            this.columnFrom.ReadOnly = true;
            // 
            // columnTo
            // 
            this.columnTo.HeaderText = "To";
            this.columnTo.Name = "columnTo";
            this.columnTo.ReadOnly = true;
            this.columnTo.Width = 150;
            // 
            // columnDeparture
            // 
            this.columnDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnDeparture.HeaderText = "Departure";
            this.columnDeparture.MaxInputLength = 10;
            this.columnDeparture.Name = "columnDeparture";
            this.columnDeparture.ReadOnly = true;
            this.columnDeparture.Width = 79;
            // 
            // columnArrival
            // 
            this.columnArrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnArrival.HeaderText = "Arrival";
            this.columnArrival.MaxInputLength = 10;
            this.columnArrival.Name = "columnArrival";
            this.columnArrival.ReadOnly = true;
            this.columnArrival.Width = 61;
            // 
            // columnDuration
            // 
            this.columnDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnDuration.HeaderText = "Duration";
            this.columnDuration.MaxInputLength = 10;
            this.columnDuration.Name = "columnDuration";
            this.columnDuration.ReadOnly = true;
            this.columnDuration.Width = 72;
            // 
            // btnStation
            // 
            this.btnStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStation.Font = new System.Drawing.Font("Arial", 9F);
            this.btnStation.Location = new System.Drawing.Point(34, 26);
            this.btnStation.Margin = new System.Windows.Forms.Padding(2);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(97, 41);
            this.btnStation.TabIndex = 17;
            this.btnStation.Text = "Search for Station";
            this.btnStation.UseVisualStyleBackColor = true;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // mySearchFieldTo
            // 
            this.mySearchFieldTo.LabelLocation = new System.Drawing.Point(0, 4);
            this.mySearchFieldTo.LabelText = "LabelText:";
            this.mySearchFieldTo.Location = new System.Drawing.Point(422, 93);
            this.mySearchFieldTo.Name = "mySearchFieldTo";
            this.mySearchFieldTo.Size = new System.Drawing.Size(293, 65);
            this.mySearchFieldTo.TabIndex = 19;
            this.mySearchFieldTo.TextFieldLocation = new System.Drawing.Point(0, 31);
            this.mySearchFieldTo.TextFieldText = "";
            this.mySearchFieldTo.TextFieldWidth = 288;
            // 
            // mySearchFieldFrom
            // 
            this.mySearchFieldFrom.LabelLocation = new System.Drawing.Point(0, 4);
            this.mySearchFieldFrom.LabelText = "LabelText:";
            this.mySearchFieldFrom.Location = new System.Drawing.Point(34, 93);
            this.mySearchFieldFrom.Name = "mySearchFieldFrom";
            this.mySearchFieldFrom.Size = new System.Drawing.Size(293, 65);
            this.mySearchFieldFrom.TabIndex = 20;
            this.mySearchFieldFrom.TextFieldLocation = new System.Drawing.Point(0, 31);
            this.mySearchFieldFrom.TextFieldText = "";
            this.mySearchFieldFrom.TextFieldWidth = 288;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(759, 597);
            this.Controls.Add(this.mySearchFieldFrom);
            this.Controls.Add(this.mySearchFieldTo);
            this.Controls.Add(this.btnStation);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnLater);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSwitch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnLater;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button btnStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDuration;
        private MySearchField mySearchFieldTo;
        private MySearchField mySearchFieldFrom;
    }
}

