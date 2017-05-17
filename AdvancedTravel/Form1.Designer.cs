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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblFrom.Location = new System.Drawing.Point(20, 112);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(85, 31);
            this.lblFrom.TabIndex = 13;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(538, 115);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(54, 31);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "To:";
            // 
            // btnSwitch
            // 
            this.btnSwitch.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitch.Image")));
            this.btnSwitch.Location = new System.Drawing.Point(453, 142);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(39, 46);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTo.Location = new System.Drawing.Point(544, 149);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(384, 36);
            this.txtTo.TabIndex = 2;
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFrom.Location = new System.Drawing.Point(26, 146);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(383, 36);
            this.txtFrom.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpDate.Location = new System.Drawing.Point(187, 409);
            this.dtpDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(253, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // btnNow
            // 
            this.btnNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNow.Location = new System.Drawing.Point(334, 250);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(122, 44);
            this.btnNow.TabIndex = 4;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDate.Location = new System.Drawing.Point(181, 375);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 31);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTime.Location = new System.Drawing.Point(463, 375);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 31);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time:";
            // 
            // btnLater
            // 
            this.btnLater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLater.Location = new System.Drawing.Point(489, 250);
            this.btnLater.Name = "btnLater";
            this.btnLater.Size = new System.Drawing.Size(122, 44);
            this.btnLater.TabIndex = 5;
            this.btnLater.Text = "Later";
            this.btnLater.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOn.Location = new System.Drawing.Point(632, 404);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(49, 37);
            this.btnOn.TabIndex = 8;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(709, 404);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(55, 37);
            this.btnOff.TabIndex = 9;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSearch.Location = new System.Drawing.Point(187, 509);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(602, 63);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(469, 409);
            this.dtpTime.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(95, 22);
            this.dtpTime.TabIndex = 7;
            // 
            // btnShare
            // 
            this.btnShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShare.Location = new System.Drawing.Point(423, 667);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(112, 37);
            this.btnShare.TabIndex = 11;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.label1.Location = new System.Drawing.Point(259, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 65);
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
            this.dataGridViewMain.Location = new System.Drawing.Point(375, 134);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(625, 589);
            this.dataGridViewMain.TabIndex = 16;
            // 
            // columnFrom
            // 
            this.columnFrom.HeaderText = "From";
            this.columnFrom.Name = "columnFrom";
            this.columnFrom.ReadOnly = true;
            // 
            // columnTo
            // 
            this.columnTo.HeaderText = "To";
            this.columnTo.Name = "columnTo";
            this.columnTo.ReadOnly = true;
            // 
            // columnDeparture
            // 
            this.columnDeparture.HeaderText = "Departure";
            this.columnDeparture.Name = "columnDeparture";
            this.columnDeparture.ReadOnly = true;
            // 
            // columnArrival
            // 
            this.columnArrival.HeaderText = "Arrival";
            this.columnArrival.Name = "columnArrival";
            this.columnArrival.ReadOnly = true;
            // 
            // columnDuration
            // 
            this.columnDuration.HeaderText = "Duration";
            this.columnDuration.Name = "columnDuration";
            this.columnDuration.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1012, 735);
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
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDuration;
        private System.Windows.Forms.DataGridView dataGridViewMain;
    }
}

