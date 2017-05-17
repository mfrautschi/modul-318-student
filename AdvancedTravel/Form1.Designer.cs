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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnNow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLater = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnShare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(20, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "To:";
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
            this.txtTo.Size = new System.Drawing.Size(389, 36);
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
            this.dtpDate.Size = new System.Drawing.Size(233, 22);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(181, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(463, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time:";
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
            this.btnSearch.Location = new System.Drawing.Point(187, 497);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(602, 63);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.btnShare.Location = new System.Drawing.Point(423, 667);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(112, 37);
            this.btnShare.TabIndex = 11;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1012, 735);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnLater);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLater;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnShare;
    }
}

