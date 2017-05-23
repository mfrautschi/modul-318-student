namespace AdvancedTravel
{
    partial class AdvancedTravelView
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
            this.mySideSearchMain = new AdvancedTravel.mySideSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStation = new System.Windows.Forms.Button();
            this.myStationSearchMain = new AdvancedTravel.myStationSearch();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStandardSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mySideSearchMain
            // 
            this.mySideSearchMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mySideSearchMain.BackColor = System.Drawing.SystemColors.Window;
            this.mySideSearchMain.Location = new System.Drawing.Point(12, 93);
            this.mySideSearchMain.Name = "mySideSearchMain";
            this.mySideSearchMain.Size = new System.Drawing.Size(1210, 597);
            this.mySideSearchMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Advanced Travel";
            // 
            // btnStation
            // 
            this.btnStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStation.Font = new System.Drawing.Font("Arial", 9F);
            this.btnStation.Location = new System.Drawing.Point(56, 24);
            this.btnStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(129, 50);
            this.btnStation.TabIndex = 18;
            this.btnStation.Text = "Search for Station";
            this.btnStation.UseVisualStyleBackColor = true;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // myStationSearchMain
            // 
            this.myStationSearchMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myStationSearchMain.Location = new System.Drawing.Point(319, 93);
            this.myStationSearchMain.Name = "myStationSearchMain";
            this.myStationSearchMain.Size = new System.Drawing.Size(562, 665);
            this.myStationSearchMain.TabIndex = 19;
            this.myStationSearchMain.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(1118, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 40);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "&Canc&el";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStandardSearch
            // 
            this.btnStandardSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandardSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStandardSearch.Location = new System.Drawing.Point(30, 696);
            this.btnStandardSearch.Name = "btnStandardSearch";
            this.btnStandardSearch.Size = new System.Drawing.Size(104, 40);
            this.btnStandardSearch.TabIndex = 21;
            this.btnStandardSearch.Text = "Search";
            this.btnStandardSearch.UseVisualStyleBackColor = true;
             // 
            // AdvancedTravelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1234, 767);
            this.Controls.Add(this.btnStandardSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.myStationSearchMain);
            this.Controls.Add(this.btnStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mySideSearchMain);
            this.Name = "AdvancedTravelView";
            this.Text = "AdvancedTravelView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mySideSearch mySideSearchMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStation;
        private myStationSearch myStationSearchMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStandardSearch;
    }
}